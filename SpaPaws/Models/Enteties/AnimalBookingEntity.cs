using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaPaws.Models.Enteties;

internal class AnimalBookingEntity
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string AnimalName { get; set; } = null!;


    public string AnimalAge { get; set; } = null!;


    [Column(TypeName = "nvarchar(20)")]
    public string AnimalBreed { get; set; } = null!;

    public DateTime Datetime { get; set; } = DateTime.Now;


    [Column(TypeName = "nvarchar(300)")]
    public string Booking { get; set; } = null!;

    //public CustomerEntity Customer { get; set; } = null!;

    public ICollection<CustomerEntity> Customers = new HashSet<CustomerEntity>();
}
