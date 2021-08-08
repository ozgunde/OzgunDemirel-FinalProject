using Microsoft.EntityFrameworkCore;
using Music.DataAccess.Data;
using Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Music.DataAccess.Repositories
{
    public class EFGenreRepository : IGenreRepository
    {
        private MusicsDbContext db;

        public EFGenreRepository(MusicsDbContext musicsDbContext)
        {
            db = musicsDbContext;
        }
        public Genre Add(Genre entity)
        {
            db.Genres.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.Genres.Remove(GetByID(id));
            db.SaveChanges();
        }
        public void Delete(Genre entity)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public Genre GetByID(int id)
        {
            return db.Genres.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<Genre> GetWithCriteria(Expression<Func<Genre, bool>> criteria)
        {
            return db.Genres.Where(criteria).ToList();
        }

        public IList<Genre> GetWithCriteria(Func<Genre, bool> criteria)
        {
            return db.Genres.Where(criteria).ToList();
        }

        public Genre Update(Genre genre)
        {
            db.Entry(genre).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return genre;
        }
    }
}
