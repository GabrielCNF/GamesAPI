using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesAPI.Models;

public partial class Estilo
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome do Estilo Obrigatório")]
    [Display(Name = "Nome do Estilo Obrigatório")]
    public string Nome { get; set; }

    public virtual ICollection<Estilo> JogoEstiloSecs { get; set; } = new List<Estilo>();

    public virtual ICollection<Estilo> JogoEstiloTercs { get; set; } = new List<Estilo>();

    public virtual ICollection<Estilo> JogoEstilos { get; set; } = new List<Estilo>();
}
