using Microsoft.AspNetCore.Mvc;
using EnergyPay.ViewModels;
using EnergyPay.Services;
namespace EnergyPay.Controllers;

public class PaymentController : Controller
{

    private readonly PaymentService _paymentService;

    public PaymentController(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }
    public IActionResult TopUp()
    {
        return View("~/Views/Payments/TopUp.cshtml", new TopViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> TopUp(TopViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Process the top-up logic here
            await _paymentService.TopUpAsync(model.AccountId, model.Balance);

            TempData["Success"] = $"£{model.Balance} has been added to account {model.AccountId}.";

            // Redirect to a success page or display a success message
            return RedirectToAction("TopUpSuccess");
        }

        // If the model state is not valid, return the view with validation errors
        return View("~/Views/Payments/TopUp.cshtml", model);
    }

    public IActionResult TopUpSuccess()
    {
        return View("~/Views/Payments/TopUpSuccess.cshtml");
    }
}