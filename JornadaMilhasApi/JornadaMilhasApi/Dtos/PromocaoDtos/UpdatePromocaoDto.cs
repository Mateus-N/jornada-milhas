namespace JornadaMilhasApi.Dtos.PromocaoDtos;

public record UpdatePromocaoDto
{
    public Guid Id { get; set; }
    public required string Destino { get; set; }
    public required string Imagem { get; set; }
    public int Preco { get; set; }
}
