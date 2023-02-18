using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        public ProductsApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var products = await _azistaEcommContext.Product.ToListAsync();
            return Ok(products);
        }
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var product = await _azistaEcommContext.Product.FindAsync(Id);
            return Ok(product);
        }
        [HttpPost]
            public async Task<IActionResult> PostProducts(Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            // generic.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.Product.AddAsync(product);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
        [HttpPut]
        public async Task<ActionResult<Product>> UpdateProducts(Product product)
        {
            _azistaEcommContext.Product.Update(product);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteProduct(int Id)
        {
            if (_azistaEcommContext.Product == null)
            {
                return NotFound();
            }
            var product = _azistaEcommContext.Product.Find(Id);
            _azistaEcommContext.Product.Remove(product);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}
