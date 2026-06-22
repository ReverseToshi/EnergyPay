using EnergyPay.Data;
namespace EnergyPay.Services;

public class PaymentService
{
    private readonly AppDbContext _context;

    public PaymentService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> TopUpAsync(string accountId, decimal amount)
    {
        var account = await _context.Accounts.FindAsync(accountId);
        if (account == null)
        {
            return false; // Account not found
        }

        account.Balance += amount;
        await _context.SaveChangesAsync();
        return true;
    }
}