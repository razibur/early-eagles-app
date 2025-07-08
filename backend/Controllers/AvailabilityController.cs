using EarlyEagles.Backend.Data;
using EarlyEagles.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EarlyEagles.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AvailabilityController : ControllerBase
{
	private readonly AppDbContext _context;

	public AvailabilityController(AppDbContext context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Availability>>> GetAllAvailability()
	{
		return await _context.Availabilities.Include(a => a.Member).ToListAsync();
	}

	[HttpPost]
	public async Task<ActionResult<Availability>> AddAvailability(Availability availability)
	{
		_context.Availabilities.Add(availability);
		await _context.SaveChangesAsync();
		return CreatedAtAction(nameof(GetAllAvailability), new { id = availability.Id }, availability);
	}
}
