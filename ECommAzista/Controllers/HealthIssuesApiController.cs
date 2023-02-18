using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthIssuesApiController : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        public HealthIssuesApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var healthIssues = await _azistaEcommContext.HealthIssue.ToListAsync();
            return Ok(healthIssues);
        }
        // [HttpGet("Id")]        
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var healthIssues = await _azistaEcommContext.HealthIssue.FindAsync(Id);
            return Ok(healthIssues);
        }
        [HttpPost]
        public async Task<IActionResult> PostHealthIssue(HealthIssue healthIssue)
        {
            if (healthIssue == null)
            {
                return BadRequest();
            }
            // generic.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.HealthIssue.AddAsync(healthIssue);
            return Ok(_azistaEcommContext.SaveChangesAsync());
        }
        [HttpPut]
        public async Task<ActionResult<HealthIssue>> UpdateHealthIssues(HealthIssue healthIssue)
        {
            _azistaEcommContext.HealthIssue.Update(healthIssue);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteHealthIssues(int Id)
        {
            if (_azistaEcommContext.HealthIssue == null)
            {
                return NotFound();
            }
            var healthIssues = _azistaEcommContext.HealthIssue.Find(Id);
            _azistaEcommContext.HealthIssue.Remove(healthIssues);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

    }
}
