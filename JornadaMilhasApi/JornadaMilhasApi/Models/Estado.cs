using System.ComponentModel.DataAnnotations;

namespace JornadaMilhasApi.Models;

public record Estado : IEntity
{
    [Required]
    public required string Nome { get; init; }
    [Required]
    public required string Sigla { get; init; }
    [Required]
    public virtual required ICollection<Passagem> PassagensOrigem { get; set; }
    [Required]
    public virtual required ICollection<Passagem> PassagensDestino { get; set; }
    [Required]
    public virtual required ICollection<Usuario> UserEstado { get; set; }
}
