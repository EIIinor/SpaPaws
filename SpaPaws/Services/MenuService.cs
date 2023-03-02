
namespace SpaPaws.Services;

internal class MenuService
{

    //public async Task CreateNewCustomerAsync()
    //{
    //    var customer = new Customer();

    //    Console.Write("Förnamn: ");
    //    customer.FirstName = Console.ReadLine() ?? "";

    //    Console.Write("Efternamn: ");
    //    customer.LastName = Console.ReadLine() ?? "";

    //    Console.Write("Telefonnummer: ");
    //    customer.Phone = Console.ReadLine() ?? "";

    //    Console.Write("Gatuadress: ");
    //    customer.StreetName = Console.ReadLine() ?? "";

    //    Console.Write("Postnummer: ");
    //    customer.PostalCode = Console.ReadLine() ?? "";

    //    Console.Write("Ort: ");
    //    customer.City = Console.ReadLine() ?? "";

    //    // save customer to database
    //    var customerService = new CustomerService();
    //    await CustomerService.SaveAsync(customer);


    //}

    //public async Task ListAllCustomersAsync()
    //{
    //    // get all customers + address from database
    //    var customers = await CustomerService.GetAllAsync();

    //    if (customers.Any())
    //    {
    //        foreach (Customer customer in customer)
    //        {
    //            Console.WriteLine($"Namn: {customer.FirstName} {Customer.LastName}");
    //            Console.WriteLine($"Telefon: {customer.Phone}");
    //            Console.WriteLine($"Address: {customer.StreetName} {customer.PostalCode} {customer.City} ");
    //            Console.WriteLine("");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("Inga kontakter finns");
    //    }
    //}

    //public async Task ListSpecificCustomerAsync()
    //{
    //    // get a specific customer + address from database

    //    Console.Write("Ange förnamn på den kontakt du vill visa: ");
    //    var firstName = Console.ReadLine();


    //    if (!string.IsNullOrEmpty(firstName))
    //    {
    //        var customer = await CustomerService.GetAsync(firstName);

    //        if (customer != null)
    //        {
    //            Console.WriteLine($"Namn: {customer.FirstName} {customer.LastName}");
    //            Console.WriteLine($"Telefon: {customer.Phone}");
    //            Console.WriteLine($"Address: {customer.StreetName} {customer.PostalCode} {customer.City} ");
    //            Console.WriteLine();
    //        }
    //        else
    //        {
    //            Console.WriteLine($"Ingen kontakt med namnet {firstName} hittades");
    //            Console.WriteLine();
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Inget namn angivet.");
    //        Console.WriteLine();
    //    }
    //}


    //public async Task DeleteSpecificCustomerAsync()
    //{
    //    // delete a specific customer from database

    //    Console.Write("Ange förnamn på den kontakt du vill radera: ");
    //    var firstName = Console.ReadLine();


    //    if (!string.IsNullOrEmpty(firstName))
    //    {
    //        await CustomerService.DeleteAsync(firstName);
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Inget namn angivet.");
    //        Console.WriteLine();
    //    }
    //}


    //public async Task UpdateSpecificCustomerAsync()
    //{
    //    // update a specific customer from database

    //    Console.Write("Ange förnamn på den kontakt du vill uppdatera: ");
    //    var firstName = Console.ReadLine();


    //    if (!string.IsNullOrEmpty(firstName))
    //    {
    //        var customer = await CustomerService.GetAsync(firstName);

    //        Console.WriteLine("Fyll i fälten du vill uppdatera. \n ");

    //        Console.Write("Förnamn: ");
    //        customer.FirstName = Console.ReadLine() ?? null!;

    //        Console.Write("Efternamn: ");
    //        customer.LastName = Console.ReadLine() ?? null!;

    //        Console.Write("Telefonnummer: ");
    //        customer.Phone = Console.ReadLine() ?? null!;

    //        Console.Write("Gatuadress: ");
    //        customer.StreetName = Console.ReadLine() ?? null!;

    //        Console.Write("Postnummer: ");
    //        customer.PostalCode = Console.ReadLine() ?? null!;

    //        Console.Write("Ort: ");
    //        customer.City = Console.ReadLine() ?? null!;

    //        await CustomerService.UpdateAsync(customer);
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Inget namn angivet.");
    //        Console.WriteLine();
    //    }
    //}
}

