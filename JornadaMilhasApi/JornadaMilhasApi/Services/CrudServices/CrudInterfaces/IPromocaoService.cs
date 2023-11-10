using JornadaMilhasApi.Dtos.PromocaoDtos;

namespace JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

public interface IPromocaoService
    : IBasicCrudService<CreatePromocaoDto, ReadPromocaoDto, UpdatePromocaoDto>
{
}