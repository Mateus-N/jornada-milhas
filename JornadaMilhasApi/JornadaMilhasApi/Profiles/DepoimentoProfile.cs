using AutoMapper;
using JornadaMilhasApi.Dtos.DepoimentoDtos;
using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Profiles;

public class DepoimentoProfile : Profile
{
    public DepoimentoProfile()
    {
        CreateMap<CreateDepoimentoDto, Depoimento>();
        CreateMap<UpdateDepoimentoDto, Depoimento>();
        CreateMap<Depoimento, ReadDepoimentoDto>();
    }
}
