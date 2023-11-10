using JornadaMilhasApi.Controllers.CrudControllerBase;
using JornadaMilhasApi.Dtos.PassagemDtos;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class PassagemController
    : CrudBase<CreatePassagemDto, ReadPassagemDto, UpdatePassagemDto>
{
    public PassagemController(IPassagemService service) : base(service)
    {
    }
}
