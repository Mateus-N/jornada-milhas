using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Dtos.PassagemDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

namespace JornadaMilhasApi.Services.CrudServices;

public class PassagemService :
    BasicCrudService<Passagem, CreatePassagemDto, ReadPassagemDto, UpdatePassagemDto>,
    IInjectable,
    IPassagemService
{
    public PassagemService(AppDbContext context, IMapper mapper)
        : base(context.Passagens, mapper, context)
    {
    }
}
