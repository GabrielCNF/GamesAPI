using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesAPI.Models;

public partial class Jogo
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int EstiloId { get; set; }

    public int? EstiloSecId { get; set; }

    public int? EstiloTercId { get; set; }

    public DateTime? DataLancamento { get; set; }

    public int DesenvolvedoraId { get; set; }

    public int DistribuidoraId { get; set; }
    
    [Required(ErrorMessage = "Desenvolvedora Obrigatória")]
    [Display(Name = "Desenvolvedora")]
    public virtual Desenvolvedora Desenvolvedora { get; set; }

    [Required(ErrorMessage = "Distribuídora Obrigatória")]
    [Display(Name = "Distribuidora")]
    public virtual Distribuidora Distribuidora { get; set; }

    public virtual Estilo Estilo { get; set; } = null!;

    public virtual Estilo? EstiloSec { get; set; }

    public virtual Estilo? EstiloTerc { get; set; }
}
