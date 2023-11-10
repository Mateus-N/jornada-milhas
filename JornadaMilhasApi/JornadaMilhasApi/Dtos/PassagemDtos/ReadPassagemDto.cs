using JornadaMilhasApi.Dtos.CompanhiaDtos;
using JornadaMilhasApi.Dtos.EstadoDtos;
using JornadaMilhasApi.MarkupInterfaces;

namespace JornadaMilhasApi.Dtos.PassagemDtos;

public record ReadPassagemDto : IReadItem
{
    public required string Tipo { get; init; }
    public int PrecoIda { get; init; }
    public int PrecoVolta { get; init; }
    public int TaxaEmbarque { get; init; }
    public int Conexoes { get; init; }
    public int TempoVoo { get; init; }
    public required ReadEstadoDto Origem { get; init; }
    public required ReadEstadoDto Destino { get; init; }
    public required ReadCompanhiaDto Companhia { get; init; }
}