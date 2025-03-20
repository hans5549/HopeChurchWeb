using HopeChurchWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HopeChurchWeb.Data;

public class ChurchDBContext : DbContext
{
    public DbSet<LinksMain> LinksMains { get; set; }
    public DbSet<FavoriteLink> FavoriteLinks { get; set; }
    public DbSet<UserMain> UserMains { get; set; }
    public DbSet<ForumArticleCategory> ForumArticleCategories { get; set; }

    private readonly IConfiguration _configuration;

    public ChurchDBContext(
        DbContextOptions<ChurchDBContext> options,
        IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("ChurchDBConnection")!;
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}