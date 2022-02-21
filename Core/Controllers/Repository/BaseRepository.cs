using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Controllers.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        //db bağlantısı
        private DataContext db;
        public BaseRepository(DataContext _db)
        {
            db = _db;
        }

        public T Bul(int id)
        {
            return Set().Find(id);
        }

        public void Ekle(T entity)
        {
            Set().Add(entity);
        }

        public IQueryable<T> GenelListe()
        {
            return Set().AsQueryable();   
        }

        public void Guncel()
        {
            db.SaveChanges();
        }

        public List<T> Listele()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Sil(T entity)
        {
            Set().Remove(entity);
        }

     
    }
}
