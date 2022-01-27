using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PMA_projekt.DbModels;
using PMA_projekt.Models;
using PMA_projekt.Repositories;
using PMA_projekt.Services;

namespace PMA_projekt
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //referenca na moju bazu
        private void SetupDbContext(IServiceCollection services)
        {
            var connString = Configuration.GetConnectionString("pma");
            services.AddDbContext<pma_postContext> (options => options.UseSqlServer(connString));   //svakom servisu dodaj kontekst baze podataka koju mora gledati
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddNewtonsoftJson();
            services.AddControllersWithViews();

            //dodajemo nove servise
            services.AddScoped<PostRepository>();
            services.AddScoped<PostService>();
            services.AddScoped<CityRepository>();
            services.AddScoped<CityService>();
            services.AddScoped<PlaceRepository>();
            services.AddScoped<PlaceService>();

            SetupDbContext(services);//svaki servis mora imati kontekst baze podataka

            services.AddDbContext<AppDb>(config =>
            {
                config.UseInMemoryDatabase("Memory");
            });  //imamo konekciju na ovu stvorenu bazu kroz cijeli projekt, koristi se za spremanje korisnika koji se registriraju; ne rabi sql server nego direkno memoriju racunala


            //AddIdentity dodaje sve servise za registraciju i logiranje korisnika
            services.AddIdentity<IdentityUser, IdentityRole>(config => {
                config.Password.RequiredLength = 3;
                config.Password.RequireDigit = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.Password.RequireLowercase = false;
            })
                .AddEntityFrameworkStores<AppDb>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(config =>
            {
                config.Cookie.Name = "PMA.Identity.Cookie"; //naziv cookie-a
                config.LoginPath = "/Home/Login";  //login
                config.AccessDeniedPath = new PathString("/Home/AccessDenied");   // u slucaju neovlastenog pristupa dijelu stranice vracamo ovaj view
            });
        }
        private async Task CreateAdmin(IServiceProvider serviceProvider)
        {
            //initializing custom roles 
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string[] roleNames = { "Admin", "User", "Manager", "Visitor" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    //ako ne postoji uloga spremljena u bazu tj. memoriju onda je stvaramo i spremamo asinkrono
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            //admin koji ce imati sve ovlasti
            var admin = new IdentityUser
            {
                UserName = "Klara",
                Email = "kmilos@pmfst.hr",
            };
            //Ensure you have these values in your appsettings.json file
            string adminpassword = "klara1234";
            var _adminuser = await UserManager.FindByEmailAsync("kmilos@pmfst.hr");

            if (_adminuser == null)
            {
                var createadmin = await UserManager.CreateAsync(admin, adminpassword);
                if (createadmin.Succeeded)
                {
                    //povezujemo admina sa ulogom
                    await UserManager.AddToRoleAsync(admin, "Admin");

                }
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            CreateAdmin(serviceProvider).Wait();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Login}/{id?}");

                endpoints.MapControllerRoute(
                    name: "City",
                    pattern: "city",
                    defaults: new { controller = "City", action = "City" }); //koji kontroler i koja akcija tog kontrolera ce se zvati

                endpoints.MapControllerRoute(
                   name: "Post",
                   pattern: "post",
                   defaults: new { controller = "Post", action = "Post" });

                endpoints.MapControllerRoute(
                   name: "Place",
                   pattern: "place",
                   defaults: new { controller = "Place", action = "Place" });

            });
        }
    }
}
