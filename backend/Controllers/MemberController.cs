using EarlyEagles.Backend.Data;
using EarlyEagles.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EarlyEagles.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MemberController : ControllerBase
{
    private readonly AppDbContext _context;

    public MemberController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Member>>> GetAllMembers()
    {
        return await _context.Members.Include(m => m.Availabilities).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Member>> AddMember(Member member)
    {
        _context.Members.Add(member);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAllMembers), new { id = member.Id }, member);
    }
}
