using Microsoft.AspNetCore.Mvc;
using SportsRUs.Models;

namespace SportsRUs.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}