using JornadaMilhasApi.Controllers.CrudControllerBase;
using JornadaMilhasApi.Dtos.CompanhiaDtos;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class CompanhiasController
    : CrudBase<CreateCompanhiaDto, ReadCompanhiaDto, UpdateCompanhiaDto>
{
    public CompanhiasController(ICompanhiaService service) : base(service)
    {
    }
}
