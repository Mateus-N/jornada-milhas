using JornadaMilhasApi.Dtos.PassagemDtos;

namespace JornadaMilhasApi.Services.Interfaces
{
    public interface IPaginationService
    {
        Task<PaginationDto> Search(QueryPassagemDto queryParams);
    }
}