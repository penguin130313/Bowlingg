using Microsoft.EntityFrameworkCore;
using Bowling.Models;
namespace Database;

public class BowlingContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    
    
    public DbSet<Payment> Payments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=Client.db");

    }
}