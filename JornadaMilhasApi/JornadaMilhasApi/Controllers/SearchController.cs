using JornadaMilhasApi.Dtos.PassagemDtos;
using JornadaMilhasApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers;

[Route("[controller]")]
[ApiController]
public class SearchController : ControllerBase
{
    private readonly IPaginationService service;

    public SearchController(IPaginationService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<IActionResult> FindAllPaged([FromQuery] QueryPassagemDto queryParams)
    {
        try
        {
            PaginationDto passagem = await service.Search(queryParams);
            return Ok(passagem);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
}
