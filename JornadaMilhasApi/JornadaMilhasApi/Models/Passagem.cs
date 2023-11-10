using System.ComponentModel.DataAnnotations;

namespace JornadaMilhasApi.Models;

public record Passagem : IEntity
{
    [Required]
    public required string Tipo { get; init; }
    [Required]
    public int PrecoIda { get; init; }
    [Required]
    public int PrecoVolta { get; init; }
    [Required]
    public int TaxaEmbarque { get; init; }
    [Required]
    public int Conexoes { get; init; }
    [Required]
    public int TempoVoo { get; init; }
    [Required]
    public virtual Guid OrigemId { get; init; }
    [Required]
    public virtual required Estado Origem { get; init; }
    [Required]
    public virtual Guid DestinoId { get; init; }
    [Required]
    public virtual required Estado Destino { get; init; }
    [Required]
    public virtual Guid CompanhiaId { get; init; }
    [Required]
    public virtual required Companhia Companhia { get; init; }
}
