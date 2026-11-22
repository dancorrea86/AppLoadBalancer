using AppLoadBalancer.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AppLoadBalancer.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<ServerName> TodoItems { get; set; } = null!;
}