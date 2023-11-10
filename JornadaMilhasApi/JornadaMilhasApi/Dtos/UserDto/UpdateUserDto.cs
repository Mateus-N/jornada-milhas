namespace JornadaMilhasApi.Dtos.UserDto;

public record UpdateUserDto
{
    public required string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public required string Cpf { get; set; }
    public required string Telefone { get; set; }
    public required string Email { get; set; }
    public required string Senha { get; set; }
    public required string Cidade { get; set; }
    public required Guid EstadoId { get; set; }
}
