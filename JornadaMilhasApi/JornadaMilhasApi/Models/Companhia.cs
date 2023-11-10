using System.ComponentModel.DataAnnotations;

namespace JornadaMilhasApi.Models;

public record Companhia : IEntity
{
    [Required]
    public required string Nome { get; init; }
    [Required]
    public virtual required ICollection<Passagem> Passagens { get; set; }
}
