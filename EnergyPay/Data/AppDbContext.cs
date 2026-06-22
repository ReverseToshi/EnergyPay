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

    public DbSet<Payment> Payments => Set<Payment>();

    public DbSet<Reading> Readings => Set<Reading>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(account => account.AccountId);
            entity.Property(account => account.Balance).HasPrecision(18, 2);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(payment => payment.Amount).HasPrecision(18, 2);
            entity.HasOne(payment => payment.Account)
                .WithMany(account => account.Payments)
                .HasForeignKey(payment => payment.AccountId)
                .HasPrincipalKey(account => account.AccountId);
        });

        modelBuilder.Entity<Reading>(entity =>
        {
            entity.Property(reading => reading.ReadingValue).HasPrecision(18, 2);
            entity.HasOne(reading => reading.Account)
                .WithMany(account => account.Readings)
                .HasForeignKey(reading => reading.AccountId)
                .HasPrincipalKey(account => account.AccountId);
        });
    }
}