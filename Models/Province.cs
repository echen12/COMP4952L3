using System.ComponentModel.DataAnnotations; // For Key attribute

public class Province
{
    [Key]
    public string? ProvinceCode { get; set; }
    public string? ProvinceName { get; set; }
    public List<City>? Cities { get; set; }

    
}