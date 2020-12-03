using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aspnet_entityframework_example.Models
{
  public class Category
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public List<Product> Products { get; set; }


  }
}
