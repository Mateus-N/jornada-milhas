using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Dtos.AuthDtos;
using JornadaMilhasApi.Dtos.UserDto;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JornadaMilhasApi.Services;

public class AuthService : IInjectable, IAuthService
{
    private readonly ITokenService tokenService;
    private readonly AppDbContext context;
    private readonly IMapper mapper;

    public AuthService(ITokenService tokenService, AppDbContext context, IMapper mapper)
    {
        this.tokenService = tokenService;
        this.context = context;
        this.mapper = mapper;
    }

    public async Task<TokenDto> SingIn(string email, string senha)
    {
        Usuario? user = await FindForEmail(email);

        if (user == null || user?.Senha != senha)
            throw new UnauthorizedAccessException();

        return tokenService.CreateToken(user);
    }


    public async Task<ReadUserDto> CadastroAsync(RegisterDto createDto)
    {
        Usuario user = mapper.Map<Usuario>(createDto);
        await context.Users.AddAsync(user);
        await context.SaveChangesAsync();
        return mapper.Map<ReadUserDto>(user);
    }

    public async Task<ReadUserDto?> FindOne(Guid userId)
    {
        Usuario? user = await FindForId(userId);
        return mapper.Map<ReadUserDto>(user) ?? null;
    }

    public async Task<ReadUserDto?> UpdateAsync(UpdateUserDto updateDto, Guid userId)
    {
        Usuario? user = await FindForId(userId);
        if (user == null) return null;
        AttUser(updateDto, user);
        context.Users.Update(user);
        await context.SaveChangesAsync();
        return mapper.Map<ReadUserDto>(user);
    }

    private static void AttUser(UpdateUserDto updateDto, Usuario user)
    {
        user.Nome = updateDto.Nome;
        user.Nascimento = updateDto.Nascimento;
        user.Cpf = updateDto.Cpf;
        user.Telefone = updateDto.Telefone;
        user.Email = updateDto.Email;
        user.Senha = updateDto.Senha;
        user.Cidade = updateDto.Cidade;
        user.EstadoId = updateDto.EstadoId;
    }

    private async Task<Usuario?> FindForId(Guid userId)
    {
        return await context.Users.FirstOrDefaultAsync(u => u.Id == userId);
    }

    private async Task<Usuario?> FindForEmail(string email)
    {
        return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
}
