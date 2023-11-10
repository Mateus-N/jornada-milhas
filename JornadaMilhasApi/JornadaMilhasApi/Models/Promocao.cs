using System.ComponentModel.DataAnnotations;

namespace JornadaMilhasApi.Models;

public record Promocao : IEntity
{
    [Required]
    public required string Destino { get; set; }
    [Required]
    public required string Imagem { get; set; }
    [Required]
    public int Preco { get; set; }
}
