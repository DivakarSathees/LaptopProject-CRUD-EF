using System.ComponentModel.DataAnnotations;

namespace LaptopProject.Models
{
public class Laptop
{
    public int Id { get; set; }

    [Required]
    public string Brand { get; set; }

    [Required]
    public string Model { get; set; }

    [Required]
    public string Processor { get; set; }

    [Required]
    public string Price { get; set; }

}
}
