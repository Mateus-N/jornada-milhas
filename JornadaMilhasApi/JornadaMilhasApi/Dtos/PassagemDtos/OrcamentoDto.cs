namespace JornadaMilhasApi.Dtos.PassagemDtos;

public class OrcamentoDto
{
    public required string Descricao { get; set; }
    public int Preco { get; set; }
    public int TaxaEmbarque { get; set; }
    public int Total { get; set; }
}
