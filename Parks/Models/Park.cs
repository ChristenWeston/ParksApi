using System.ComponentModel.DataAnnotations;
namespace ParksApi.Models
{
  public class Park
  {

    public int ParkId { get; set; }
    [Required]
    public string Name { get; set; }

    [Required]
    public int SquareFootage { get; set; }
    [Required]
    public string City { get; set; }
    public string State { get; set; }
    [Required]
    public string Country { get; set; }
  }
}