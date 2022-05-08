using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        public IActionResult Get()
        {
            List<Product> prdList = new List<Product>()
            {
                new Product(){ProductId=1022,ProductName="Printer",UnitPrice=2400,Quantity=5},
                new Product(){ProductId=1023,ProductName="Keyboard",UnitPrice=2400,Quantity=4},
                new Product(){ProductId=1024,ProductName="Mouse",UnitPrice=2400,Quantity=3},
                new Product(){ProductId=1025,ProductName="IBall Mouse",UnitPrice=2400,Quantity=2},
                new Product(){ProductId=1026,ProductName="Boat Speakers",UnitPrice=2400,Quantity=1}
            };
            return Ok(prdList);
        }
    }
}
