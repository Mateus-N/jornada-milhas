using JornadaMilhasApi.Dtos.PassagemDtos;

namespace JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

public interface IPassagemService
    : IBasicCrudService<CreatePassagemDto, ReadPassagemDto, UpdatePassagemDto>
{
}