using AutoMapper;
using JornadaMilhasApi.Dtos.AuthDtos;
using JornadaMilhasApi.Dtos.UserDto;
using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterDto, Usuario>();
        CreateMap<UpdateUserDto, Usuario>();
        CreateMap<Usuario, ReadUserDto>();
    }
}
