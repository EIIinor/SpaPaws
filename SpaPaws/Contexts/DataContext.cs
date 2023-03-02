using Microsoft.EntityFrameworkCore;
using SpaPaws.Models.Enteties;

namespace SpaPaws.Contexts;

internal class DataContext : DbContext
{
    private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Micke\Desktop\uc-ella\SpaPaws\SpaPaws\Contexts\sql_db.mdf;Integrated Security=True;Connect Timeout=30";

    public DataContext()
    {

    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(_connectionString); 
    }


    public DbSet<AnimalBookingEntity> AnimalBookings { get; set; } = null!;
    public DbSet<CustomerEntity> Customers { get; set; } = null!;

}
