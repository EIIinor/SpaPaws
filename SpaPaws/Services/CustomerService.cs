using Microsoft.EntityFrameworkCore;
using SpaPaws.Contexts;
using SpaPaws.Models;
using SpaPaws.Models.Enteties;

namespace SpaPaws.Services
{
    internal class CustomerService
    {
        private static DataContext _context = new DataContext();

        public static async Task SaveAsync(Customer customer)
        {
            var customerEntity = new CustomerEntity
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                StreetName = customer.StreetName,
                City = customer.City,
                PostalCode = customer.PostalCode,
            };
            var animalBookingEntity = _context.AnimalBookings.FirstOrDefaultAsync(x => 
            x.AnimalName == customer.AnimalName && 
            x.AnimalAge == customer.AnimalAge && 
            x.AnimalBreed == customer.AnimalBreed &&
            x.Datetime == customer.Datetime &&
            x.Booking == customer.Booking
            );
            if (animalBookingEntity != null)
                customerEntity.AnimalId = animalBookingEntity.Id;
            else
                customerEntity.Animal = new AnimalBookingEntity
                {
                    AnimalName = customer.AnimalName,
                    AnimalAge = customer.AnimalAge,
                    AnimalBreed = customer.AnimalBreed,
                    Datetime = customer.Datetime,
                    Booking = customer.Booking
                };

            _context.Add( customerEntity );
            await _context.SaveChangesAsync();
        }

        public static async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var customers = new List<Customer>();

            foreach (var customer in await _context.Customers.Include(x => x.Animal).ToListAsync())
                customers.Add(new Customer
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    StreetName = customer.StreetName,
                    City = customer.City,
                    PostalCode = customer.PostalCode,
                    AnimalId = customer.AnimalId,
                    AnimalName = customer.Animal.AnimalName,
                    AnimalAge = customer.Animal.AnimalAge,
                    AnimalBreed = customer.Animal.AnimalBreed,
                    Datetime = customer.Animal.Datetime,
                    Booking = customer.Animal.Booking
                });
            return customers;
        }


        public static async Task<Customer> GetAsync(string email)
        {
            var customer = await _context.Customers.Include(x => x.Animal).FirstOrDefaultAsync(x => x.Email == email);
            if (customer != null)
                return new Customer
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    StreetName = customer.StreetName,
                    City = customer.City,
                    PostalCode = customer.PostalCode,
                    AnimalId = customer.AnimalId,
                    AnimalName = customer.Animal.AnimalName,
                    AnimalAge = customer.Animal.AnimalAge,
                    AnimalBreed = customer.Animal.AnimalBreed,
                    Datetime = customer.Animal.Datetime,
                    Booking = customer.Animal.Booking
                };
            else
                return null!;
        }


        public static async Task UpdateAsync(Customer customer)
        {

            var customerEntity = await _context.Customers.Include(x => x.Animal).FirstOrDefaultAsync(x => x.Id == customer.Id);
            if (customerEntity != null)
            {
                if (!string.IsNullOrEmpty(customer.FirstName))
                {
                    customerEntity.FirstName = customer.FirstName;
                }
                if (!string.IsNullOrEmpty(customer.LastName))
                {
                    customerEntity.LastName = customer.LastName;
                }
                if (!string.IsNullOrEmpty(customer.Email))
                {
                    customerEntity.Email = customer.Email;
                }
                if (!string.IsNullOrEmpty(customer.PhoneNumber))
                {
                    customerEntity.PhoneNumber = customer.PhoneNumber;
                }
                if (!string.IsNullOrEmpty(customer.StreetName))
                {
                    customerEntity.StreetName = customer.StreetName;
                }
                if (!string.IsNullOrEmpty(customer.City))
                {
                    customerEntity.City = customer.City;
                }
                if (!string.IsNullOrEmpty(customer.PostalCode))
                {
                    customerEntity.PostalCode = customer.PostalCode;
                }

                if (!string.IsNullOrEmpty(customer.AnimalName) ||
                    !string.IsNullOrEmpty(customer.AnimalAge) ||
                    !string.IsNullOrEmpty(customer.AnimalBreed) ||
                    customer.Datetime != DateTime.MinValue ||
                    !string.IsNullOrEmpty(customer.Booking))
                {
                    var animalBookingEntity = await _context.AnimalBookings.FirstOrDefaultAsync(x => 
                    x.AnimalName == customer.AnimalName && 
                    x.AnimalAge == customer.AnimalAge &&
                    x.AnimalBreed == customer.AnimalBreed &&
                    x.Datetime == customer.Datetime &&
                    x.Booking == customer.Booking
                    );
                    if (animalBookingEntity != null)
                        customerEntity.AnimalId = animalBookingEntity.Id;
                    else
                        customerEntity.Animal = new AnimalBookingEntity
                        {
                            AnimalName = customer.AnimalName,
                            AnimalAge = customer.AnimalAge,
                            AnimalBreed = customer.AnimalBreed,
                            Datetime = customer.Datetime,
                            Booking = customer.Booking
                        };

                }
                _context.Update(customerEntity);
                await _context.SaveChangesAsync();
            }
        }


        public static async Task DeleteAsync(string email)
        {
            var customer = await _context.Customers.Include(x => x.Animal).FirstOrDefaultAsync(x =>x.Email == email);
            if (customer != null)
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

    }
}
