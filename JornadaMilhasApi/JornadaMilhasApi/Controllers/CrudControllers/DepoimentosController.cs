using JornadaMilhasApi.Controllers.CrudControllerBase;
using JornadaMilhasApi.Dtos.DepoimentoDtos;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class DepoimentosController
    : CrudBase<CreateDepoimentoDto, ReadDepoimentoDto, UpdateDepoimentoDto>
{

    public DepoimentosController(IDepoimentoService service) : base(service)
    {
    }
}
