using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TEST_API2;
using UnderstandingASPNETCore2x.Data;
using UnderstandingASPNETCore2x.Data.Entities;


namespace UnderstandingASPNETCore2x.Controllers
{
    [Route("api/[Controller]/[Action]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : Controller
    {
        private readonly IFooRepository _fooRepository;
        

        public ProductsController(IFooRepository fooRepository)
        {
            _fooRepository = fooRepository;
            
        }

        [HttpGet]
        //[Produces("application/xml")]
        public ActionResult<IEnumerable<Product>> Get()
        {
            Product p = new Product();
            p.Id = 66;
            p.Name = "Bob";

            int i = 2;
            object j = i;
            string x = j.ToString();
            if (j.GetType() == typeof(int))
                x = "";

            var t = _fooRepository.changeProduct(p);

            try
            {
                var products = _fooRepository.GetProducts();
                return Ok(products);
            }
            catch
            {
                return BadRequest("Failed to get products");
            }            
        }

        

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var product = _fooRepository.GetProduct(id);
                

                if (product != null)
                    return Ok(_fooRepository.GetProduct(id));
                else
                    return NotFound();
            }
            catch
            {
                return BadRequest("Failed to get product");
            }
        }

        [HttpGet]
        public IActionResult Poop()
        {
            try
            {
                return Ok("PooP");
            }
            catch
            {
                return BadRequest("Failed to get poop");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            return Ok();
        }
    }
}
