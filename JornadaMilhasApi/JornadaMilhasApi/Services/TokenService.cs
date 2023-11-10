using JornadaMilhasApi.Dtos.AuthDtos;
using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JornadaMilhasApi.Services;

public class TokenService : IInjectable, ITokenService
{
    public TokenDto CreateToken(Usuario user)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("id", user.Id.ToString()),
        };

        var chave = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("fedaf7d8863b48e197b9287d492b708e"));

        var signingCredentials =
            new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
                expires: DateTime.Now.AddDays(9999),
                claims: claims,
                signingCredentials: signingCredentials
            );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return new TokenDto(tokenString);
    }
}
