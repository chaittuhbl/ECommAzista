using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Threading.Tasks;
//using ECommAzista.ViewModels;

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
        [HttpPost]
        public async Task<IActionResult> PostHealthArticle([FromForm]HealthArticle healthArticle)
        {
            if (healthArticle == null)
            {
                return BadRequest();
            }
            // generic.CreatedOnUtc = DateTime.UtcNow;
            string path = await UploadImage(healthArticle.FileUri);
            healthArticle.Image = path;
            healthArticle.CreatedOnUtc= DateTime.UtcNow;
            await _azistaEcommContext.HealthArticle.AddAsync(healthArticle);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
        [HttpPost]
        [Route("UploadImage")]
        public async Task<string> UploadImage(IFormFile file)
        {
            
            var special=Guid.NewGuid().ToString();
            var filepath = Path.Combine(Directory.GetCurrentDirectory(),
                @"\Images", special + "-" + file.FileName);
            using (FileStream ms = new FileStream(filepath, FileMode.Create))
            { 
            await file.CopyToAsync(ms);
            }
            var filename=special+ "-" + file.FileName;
            return filepath;

        }
        [HttpPut]
        public async Task<ActionResult<HealthArticle>> UpdateHealthArticle([FromForm]HealthArticle healthArticle)
        {
            if(healthArticle == null)
            {
                return BadRequest();
            }
            
            healthArticle.CreatedOnUtc= DateTime.UtcNow;
            _azistaEcommContext.HealthArticle.Update(healthArticle);
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
