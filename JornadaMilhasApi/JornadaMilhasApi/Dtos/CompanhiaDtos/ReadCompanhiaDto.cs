using JornadaMilhasApi.MarkupInterfaces;

namespace JornadaMilhasApi.Dtos.CompanhiaDtos;

public record ReadCompanhiaDto : IReadItem
{
    public required string Nome { get; init; }
}
