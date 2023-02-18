using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthArticlesApiController : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        public HealthArticlesApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var healthArticles = await _azistaEcommContext.HealthArticle.ToListAsync();
            return Ok(healthArticles);
        }
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var healthArticle = await _azistaEcommContext.HealthArticle.FindAsync(Id);
            return Ok(healthArticle);
        }
        [HttpPut]
        public async Task<ActionResult<HealthArticle>> UpdateHealthArticle(HealthArticle healthArticle)
        {
            _azistaEcommContext.HealthArticle.Update(healthArticle);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
        [HttpPost]
        public async Task<IActionResult> PostHealthArticle(HealthArticle healthArticle)    
        {
            if (healthArticle == null)
            {
                return BadRequest();
            }
            // generic.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.HealthArticle.AddAsync(healthArticle);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteHealthArticle(int Id)
        {
            if (_azistaEcommContext.HealthArticle == null)
            {
                return NotFound();
            }
            var healthArticle = _azistaEcommContext.HealthArticle.Find(Id);
            _azistaEcommContext.HealthArticle.Remove(healthArticle);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}
