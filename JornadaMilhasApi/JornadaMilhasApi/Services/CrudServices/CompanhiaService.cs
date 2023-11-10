using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Dtos.CompanhiaDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

namespace JornadaMilhasApi.Services.CrudServices;

public class CompanhiaService :
    BasicCrudService<Companhia, CreateCompanhiaDto, ReadCompanhiaDto, UpdateCompanhiaDto>,
    ICompanhiaService,
    IInjectable
{
    public CompanhiaService(AppDbContext context, IMapper mapper)
        : base(context.Companhias, mapper, context)
    {
    }
}
