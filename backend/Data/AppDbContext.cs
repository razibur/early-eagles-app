using Microsoft.EntityFrameworkCore;
using EarlyEagles.Backend.Models;

namespace EarlyEagles.Backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Member> Members => Set<Member>();
    public DbSet<Availability> Availabilities => Set<Availability>();
}
