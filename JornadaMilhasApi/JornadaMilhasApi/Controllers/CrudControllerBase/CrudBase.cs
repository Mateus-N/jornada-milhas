using JornadaMilhasApi.MarkupInterfaces;
using JornadaMilhasApi.Services.CrudServices.CrudInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace JornadaMilhasApi.Controllers.CrudControllerBase;

public abstract class CrudBase<C, R, U> : ControllerBase
    where R : IReadItem
{
    private readonly IBasicCrudService<C, R, U> service;

    public CrudBase(IBasicCrudService<C, R, U> service)
    {
        this.service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] C dto)
    {
        try
        {
            R item = await service.CreateAsync(dto);
            return CreatedAtAction(nameof(FindOne), new { id = item.Id }, item);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpGet]
    public IActionResult FindAll()
    {
        try
        {
            IEnumerable<R> item = service.FindAll();
            return Ok(item);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> FindOne(Guid id)
    {
        try
        {
            R? item = await service.FindOne(id);
            if (item != null) return Ok(item);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
        return NotFound();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] U dto)
    {
        try
        {
            R? item = await service.UpdateAsync(dto);
            if (item != null) return Ok(item);
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await service.DeleteAsync(id);
            return NoContent();
        }
        catch (Exception)
        {
            return StatusCode(500);
        }
    }
}
