using Server.ENums.Categories;
using System.ComponentModel.DataAnnotations;

namespace Server.DTO;

public class AppendServiceDTO
{
    [Required]
    public string name { get; set; } = "";
    
    [Required]
    [MaxLength(450)]
    public string description { get; init; } = "";
    
    [Required]
    [Range((int)Categories.EDatabase, (int)Categories.ECloudDevelopment, ErrorMessage = "Error: Type is invalid. Selection between {1} - {2}.")]
    public Categories type { get; init; }
    
    [Required]
    public string imgDirectory { get; init; } = "";

    [Required]
    [Range(0.00, 15000, ErrorMessage = "Price cannot be lower than {1} and more than {2}!")]
    public decimal minPrice { get; init; }
    
    [Required]
    [Range(0.00, 15000, ErrorMessage = "Price cannot be lower than {1} and more than {2}!")]
    public decimal midPrice { get; init; }
    
    [Required]
    [Range(0.00, 15000, ErrorMessage = "Price cannot be lower than {1} and more than {2}!")]
    public decimal maxPrice { get; init; }
    
    [Required]
    public string link { get; init; }
    
    public DateTimeOffset createdAt { get; init; }
}