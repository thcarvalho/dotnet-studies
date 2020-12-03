using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_entityframework_example.Models
{
  public class Product
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public int CategoryID { get; set; }
    public Category Category { get; set; }

  }
}
