using AutoMapper;
using JornadaMilhasApi.Data;
using JornadaMilhasApi.Models;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;
using Microsoft.EntityFrameworkCore;

namespace JornadaMilhasApi.Services.CrudServices;

public abstract class BasicCrudService<M, C, R, U> : IBasicCrudService<C, R, U>
    where M : IEntity
{
    private readonly DbSet<M> items;
    private readonly IMapper mapper;
    private readonly AppDbContext context;

    protected BasicCrudService(DbSet<M> items, IMapper mapper, AppDbContext context)
    {
        this.items = items;
        this.mapper = mapper;
        this.context = context;
    }

    public async Task<R> CreateAsync(C createDto)
    {
        M item = mapper.Map<M>(createDto);
        await items.AddAsync(item);
        await context.SaveChangesAsync();
        return mapper.Map<R>(item);
    }

    public IEnumerable<R> FindAll()
    {
        return mapper.Map<List<R>>(items.ToList());
    }

    public async Task<R?> FindOne(Guid id)
    {
        M? item = await FindForId(id);
        return mapper.Map<R>(item);
    }

    public async Task<R?> UpdateAsync(U updateDto)
    {
        M item = mapper.Map<M>(updateDto);
        items.Update(item);
        await context.SaveChangesAsync();
        return mapper.Map<R>(item);
    }

    public async Task DeleteAsync(Guid id)
    {
        M? item = await FindForId(id);
        if (item != null)
        {
            context.Remove(item);
            await context.SaveChangesAsync(); ;
        }
    }

    private async Task<M?> FindForId(Guid id)
    {
        return await items.FirstOrDefaultAsync(c => c.Id == id);
    }
}
