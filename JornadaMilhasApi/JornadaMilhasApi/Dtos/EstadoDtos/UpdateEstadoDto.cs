namespace JornadaMilhasApi.Dtos.EstadoDtos;

public record UpdateEstadoDto
{
    public Guid Id { get; init; }
    public required string Nome { get; init; }
    public required string Sigla { get; init; }
}
