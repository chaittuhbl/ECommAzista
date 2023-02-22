using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesApiController : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        public CategoriesApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var categories = await _azistaEcommContext.Category.ToListAsync();
            return Ok(categories);
        }
        // [HttpGet("Id")]        
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var category = await _azistaEcommContext.Category.FindAsync(Id);
            return Ok(category);
        }
        [HttpPost]
        
        public async Task<IActionResult> PostCategories(Category category)
        {
            if (category == null)
            {
                return BadRequest();
            }
            // generic.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.Category.AddAsync(category);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpPut]       
        public async Task<ActionResult<Category>> UpdateCategory(Category category)
        {
            _azistaEcommContext.Category.Update(category);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCategories(int Id)
        {
            if (_azistaEcommContext.Category == null)
            {
                return NotFound();
            }
            var categories = _azistaEcommContext.Category.Find(Id);
            _azistaEcommContext.Category.Remove(categories);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}
