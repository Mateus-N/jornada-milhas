using JornadaMilhasApi.Dtos.AuthDtos;
using JornadaMilhasApi.Dtos.UserDto;

namespace JornadaMilhasApi.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ReadUserDto> CadastroAsync(RegisterDto createDto);
        Task<ReadUserDto?> FindOne(Guid userId);
        Task<TokenDto> SingIn(string email, string senha);
        Task<ReadUserDto?> UpdateAsync(UpdateUserDto updateDto, Guid userId);
    }
}