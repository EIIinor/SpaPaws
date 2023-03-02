using SpaPaws.Services;

var menu = new MenuService();



while (true)
{
    Console.Clear();
    Console.WriteLine("1. Skapa en ny kund & bokning");
    Console.WriteLine("2. Visa alla kunder & bokningar");
    Console.WriteLine("3. Visa en specifik kund med bokning");
    Console.WriteLine("4. Radera en specifik kund & bokning");
    Console.WriteLine("5. Updatera en specifik kund/djur eller bokning");
    Console.WriteLine("Välj ett av följande alternativ: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            await menu.CreateNewCustomerAsync();
            break;

        case "2":
            Console.Clear();
            await menu.ListAllCustomersAsync();
            break;

        case "3":
            Console.Clear();
            await menu.ListSpecificCustomerAsync();
            break;
        case "4":
            Console.Clear();
            await menu.DeleteSpecificCustomerAsync();
            break;
        case "5":
            Console.Clear();
            await menu.UpdateSpecificCustomerAsync();
            break;

    }
    Console.WriteLine("\nTryck på valfri kanpp för att komma vidare..");

    Console.ReadKey();
}