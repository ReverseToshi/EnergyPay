namespace EnergyPay.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<Account> Accounts { get; set; }
        = new List<Account>();

    public Customer()
    {
        
    }

    public Customer(int id, string name, string email, string phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}
