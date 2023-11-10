using JornadaMilhasApi.Dtos.DepoimentoDtos;

namespace JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

public interface IDepoimentoService
    : IBasicCrudService<CreateDepoimentoDto, ReadDepoimentoDto, UpdateDepoimentoDto>
{
}