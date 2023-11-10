using JornadaMilhasApi.MarkupInterfaces;

namespace JornadaMilhasApi.Dtos.PromocaoDtos;

public record ReadPromocaoDto : IReadItem
{
    public required string Destino { get; set; }
    public required string Imagem { get; set; }
    public int Preco { get; set; }
}
