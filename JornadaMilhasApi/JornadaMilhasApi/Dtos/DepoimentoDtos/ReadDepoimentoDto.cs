using JornadaMilhasApi.MarkupInterfaces;

namespace JornadaMilhasApi.Dtos.DepoimentoDtos;

public record ReadDepoimentoDto : IReadItem
{
    public required string Texto { get; init; }
    public required string Autor { get; init; }
    public required string Avatar { get; init; }
}
