using System;

namespace Homework2_MVCprojesi.Models;

public class CustomerOrderViewModel
{
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
    public string WelcomeMessage { get; set; }
    public string GoodbyeMessage { get; set; }
}
