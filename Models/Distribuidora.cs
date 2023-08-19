using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesAPI.Models;

public partial class Distribuidora
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório.")]
    [Display(Name = "Nome da Distribuidora")]
    public string Nome { get; set; }

    public virtual ICollection<Distribuidora> Distribuidoras { get; set; } = new List<Distribuidora>();
    public virtual ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();
}
