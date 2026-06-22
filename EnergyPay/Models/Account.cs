namespace EnergyPay.Models;

public class Account
{
    public string AccountId { get; set; } = null!;
    public decimal Balance { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; } = null!;

    public ICollection<Payment> Payments { get; set; }
        = new List<Payment>();
    public ICollection<Reading> Readings { get; set; }
        = new List<Reading>();

    public Account(string accountNumber, decimal balance, int customerId)
    {
        AccountId = accountNumber;
        Balance = balance;
        CustomerId = customerId;
    }


    public Account()
    {
        
    }
}