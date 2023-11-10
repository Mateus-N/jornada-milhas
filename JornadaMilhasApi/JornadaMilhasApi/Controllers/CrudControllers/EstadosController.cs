using JornadaMilhasApi.Controllers.CrudControllerBase;
using JornadaMilhasApi.Dtos.EstadoDtos;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class EstadosController
    : CrudBase<CreateEstadoDto, ReadEstadoDto, UpdateEstadoDto>
{
    public EstadosController(IEstadoService service) : base(service)
    {
    }
}
