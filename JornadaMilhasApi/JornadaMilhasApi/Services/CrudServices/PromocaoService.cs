using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Dtos.PromocaoDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

namespace JornadaMilhasApi.Services.CrudServices;

public class PromocaoService :
    BasicCrudService<Promocao, CreatePromocaoDto, ReadPromocaoDto, UpdatePromocaoDto>,
    IInjectable,
    IPromocaoService
{
    public PromocaoService(AppDbContext context, IMapper mapper)
        : base(context.Promocoes, mapper, context)
    {
    }
}
