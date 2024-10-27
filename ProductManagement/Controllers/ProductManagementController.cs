using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductManagementController : ControllerBase
    {

        [HttpGet(Name = "GetAllProducts")]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Wax", Price = "$10.00", Image = "https://via.placeholder.com/150" },
                new Product { Id = 2, Name = "Comb", Price = "$15.00", Image = "https://via.placeholder.com/150" },
                new Product { Id = 3, Name = "Scissor", Price = "$20.00", Image = "https://via.placeholder.com/150" }
            };

            return Ok(products);
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}
