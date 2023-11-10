namespace JornadaMilhasApi.Dtos.CompanhiaDtos;

public record UpdateCompanhiaDto
{
    public Guid Id { get; init; }
    public required string Nome { get; init; }
}
