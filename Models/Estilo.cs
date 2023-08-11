using System;
using System.Collections.Generic;

namespace GamesAPI.Models;

public partial class Estilo
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Jogo> JogoEstiloSecs { get; set; } = new List<Jogo>();

    public virtual ICollection<Jogo> JogoEstiloTercs { get; set; } = new List<Jogo>();

    public virtual ICollection<Jogo> JogoEstilos { get; set; } = new List<Jogo>();
}
