using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Dtos.EstadoDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

namespace JornadaMilhasApi.Services.CrudServices;

public class EstadoService :
    BasicCrudService<Estado, CreateEstadoDto, ReadEstadoDto, UpdateEstadoDto>,
    IInjectable,
    IEstadoService
{
    public EstadoService(AppDbContext context, IMapper mapper)
        : base(context.Estados, mapper, context)
    {
    }
}
