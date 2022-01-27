using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using PMA_projekt.DbModels;
using PMA_projekt.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMA_projekt.Repositories
{
    public class PostRepository
    {
        //mora primiti kontekst baze podataka
        private readonly pma_postContext _dbContext;
        public PostRepository(pma_postContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.Objava> GetAll()
        {
            return _dbContext.Objava
                .Include(g => g.Grad)  //ne zelimo da nam ispisuje id već naziv grada kojem pripada, pa ukljucujemo i tablicu grad
                .Include(o => o.Objekt)
                .Select(x => PostMapper.FromDatabase(x));
        }

        public Models.Objava GetAll(int id)
        {
            return _dbContext.Objava
                .Where(c => c.Id == id)
                .Include(g => g.Grad)  //ne zelimo da nam ispisuje id već naziv grada kojem pripada, pa ukljucujemo i tablicu grad
                .Include(o => o.Objekt)
                .Select(x => PostMapper.FromDatabase(x))
                .FirstOrDefault();
        }

        public IEnumerable<Models.Objava> DeleteAndReturnAll(int id)
        {
            var dbObjava = _dbContext.Objava
                .Where(c => c.Id == id)  //trazimo odgovarajuci podatak
                .FirstOrDefault();       //daj nam prvi pronadeni, trebao bi biti jedini jer je id jedinstven

            _dbContext.Objava.Remove(dbObjava);
            _dbContext.SaveChanges();  //nakon svake operacije sa bazom potrebno je spremiti promjene

            return _dbContext.Objava
                .Include(g => g.Grad)
                .Include(o => o.Objekt)
                .Select(x => PostMapper.FromDatabase(x));
        }

        public IEnumerable<Models.Objava> Update(Models.Objava objava)
        {
            var dbPost = PostMapper.ToDatabase(objava); //podatak pogodan za bazu
            var existing = _dbContext.Objava.Find(dbPost.Id);

            if (existing != null) //pronasao je podatak
            {
                existing.Sadrzaj = dbPost.Sadrzaj;
                existing.Datum = dbPost.Datum;
                existing.GradId = dbPost.GradId;
                existing.ObjektId = dbPost.ObjektId;
                _dbContext.SaveChanges();
            }

            return _dbContext.Objava
                .Include(g => g.Grad)
                .Include(o => o.Objekt)
                .Select(x => PostMapper.FromDatabase(x));
        }

        public void Save(Models.Objava objava)
        {
            var dbPost = PostMapper.ToDatabase(objava); //podatak pogodan za bazu
            _dbContext.Objava.Add(dbPost);
            _dbContext.SaveChanges();
        }
    }
}
