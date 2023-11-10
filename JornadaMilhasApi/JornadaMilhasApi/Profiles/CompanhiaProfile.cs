using AutoMapper;
using JornadaMilhasApi.Dtos.CompanhiaDtos;
using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Profiles;

public class CompanhiaProfile : Profile
{
    public CompanhiaProfile()
    {
        CreateMap<CreateCompanhiaDto, Companhia>();
        CreateMap<UpdateCompanhiaDto, Companhia>();
        CreateMap<Companhia, ReadCompanhiaDto>();
    }
}
