using JornadaMilhasApi.Dtos.PassagemDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Services.Interfaces;

namespace JornadaMilhasApi.Services;

public class OrcamentoService : IInjectable, IOrcamentoService
{
    public void ModelOrcameto(QueryPassagemDto queryParams, IList<ReadPassagemWithOrcamentoDto> data)
    {
        foreach (var passagem in data)
        {
            int totalPassagens = 0;
            List<OrcamentoDto> orcamento = new();

            if (queryParams.PassageirosAdultos > 0)
            {
                OrcamentoDto detalhes = CalculaOrcamentoAdulto(passagem, queryParams);
                totalPassagens += detalhes.Total;
                orcamento.Add(detalhes);
            }

            if (queryParams.PassageirosCriancas > 0)
            {
                OrcamentoDto detalhes = CalculaOrcamentoCrianca(passagem, queryParams);
                totalPassagens += detalhes.Total;
                orcamento.Add(detalhes);
            }

            if (queryParams.PassageirosBebes > 0)
            {
                OrcamentoDto detalhes = CalculaOrcamentoBebe(passagem, queryParams);
                totalPassagens += detalhes.Total;
                orcamento.Add(detalhes);
            }

            passagem.Total = totalPassagens;
            passagem.DataIda = queryParams.DataIda != null ? DateTime.Parse(queryParams.DataIda) : DateTime.Today;
            passagem.DataVolta = queryParams.DataVolta != null ? DateTime.Parse(queryParams.DataVolta) : null;
            passagem.Orcamento = orcamento;
        }
    }

    public OrcamentoDto CalculaOrcamentoBebe(ReadPassagemWithOrcamentoDto passagem, QueryPassagemDto queryParams)
    {
        int ida = passagem.PrecoIda * queryParams.PassageirosBebes;
        int volta = queryParams.SomenteIda ? 0 : passagem.PrecoVolta * queryParams.PassageirosBebes;
        int preco = ida + volta;

        OrcamentoDto detalhes = new()
        {
            Descricao = $"{queryParams.PassageirosBebes} " +
                $"bebê{(queryParams.PassageirosBebes > 1 ? "s" : "")}," +
                $" {passagem.Tipo.ToLower()}",
            Preco = preco,
            TaxaEmbarque = passagem.TaxaEmbarque,
            Total = preco + passagem.TaxaEmbarque
        };

        return detalhes;
    }

    public OrcamentoDto CalculaOrcamentoCrianca(ReadPassagemWithOrcamentoDto passagem, QueryPassagemDto queryParams)
    {
        int ida = passagem.PrecoIda * queryParams.PassageirosCriancas;
        int volta = queryParams.SomenteIda ? 0 : passagem.PrecoVolta * queryParams.PassageirosCriancas;
        int preco = ida + volta;

        OrcamentoDto detalhes = new()
        {
            Descricao = $"{queryParams.PassageirosCriancas} " +
                $"criança{(queryParams.PassageirosCriancas > 1 ? "s" : "")}," +
                $" {passagem.Tipo.ToLower()}",
            Preco = preco,
            TaxaEmbarque = passagem.TaxaEmbarque,
            Total = preco + passagem.TaxaEmbarque
        };

        return detalhes;
    }

    public OrcamentoDto CalculaOrcamentoAdulto(ReadPassagemWithOrcamentoDto passagem, QueryPassagemDto queryParams)
    {
        int ida = passagem.PrecoIda * queryParams.PassageirosAdultos;
        int volta = queryParams.SomenteIda ? 0 : passagem.PrecoVolta * queryParams.PassageirosAdultos;
        int preco = ida + volta;

        OrcamentoDto detalhes = new()
        {
            Descricao = $"{queryParams.PassageirosAdultos} " +
                $"adulto{(queryParams.PassageirosAdultos > 1 ? "s" : "")}," +
                $" {passagem.Tipo.ToLower()}",
            Preco = preco,
            TaxaEmbarque = passagem.TaxaEmbarque,
            Total = preco + passagem.TaxaEmbarque
        };

        return detalhes;
    }
}
