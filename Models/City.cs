using System.ComponentModel.DataAnnotations; // For Key attribute
using System.ComponentModel.DataAnnotations.Schema;


public class City
{
    [Key]
    public int? CityId { get; set; }
    public string? CityName { get; set; }
    public int? Population { get; set; }



    

    /*[ForeignKey("ProvinceCode")]*/
    public string? ProvinceCode { get; set; } // Foreign key to Province

    [ForeignKey("ProvinceCode")]
    public Province? Province { get; set; }


}