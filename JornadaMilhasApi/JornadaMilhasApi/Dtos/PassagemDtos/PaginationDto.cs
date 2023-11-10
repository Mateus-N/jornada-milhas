namespace JornadaMilhasApi.Dtos.PassagemDtos;

public record PaginationDto
{
    public int PaginaAtual { get; set; }
    public int UltimaPagina { get; set; }
    public int Total { get; set; }
    public int PrecoMin { get; set; }
    public int PrecoMax { get; set; }
    public required ICollection<ReadPassagemWithOrcamentoDto> Resultado { get; set; }
}
