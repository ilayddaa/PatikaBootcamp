using System;

namespace Homework2_MVCprojesi.Models;

public class Order
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
