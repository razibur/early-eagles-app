using System;

namespace EarlyEagles.Backend.Models;

public class Availability
{
	public int Id { get; set; }
	public DateTime Date { get; set; }
	public bool IsAvailable { get; set; }

	public int MemberId { get; set; }
	public Member? Member { get; set; }
}
