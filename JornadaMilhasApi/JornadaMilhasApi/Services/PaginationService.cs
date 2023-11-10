using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Dtos.PassagemDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JornadaMilhasApi.Services;

public class PaginationService : IInjectable, IPaginationService
{
    private readonly AppDbContext context;
    private readonly IMapper mapper;
    private readonly IOrcamentoService orcamentoService;

    public PaginationService(AppDbContext context, IMapper mapper, IOrcamentoService orcamentoService)
    {
        this.context = context;
        this.mapper = mapper;
        this.orcamentoService = orcamentoService;
    }

    public async Task<PaginationDto> Search(QueryPassagemDto queryParams)
    {
        IQueryable<Passagem> query = context.Passagens.AsQueryable();

        if (!string.IsNullOrEmpty(queryParams.Tipo))
            query = query.Where(p => p.Tipo == queryParams.Tipo);

        if (queryParams.OrigemId != Guid.Empty)
            query = query.Where(p => p.OrigemId == queryParams.OrigemId);

        if (queryParams.DestinoId != Guid.Empty)
            query = query.Where(p => p.DestinoId == queryParams.DestinoId);

        if (!string.IsNullOrEmpty(queryParams.CompanhiasId))
        {
            string[] ids = queryParams.CompanhiasId.Split(",");
            List<Guid> idsGuid = new();
            foreach (var item in ids)
            {
                idsGuid.Add(Guid.Parse(item));
            }
            query = query.Where(p => idsGuid.Contains(p.CompanhiaId));
        }

        if (queryParams.PrecoMin != null && queryParams.PrecoMin > 0)
            query = query.Where(p => p.PrecoIda >= queryParams.PrecoMin);

        if (queryParams.PrecoMax != null && queryParams.PrecoMax > 0)
            query = query.Where(p => p.PrecoIda <= queryParams.PrecoMax);

        if (queryParams.Conexoes != null)
        {
            if (queryParams.Conexoes <= 2)
                query = query.Where(p => p.Conexoes <= queryParams.Conexoes);
        }

        var response = await ModelPagination(query, queryParams);

        return response;
    }

    private async Task<PaginationDto> ModelPagination(IQueryable<Passagem> query, QueryPassagemDto queryParams)
    {
        int total = await query.CountAsync();
        int ultimaPagina = (int)Math.Ceiling((double)total / queryParams.PorPagina);
        int pagina = queryParams.Pagina <= ultimaPagina ? queryParams.Pagina : 1;
        int porPagina = queryParams.PorPagina;
        int precoMin = FindMinPrecoIda();
        int precoMax = FindMaxPrecoIda();

        IEnumerable<Passagem> dataPassagens = query
            .OrderBy(p => p.PrecoIda)
            .Skip((pagina - 1) * porPagina)
            .Take(porPagina)
            .ToList();

        IList<ReadPassagemWithOrcamentoDto> data = mapper.Map<IList<ReadPassagemWithOrcamentoDto>>(dataPassagens);

        orcamentoService.ModelOrcameto(queryParams, data);

        PaginationDto response = new()
        {
            PaginaAtual = pagina,
            UltimaPagina = ultimaPagina,
            Total = total,
            PrecoMin = precoMin,
            PrecoMax = precoMax,
            Resultado = data
        };

        return response;
    }

    private int FindMinPrecoIda()
    {
        return context.Passagens
            .Where(p => p.PrecoIda > 0)
            .Min(p => p.PrecoIda);
    }

    private int FindMaxPrecoIda()
    {
        return context.Passagens
            .Where(p => p.PrecoIda > 0)
            .Max(p => p.PrecoIda);
    }
}
