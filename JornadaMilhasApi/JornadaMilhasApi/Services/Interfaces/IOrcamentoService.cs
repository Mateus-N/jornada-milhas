using JornadaMilhasApi.Dtos.PassagemDtos;

namespace JornadaMilhasApi.Services.Interfaces;

public interface IOrcamentoService
{
    void ModelOrcameto(QueryPassagemDto queryParams, IList<ReadPassagemWithOrcamentoDto> data);
    OrcamentoDto CalculaOrcamentoBebe(ReadPassagemWithOrcamentoDto passagem, QueryPassagemDto queryParams);
    OrcamentoDto CalculaOrcamentoCrianca(ReadPassagemWithOrcamentoDto passagem, QueryPassagemDto queryParams);
    OrcamentoDto CalculaOrcamentoAdulto(ReadPassagemWithOrcamentoDto passagem, QueryPassagemDto queryParams);
}