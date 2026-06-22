using Microsoft.EntityFrameworkCore;
using EnergyPay.Models;

namespace EnergyPay.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();

    public DbSet<Account> Accounts => Set<Account>();
}