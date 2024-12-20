using System;

namespace Survivor.Models;

public class Competitor : BaseEntity
{
    public int CategoryId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Category Category { get; set; } // navigator.

}
