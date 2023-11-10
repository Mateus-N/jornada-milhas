using AutoMapper;
using JornadaMilhasApi.Dtos.EstadoDtos;
using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Profiles;

public class EstadoProfile : Profile
{
    public EstadoProfile()
    {
        CreateMap<CreateEstadoDto, Estado>();
        CreateMap<UpdateEstadoDto, Estado>();
        CreateMap<Estado, ReadEstadoDto>();
    }
}
