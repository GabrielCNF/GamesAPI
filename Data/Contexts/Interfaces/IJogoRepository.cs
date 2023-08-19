using GamesAPI.Data.Repositories.Interfaces;
using GamesAPI.Models;

namespace GamesAPI.Data.Contexts.Interfaces
{
    public interface IJogoRepository : IBaseRepository<Jogo>, IDisposable
    {
        
    }
}
