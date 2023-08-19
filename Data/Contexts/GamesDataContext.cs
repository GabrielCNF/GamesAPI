using AppDbContext;
using GamesAPI.Data.Contexts.Interfaces;
using GamesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesAPI.Data.Contexts
{
    public class GamesDataContext : DbContext, IUnitOfWork
    {
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Desenvolvedora> Desenvolvedoras { get; set; }
        public DbSet<Estilo> Estilos { get; set; }
        public DbSet<Distribuidora> Distribuidoras { get; set; }
        public void Save() 
        {
            base.SaveChanges();
        }
    }
}
