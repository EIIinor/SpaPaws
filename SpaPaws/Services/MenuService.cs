
using SpaPaws.Models;

namespace SpaPaws.Services;

internal class MenuService
{

    public async Task CreateNewCustomerAsync()
    {
        var customer = new Customer();

        Console.Write("Registrera kund: \n");

        Console.Write("Förnamn: ");
        customer.FirstName = Console.ReadLine() ?? "";

        Console.Write("Efternamn: ");
        customer.LastName = Console.ReadLine() ?? "";

        Console.Write("Telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        Console.Write("Email: ");
        customer.Email = Console.ReadLine() ?? "";

        Console.Write("Gatuadress: ");
        customer.StreetName = Console.ReadLine() ?? "";

        Console.Write("Postnummer: ");
        customer.PostalCode = Console.ReadLine() ?? "";

        Console.Write("Ort: ");
        customer.City = Console.ReadLine() ?? "";


        Console.Write("Registrera djur: \n");

        Console.Write("Djurets Namn: ");
        customer.AnimalName = Console.ReadLine() ?? "";

        Console.Write("Djurets Ålder: ");
        customer.AnimalAge = Console.ReadLine() ?? "";

        Console.Write("Djurets Ras: ");
        customer.AnimalBreed = Console.ReadLine() ?? "";


        Console.Write("Bokning: \n ");

        Console.Write("Skriv in vilken behandling önskas på djuret: ");
        customer.Booking = Console.ReadLine() ?? "";

        // save customer to database
        var customerService = new CustomerService();
        await CustomerService.SaveAsync(customer);


    }

    public async Task ListAllCustomersAsync()
    {
        // get all customers + address from database
        var customers = await CustomerService.GetAllAsync();

        if (customers.Any())
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Kundens uppgifter:");
                Console.WriteLine($"Namn: {customer.FirstName} {customer.LastName}");
                Console.WriteLine($"Telefon: {customer.PhoneNumber}");
                Console.WriteLine($"Address: {customer.StreetName} {customer.PostalCode} {customer.City} \n");

                Console.WriteLine("Djurets uppgifter:");
                Console.WriteLine($"Namn: {customer.AnimalName} Ålder:{customer.AnimalAge} Ras:{customer.AnimalBreed} \n");

                Console.WriteLine("Bokning uppgifter:");
                Console.WriteLine($"Bokningstid: {customer.Datetime}");
                Console.WriteLine($"Behandling: {customer.Booking}");
            }
        }
        else
        {
            Console.WriteLine("Inga kontakter finns");
        }
    }

    public async Task ListSpecificCustomerAsync()
    {
        // get a specific customer + address from database

        Console.Write("Ange förnamn på den kontakt du vill visa: ");
        var email = Console.ReadLine();


        if (!string.IsNullOrEmpty(email))
        {
            var customer = await CustomerService.GetAsync(email);

            if (customer != null)
            {
                Console.WriteLine("Kundens uppgifter:");
                Console.WriteLine($"Namn: {customer.FirstName} {customer.LastName}");
                Console.WriteLine($"Telefon: {customer.PhoneNumber}");
                Console.WriteLine($"Address: {customer.StreetName} {customer.PostalCode} {customer.City} \n");

                Console.WriteLine("Djurets uppgifter:");
                Console.WriteLine($"Namn: {customer.AnimalName} Ålder:{customer.AnimalAge} Ras:{customer.AnimalBreed} \n");

                Console.WriteLine("Bokning uppgifter:");
                Console.WriteLine($"Bokningstid: {customer.Datetime}");
                Console.WriteLine($"Behandling: {customer.Booking}");
            }
            else
            {
                Console.WriteLine($"Ingen kund hittades");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"Ingen email angiven.");
            Console.WriteLine();
        }
    }


    public async Task DeleteSpecificCustomerAsync()
    {
        // delete a specific customer from database

        Console.Write("Ange förnamn på den kontakt du vill radera: ");
        var email = Console.ReadLine();


        if (!string.IsNullOrEmpty(email))
        {
            await CustomerService.DeleteAsync(email);
        }
        else
        {
            Console.WriteLine($"Inget namn angivet.");
            Console.WriteLine();
        }
    }


    public async Task UpdateSpecificCustomerAsync()
    {
        // update a specific customer from database

        Console.Write("Ange förnamn på den kontakt du vill uppdatera: ");
        var email = Console.ReadLine();


        if (!string.IsNullOrEmpty(email))
        {
            var customer = await CustomerService.GetAsync(email);
            if (customer != null)
            {
                Console.WriteLine("Fyll i de fälten du vill uppdatera. \n ");


                Console.WriteLine("Kundens uppgifter: \n");


                Console.Write("Förnamn: ");
                customer.FirstName = Console.ReadLine() ?? null!;

                Console.Write("Efternamn: ");
                customer.LastName = Console.ReadLine() ?? null!;

                Console.Write("Email: ");
                customer.Email = Console.ReadLine() ?? null!;

                Console.Write("Telefonnummer: ");
                customer.PhoneNumber = Console.ReadLine() ?? null!;

                Console.Write("Gatuadress: ");
                customer.StreetName = Console.ReadLine() ?? null!;

                Console.Write("Postnummer: ");
                customer.PostalCode = Console.ReadLine() ?? null!;

                Console.Write("Ort: ");
                customer.City = Console.ReadLine() ?? null!;

                Console.WriteLine();

                Console.WriteLine("Djurets uppgifter: \n");

                Console.Write("Djurets Namn: ");
                customer.AnimalName = Console.ReadLine() ?? null!;

                Console.Write("Djurets Ålder: ");
                customer.AnimalAge = Console.ReadLine() ?? null!;

                Console.Write("Djurets Ras: ");
                customer.AnimalBreed = Console.ReadLine() ?? null!;

                Console.WriteLine();

                Console.WriteLine("Bokning: \n");

                Console.Write("Behandling: ");
                customer.Booking = Console.ReadLine() ?? null!;


                await CustomerService.UpdateAsync(customer);
            }
         }
            else
            {
                Console.WriteLine($"Ingen email angiven.");
                Console.WriteLine();
            }
    }
}

