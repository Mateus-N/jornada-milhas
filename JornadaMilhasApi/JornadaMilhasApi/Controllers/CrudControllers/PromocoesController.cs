using JornadaMilhasApi.Controllers.CrudControllerBase;
using JornadaMilhasApi.Dtos.PromocaoDtos;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers.CrudControllers;

[ApiController]
[Route("[controller]")]
public class PromocoesController
    : CrudBase<CreatePromocaoDto, ReadPromocaoDto, UpdatePromocaoDto>
{
    public PromocoesController(IPromocaoService service) : base(service)
    {
    }
}
