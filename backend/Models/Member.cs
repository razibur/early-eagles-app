using System.Collections.Generic;

namespace EarlyEagles.Backend.Models;

public class Member
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ICollection<Availability>? Availabilities { get; set; }
}
