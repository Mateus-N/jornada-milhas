namespace JornadaMilhasApi.Dtos.PromocaoDtos;

public record CreatePromocaoDto
{
    public required string Destino { get; set; }
    public required string Imagem { get; set; }
    public int Preco { get; set; }
}
