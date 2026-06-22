namespace EnergyPay.Models;

public class Reading
{
    public int Id { get; set; }
    public string AccountId { get; set; } = null!;
    public DateTime ReadingDate { get; set; }
    public decimal ReadingValue { get; set; }

    public Account Account { get; set; } = null!;

    public Reading(int id, string accountId, DateTime readingDate, decimal readingValue)
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