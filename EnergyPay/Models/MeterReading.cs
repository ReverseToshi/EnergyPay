namespace EnergyPay.Models;

public class Reading
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public DateTime ReadingDate { get; set; }
    public decimal ReadingValue { get; set; }

    public Account Account { get; set; } = null!;

    public Reading(int id, int accountId, DateTime readingDate, decimal readingValue)
    {
        Id = id;
        AccountId = accountId;
        ReadingDate = readingDate;
        ReadingValue = readingValue;
    }

    public Reading()
    {
        
    }
}