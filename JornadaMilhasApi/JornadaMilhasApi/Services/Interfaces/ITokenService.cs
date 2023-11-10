using JornadaMilhasApi.Dtos.AuthDtos;
using JornadaMilhasApi.Models;

namespace JornadaMilhasApi.Services.Interfaces
{
    public interface ITokenService
    {
        TokenDto CreateToken(Usuario user);
    }
}