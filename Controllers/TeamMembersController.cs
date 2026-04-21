using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamDirectoryApi.Data;
using TeamDirectoryApi.Models;

namespace TeamDirectoryApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamMembersController : ControllerBase
{
    private readonly AppDbContext _context;

    public TeamMembersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{id?}")]
    public async Task<ActionResult> Get(int? id)
    {
        if (!id.HasValue || id.Value == 0)
        {
            var firstFive = await _context.TeamMembers
                .OrderBy(x => x.Id)
                .Take(5)
                .ToListAsync();

            return Ok(firstFive);
        }

        var item = await _context.TeamMembers.FindAsync(id.Value);

        if (item is null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<TeamMember>> Post(TeamMember item)
    {
        _context.TeamMembers.Add(item);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, TeamMember item)
    {
        if (id != item.Id)
        {
            return BadRequest("Route id and body id must match.");
        }

        if (!await _context.TeamMembers.AnyAsync(x => x.Id == id))
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
        var item = await _context.TeamMembers.FindAsync(id);

        if (item is null)
        {
            return NotFound();
        }

        _context.TeamMembers.Remove(item);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
