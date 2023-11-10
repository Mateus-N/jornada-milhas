namespace JornadaMilhasApi.Dtos.PassagemDtos;

public record QueryPassagemDto
{
    public bool SomenteIda { get; set; }
    public int PassageirosAdultos { get; set; }
    public int PassageirosCriancas { get; set; }
    public int PassageirosBebes { get; set; }
    public string Tipo { get; set; }
    public string Turno { get; set; }
    public Guid OrigemId { get; set; }
    public string CompanhiasId { get; set; }
    public Guid DestinoId { get; set; }
    public int? PrecoMin { get; set; }
    public int? PrecoMax { get; set; }
    public int? Conexoes { get; set; }
    public int? TempoVoo { get; set; }
    public string? DataIda { get; set; }
    public string? DataVolta { get; set; }
    public int Pagina { get; set; }
    public int PorPagina { get; set; }

    public QueryPassagemDto()
    {
        SomenteIda = false;
        PassageirosAdultos = 1;
        PassageirosCriancas = 0;
        PassageirosBebes = 0;
        Tipo = string.Empty;
        Turno = string.Empty;
        OrigemId = Guid.Empty;
        CompanhiasId = string.Empty;
        DestinoId = Guid.Empty;
        PrecoMin = null;
        PrecoMax = null;
        Conexoes = null;
        TempoVoo = null;
        DataIda = null;
        DataVolta = null;
        Pagina = 1;
        PorPagina = 5;
    }
}
