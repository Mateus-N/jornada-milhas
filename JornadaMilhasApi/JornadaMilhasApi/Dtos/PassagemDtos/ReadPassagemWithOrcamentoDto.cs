using JornadaMilhasApi.Dtos.CompanhiaDtos;
using JornadaMilhasApi.Dtos.EstadoDtos;

namespace JornadaMilhasApi.Dtos.PassagemDtos;

public class ReadPassagemWithOrcamentoDto
{
    public required string Tipo { get; set; }
    public int PrecoIda { get; set; }
    public int PrecoVolta { get; set; }
    public int TaxaEmbarque { get; set; }
    public int Conexoes { get; set; }
    public int TempoVoo { get; set; }
    public required ReadEstadoDto Origem { get; set; }
    public required ReadEstadoDto Destino { get; set; }
    public required ReadCompanhiaDto Companhia { get; set; }
    public DateTime? DataIda { get; set; }
    public DateTime? DataVolta { get; set; }
    public int Total { get; set; }
    public IList<OrcamentoDto>? Orcamento { get; set; }
}
