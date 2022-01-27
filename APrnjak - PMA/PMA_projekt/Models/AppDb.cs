using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Models
{
    public class AppDb : IdentityDbContext
    {
        //baza podataka za korisnike koji se prijavljuju, spremamo username, email i password
        public AppDb(DbContextOptions<AppDb> options)
            : base(options) 
        {

        }
    }
}
