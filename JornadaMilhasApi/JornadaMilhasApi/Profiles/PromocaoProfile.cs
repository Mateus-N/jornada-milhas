using AutoMapper;
using JornadaMilhasApi.Dtos.PromocaoDtos;
using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Profiles;

public class PromocaoProfile : Profile
{
    public PromocaoProfile()
    {
        CreateMap<CreatePromocaoDto, Promocao>();
        CreateMap<UpdatePromocaoDto, Promocao>();
        CreateMap<Promocao, ReadPromocaoDto>();
    }
}
