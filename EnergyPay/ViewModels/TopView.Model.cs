using System.ComponentModel.DataAnnotations;

namespace EnergyPay.ViewModels;

public class TopViewModel
{
    [Required]
    public string AccountId { get; set; } = null!;

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Balance must be a non-negative value.")]
    public decimal Balance { get; set; }


}