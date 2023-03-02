using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaPaws.Models.Enteties;

    [Index(nameof(Email), IsUnique = true)]

    internal class CustomerEntity
    {
 
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = null!;


        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = null!;


        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; } = null!;


        [Column(TypeName = "char(13)")]
        public string PhoneNumber { get; set; } = null!;



        [Column(TypeName = "nvarchar(50)")]
        public string StreetName { get; set; } = null!;


        [Column(TypeName = "char(6)")]
        public string PostalCode { get; set; } = null!;


        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; } = null!;


        public int AnimalId { get; set; }
        public AnimalBookingEntity Animal { get; set; } = null!;
    }
