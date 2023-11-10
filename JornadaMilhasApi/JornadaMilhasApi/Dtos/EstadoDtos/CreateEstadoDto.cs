namespace JornadaMilhasApi.Dtos.EstadoDtos;

public record CreateEstadoDto
{
    public required string Nome { get; init; }
    public required string Sigla { get; init; }
}
