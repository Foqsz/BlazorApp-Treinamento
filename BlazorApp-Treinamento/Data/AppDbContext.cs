using BlazorApp_Treinamento.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_Treinamento.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Category> Categories { get; set; } = null!;
}

