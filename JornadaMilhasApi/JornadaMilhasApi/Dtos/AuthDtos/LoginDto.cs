namespace JornadaMilhasApi.Dtos.AuthDtos;

public record LoginDto
{
    public required string Email { get; set; }
    public required string Senha { get; set; }
}
