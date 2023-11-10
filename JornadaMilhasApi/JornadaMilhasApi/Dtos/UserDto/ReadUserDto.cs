using JornadaMilhasApi.Dtos.EstadoDtos;

namespace JornadaMilhasApi.Dtos.UserDto;

public record ReadUserDto
{
    public required string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public required string Cpf { get; set; }
    public required string Telefone { get; set; }
    public required string Email { get; set; }
    public required string Cidade { get; set; }
    public required ReadEstadoDto Estado { get; set; }
}
