using GamesAPI.Models;

namespace GamesAPI.Data.Repositories.Interfaces
{
    public interface IJogoService: IBaseRepository<Jogo>, IDisposable
    {
        bool Validate(Jogo jogo)
    }
}
