using System.ComponentModel.DataAnnotations;

namespace JornadaMilhasApi.Models;

public record Depoimento : IEntity
{
    [Required]
    public required string Texto { get; init; }
    [Required]
    public required string Autor { get; init; }
    [Required]
    public required string Avatar { get; init; }
}
