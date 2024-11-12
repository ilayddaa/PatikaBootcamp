using Homework2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: CustomersController
        public ActionResult Index()
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "ilayda",
                LastName = "taş",
                Email = "ilydatass@gmail.com"
            };

            CustomerViewModel customerViewModel = new CustomerViewModel
            {
                Customer = customer,
                WelcomeMessage = "Welcome to the my SWEET PAGE BABY 😻!",
                GoodbyeMessage = "Goodbye 😻!"
            };

            return View(customerViewModel);
        }

    }
}
// Controller kısmında ilk önce Customer sınıfından bir nesne oluşturulur ve bu nesnenin özelliklerine değerler atanır.
// Daha sonra CustomerViewModel sınıfından bir nesne oluşturulur ve bu nesnenin Customer özelliğine yukarıda oluşturulan customer nesnesi atanır.
// CustomerViewModel sınıfının WelcomeMessage özelliğine bir string atanır.
// Son olarak oluşturulan customerViewModel nesnesi view'a gönderilir.
// View tarafında bu nesne kullanılarak sayfada Customer ve WelcomeMessage özelliklerine erişilir.
// Bu sayede view tarafında Customer ve WelcomeMessage özelliklerine erişilmiş olur.

