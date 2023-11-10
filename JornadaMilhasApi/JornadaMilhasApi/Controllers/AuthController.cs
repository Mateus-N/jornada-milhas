using JornadaMilhasApi.Dtos.AuthDtos;
using JornadaMilhasApi.Dtos.EstadoDtos;
using JornadaMilhasApi.Dtos.UserDto;
using JornadaMilhasApi.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService service;

    public AuthController(IAuthService service)
    {
        this.service = service;
    }

    [HttpPost("cadastro")]
    public async Task<IActionResult> Cadastro([FromBody] RegisterDto dto)
    {
        try
        {
            ReadUserDto user = await service.CadastroAsync(dto);
            return Ok(user);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        try
        {
            TokenDto token = await service.SingIn(dto.Email, dto.Senha);
            return Ok(token);
        }
        catch (UnauthorizedAccessException)
        {
            return Unauthorized();
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [Authorize]
    [HttpGet("perfil")]
    public async Task<IActionResult> Perfil()
    {
        try
        {
            Guid userId = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == "id")?.Value!);
            ReadUserDto? user = await service.FindOne(userId);
            if (user != null) return Ok(user);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
        return NotFound();
    }

    [Authorize]
    [HttpPut("perfil")]
    public async Task<IActionResult> Update([FromBody] UpdateUserDto dto)
    {
        try
        {
            Guid userId = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == "id")?.Value!);
            ReadUserDto? user = await service.UpdateAsync(dto, userId);
            if (user != null) return Ok(user);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
        return NotFound();
    }
}
