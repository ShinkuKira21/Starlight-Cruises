using System;
using Server.ENums.Categories;

namespace Server.Models;

public class Services
{
    public Guid id { get; init; }
    public string name { get; init; } = "";
    public string description { get; init; } = "";
    public Categories type { get; init; }
	public string imgDirectory { get; init; } = "";
    public decimal minPrice { get; init; }
    public decimal midPrice { get; init; }
    public decimal maxPrice { get; init; }
    public string link { get; init; } = "";
    public DateTimeOffset createdAt { get; init; }
}