namespace JornadaMilhasApi.Services.CrudServices.CrudInterfaces;

public interface IBasicCrudService<C, R, U>
{
    Task<R> CreateAsync(C createDto);
    Task DeleteAsync(Guid id);
    IEnumerable<R> FindAll();
    Task<R?> FindOne(Guid id);
    Task<R?> UpdateAsync(U updateDto);
}
