using System.Security.Cryptography.X509Certificates;
using Homework2_MVCprojesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework2_MVCprojesi.Controllers
{
    public class CustomerOrdersController : Controller
    {
        // GET: CustomerOrdersController
        public ActionResult Index()
        {
            Customer customer = new Customer // Customer nesnesi oluşturuldu.
            {
                Id = 1,
                FirstName = "ilayda",
                LastName = "taş",
                Email = "ilydatass@gmail.com"
            };

            List<Order> orders = new List<Order> // Order nesnesi oluşturuldu.
            {
                new Order {Id=11, ProductName="İPhone 15 ProMax", Price=85000, Quantity=1},
                new Order {Id=12, ProductName="G29", Price=17500, Quantity=2},
            };
            var viewModel = new CustomerOrderViewModel // CustomerOrderViewModel nesnesi oluşturuldu.
            {
                Customer = customer,
                Orders = orders,
                WelcomeMessage = "Welcome to my Page BABY😻",
                GoodbyeMessage = "Goodbye my friend😢"
            };


            return View(viewModel); // viewModel döndürüldü.
        }

    }
}

