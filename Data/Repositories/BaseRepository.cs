using AppDbContext;
using GamesAPI.Data.Contexts;
using GamesAPI.Data.Repositories.Interfaces;
using GamesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GamesAPI.Data.Repositories
{
    public class BaseRepository<T> where T : class
    {
        private SampleDataContext _context;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("UnitOfWork");

            _context = unitOfWork as SampleDataContext;
        }
        public T Find(int id) 
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> List()
        {
            return _context.Set<T>();
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Remove(T item)
        {
            _context.Set<T>().Remove(item);
        }
        
        public void Edit(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Dispose() 
        {
            _context.Dispose();
        }
    }
}
