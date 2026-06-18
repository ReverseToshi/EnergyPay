namespace EnergyPay.Models;

public class Tariff
{
    public int Id { get; set; }
    public string TariffName { get; set; }
    public decimal Rate { get; set; }

    public Tariff(int id, string tariffName, decimal rate)
    {
        Id = id;
        TariffName = tariffName;
        Rate = rate;
    }

    public Tariff()
    {
        
    }
}