using JornadaMilhasApi.MarkupInterfaces;

namespace JornadaMilhasApi.Dtos.EstadoDtos;

public record ReadEstadoDto : IReadItem
{
    public required string Nome { get; init; }
    public required string Sigla { get; init; }
}
