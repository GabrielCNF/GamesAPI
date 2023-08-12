using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesAPI.Models;

public partial class Desenvolvedora
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo Obrigatório")]
    [Display(Name = "Nome da Desenvolvedora")]
    public string? Nome { get; set; }

    public virtual ICollection<Desenvolvedora> Desenvolvedoras { get; set; } = new List<Desenvolvedora>();
}
