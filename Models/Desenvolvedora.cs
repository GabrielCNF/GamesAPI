using System;
using System.Collections.Generic;

namespace GamesAPI.Models;

public partial class Desenvolvedora
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();
}
