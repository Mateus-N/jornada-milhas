using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Dtos.PassagemDtos;

public record CreatePassagemDto
{
    public required string Tipo { get; init; }
    public int PrecoIda { get; init; }
    public int PrecoVolta { get; init; }
    public int TaxaEmbarque { get; init; }
    public int Conexoes { get; init; }
    public int TempoVoo { get; init; }
    public Guid OrigemId { get; init; }
    public Guid DestinoId { get; init; }
    public Guid CompanhiaId { get; init; }
}
