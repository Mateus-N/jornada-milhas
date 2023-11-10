using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace JornadaMilhasApi.Models;

public class Usuario
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public required string Nome { get; set; }
    [Required]
    public DateTime Nascimento { get; set; }
    [Required]
    public required string Cpf { get; set; }
    [Required]
    public required string Telefone { get; set; }
    [Required]
    public required string Email { get; set; }
    [Required]
    public required string Senha { get; set; }
    [Required]
    public required string Cidade { get; set; }
    [Required]
    public virtual required Guid EstadoId { get; set; }
    [Required]
    public virtual required Estado Estado { get; set; }
}
