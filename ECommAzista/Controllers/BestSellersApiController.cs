using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestSellersApiController : ControllerBase
    {
       
        public AzistaEcommContext _azistaEcommContext;
        public BestSellersApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var bestsellers = await _azistaEcommContext.BestSellingProducts.ToListAsync();
            return Ok(bestsellers);
        }
        // [HttpGet("Id")]        
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var bestsellers = await _azistaEcommContext.BestSellingProducts.FindAsync(Id);
            return Ok(bestsellers);
        }
        [HttpPost]
        public async Task<IActionResult> PostBestsellingproducts(BestSellingProducts bestSellingProducts)
        {
            if (bestSellingProducts == null)
            {
                return BadRequest();
            }
            // generic.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.BestSellingProducts.AddAsync(bestSellingProducts);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpPut]
        public async Task<ActionResult<BestSellingProducts>> UpdateBestsellingproducts(BestSellingProducts bestSellingProducts)
        {
            _azistaEcommContext.BestSellingProducts.Update(bestSellingProducts);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBestsellingProducts(int Id)
        {
            if (_azistaEcommContext.BestSellingProducts == null)
            {
                return NotFound();
            }
            var bestSellingProducts = _azistaEcommContext.BestSellingProducts.Find(Id);
            _azistaEcommContext.BestSellingProducts.Remove(bestSellingProducts);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}
