using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthRecordsApiController : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        public HealthRecordsApiController(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var healthRecords = await _azistaEcommContext.HealthRecord.ToListAsync();
            return Ok(healthRecords);
        }
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var healthrecords = await _azistaEcommContext.HealthRecord.FindAsync(Id);
            return Ok(healthrecords);
        }
        [HttpPut]
        public async Task<ActionResult<HealthRecord>> UpdateHealthRecords(HealthRecord healthRecord)
        {
            _azistaEcommContext.HealthRecord.Update(healthRecord);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteHealthRecords(int Id)
        {
            if (_azistaEcommContext.HealthRecord == null)
            {
                return NotFound();
            }
            var healthRecord = _azistaEcommContext.HealthRecord.Find(Id);
            _azistaEcommContext.HealthRecord.Remove(healthRecord);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}
