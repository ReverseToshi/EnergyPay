namespace EnergyPay.Models;

public class Account
{
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public ICollection<Payment> Payments { get; set; }
        = new List<Payment>();
    public ICollection<Reading> Readings { get; set; }
        = new List<Reading>();

    public Account(int id, string accountNumber, decimal balance)
    {
        Id = id;
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public Account()
    {
        
    }
}