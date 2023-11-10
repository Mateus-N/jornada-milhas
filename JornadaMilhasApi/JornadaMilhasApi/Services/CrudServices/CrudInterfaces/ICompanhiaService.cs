using JornadaMilhasApi.Dtos.CompanhiaDtos;

namespace JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

public interface ICompanhiaService
    : IBasicCrudService<CreateCompanhiaDto, ReadCompanhiaDto, UpdateCompanhiaDto>
{
}