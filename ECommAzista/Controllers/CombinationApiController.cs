using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CombinationApiController : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        public CombinationApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var combinations = await _azistaEcommContext.CombinationMaster.ToListAsync();
            return Ok(combinations);
        }
        // [HttpGet("Id")]        
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var combination = await _azistaEcommContext.CombinationMaster.FindAsync(Id);
            return Ok(combination);
        }
        [HttpPost]
        public async Task<IActionResult> PostCombinations(CombinationMaster combination)
        {
            if (combination == null)
            {
                return BadRequest();
            }
            // generic.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.CombinationMaster.AddAsync(combination);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpPut]
        public async Task<ActionResult<CombinationMaster>> UpdateCombinations(CombinationMaster combination)
        {
            _azistaEcommContext.CombinationMaster.Update(combination);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCombinations(int Id)
        {
            if (_azistaEcommContext.CombinationMaster == null)
            {
                return NotFound();
            }
            var combination = _azistaEcommContext.CombinationMaster.Find(Id);
            _azistaEcommContext.CombinationMaster.Remove(combination);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}

 