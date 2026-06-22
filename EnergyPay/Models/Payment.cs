namespace EnergyPay.Models;

public class Payment
{
    public int Id { get; set; }
    public string AccountId { get; set; } = null!;
    public DateTime PaymentDate { get; set; }
    public decimal Amount { get; set; }

    public Account Account { get; set; } = null!;

    public Payment(int id, string accountId, DateTime paymentDate, decimal amount)
    {
        Id = id;
        AccountId = accountId;
        PaymentDate = paymentDate;
        Amount = amount;
    }

    public Payment()
    {
        
    }
}