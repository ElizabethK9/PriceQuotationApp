using Microsoft.AspNetCore.Mvc;
using PriceQuotationApp.Models;

namespace PriceQuotationApp.Controllers
{
    public class PriceQuotationController : Controller
    {
        public IActionResult Index()
        {
            var model = new PriceQuotation
            {
                Subtotal = 0m,
                DiscountPercent = 0m
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(PriceQuotation model)
        {
            if (ModelState.IsValid)
            {
                // Perform any additional logic here if needed
            }
            return View(model);
        }

        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}


