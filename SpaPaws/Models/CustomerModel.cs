
namespace SpaPaws.Models;

internal class CustomerModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Email { get; set; } = null!;

    public string DisplayName => $"{FirstName} {LastName}";


    public string StreetName { get; set; } = null!;
    public string City { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
   

    public string DisplayAddress => $"{StreetName} {City} {PostalCode} ";

    public int AnimalId { get; set; }
    public string AnimalName { get; set;} = null!;
    public string AnimalAge { get; set; } = null!;
    public string AnimalBreed { get; set; } = null!;

    public DateTime Datetime { get; set; } = DateTime.Now;
    public string Booking { get; set; } = null!;
}
