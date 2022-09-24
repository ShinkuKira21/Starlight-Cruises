using Server.ENums.Categories;

namespace Server.DTO;

public class UpdateServiceDTO
{
    public string name { get; init; } = "";
    public string description { get; init; } = "";
    public Categories type { get; init; }
    public string imgDirectory { get; init; } = "";
    public decimal minPrice { get; init; }
    public decimal midPrice { get; init; } 
    public decimal maxPrice { get; init; }
    public decimal link { get; init; }
}