using AutoMapper;
using JornadaMilhasApi.Dtos.PassagemDtos;
using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Profiles;

public class PassagemProfile : Profile
{
    public PassagemProfile()
    {
        CreateMap<CreatePassagemDto, Passagem>();
        CreateMap<UpdatePassagemDto, Passagem>();
        CreateMap<Passagem, ReadPassagemDto>();
        CreateMap<Passagem, ReadPassagemWithOrcamentoDto>();
    }
}
