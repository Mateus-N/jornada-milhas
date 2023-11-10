using JornadaMilhasApi.Dtos.EstadoDtos;

namespace JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

public interface IEstadoService
    : IBasicCrudService<CreateEstadoDto, ReadEstadoDto, UpdateEstadoDto>
{
}