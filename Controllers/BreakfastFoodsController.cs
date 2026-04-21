using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamDirectoryApi.Data;
using TeamDirectoryApi.Models;

namespace TeamDirectoryApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BreakfastFoodsController : ControllerBase
{
    private readonly AppDbContext _context;

    public BreakfastFoodsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{id?}")]
    public async Task<ActionResult> Get(int? id)
    {
        if (!id.HasValue || id.Value == 0)
        {
            var firstFive = await _context.BreakfastFoods
                .OrderBy(x => x.Id)
                .Take(5)
                .ToListAsync();

            return Ok(firstFive);
        }

        var item = await _context.BreakfastFoods.FindAsync(id.Value);

        if (item is null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<BreakfastFood>> Post(BreakfastFood item)
    {
        _context.BreakfastFoods.Add(item);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, BreakfastFood item)
    {
        if (id != item.Id)
        {
            return BadRequest("Route id and body id must match.");
        }

        if (!await _context.BreakfastFoods.AnyAsync(x => x.Id == id))
        {
            return NotFound();
        }

        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _context.BreakfastFoods.FindAsync(id);

        if (item is null)
        {
            return NotFound();
        }

        _context.BreakfastFoods.Remove(item);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
