using HopeChurchWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HopeChurchWeb.Data;

public class ChurchDBContext : DbContext
{
    public DbSet<LinksMain> LinksMains { get; set; }
    public DbSet<UserMain> UserMains { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=localhost;Database=HopeChurchDB;User=root;Password=H@ns19951204";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}