using AppDbContext;
using GamesAPI.Data.Contexts;
using GamesAPI.Data.Repositories.Interfaces;
using GamesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GamesAPI.Service
{
    public class JogoRepository<T> where T : class
    {
        IUnitOfWork unitOfWork = new SampleDataContext();

        public JogoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
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
