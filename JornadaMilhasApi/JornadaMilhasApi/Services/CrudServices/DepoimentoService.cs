using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Dtos.DepoimentoDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

namespace JornadaMilhasApi.Services.CrudServices;

public class DepoimentoService :
    BasicCrudService<Depoimento, CreateDepoimentoDto, ReadDepoimentoDto, UpdateDepoimentoDto>,
    IInjectable, 
    IDepoimentoService
{
    public DepoimentoService(AppDbContext context, IMapper mapper)
        : base(context.Depoimentos, mapper, context)
    {
    }
}
