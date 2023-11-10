namespace JornadaMilhasApi.Dtos.DepoimentoDtos;

public record UpdateDepoimentoDto
{
    public Guid Id { get; init; }
    public required string Texto { get; init; }
    public required string Autor { get; init; }
    public required string Avatar { get; init; }
}
