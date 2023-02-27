using ECommAzista.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;
//using static ECommAzista.Controllers.UploadApiController;
//using ECommAzista.ViewModels;


namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthArticlesApiController : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        private IWebHostEnvironment environment;

        public HealthArticlesApiController(AzistaEcommContext azistaEcommContext,IWebHostEnvironment _environment)
        {
            _azistaEcommContext = azistaEcommContext;
            environment= _environment;
        }
        //public HealthArticlesApiController(IWebHostEnvironment _environment)
        //{
        //    environment = _environment;
        //}
        public class FIleUploadApi
        {
            public IFormFile files { get; set; }
        }
        //[HttpGet("{imagePath}")]
        //public IActionResult GetImage(string imagePath)
        //{
        //    var imageBytes = System.IO.File.ReadAllBytes(imagePath);
        //    var base64Image = Convert.ToBase64String(imageBytes);
        //    return Ok(new { Image = base64Image });
        //}

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var healthArticles = await _azistaEcommContext.HealthArticle.ToListAsync();
            // var imageFileStream = System.IO.File.OpenRead(Image);
            return Ok(healthArticles);
        }
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var healthArticle = await _azistaEcommContext.HealthArticle.FindAsync(Id);
            return Ok(healthArticle);
        }
        [HttpPost]
        public async Task<IActionResult> PostHealthAricles([FromForm]HealthArticle healthArticle, IFormFile file)
        {
            if (healthArticle == null)
            {
                return BadRequest();
            }
            if (file != null && file.Length > 0)
            {
                var Image = "/images/" + Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                using (var stream = new FileStream("wwwroot" + Image, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                healthArticle.Image = Image;
            }
            healthArticle.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.HealthArticle.AddAsync(healthArticle);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
        [Route("UpdateHealthArticle")]
        [HttpPut("api/HealthArticle/{Id}")]        
        public async Task<IActionResult> UpdateHealthArticle([FromForm]int Id, [FromForm] HealthArticle model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                HealthArticle existingHealthArticle = _azistaEcommContext.HealthArticle.Find(Id);
                if (existingHealthArticle != null)
                {
                    if (file != null)
                    {
                        string uploadsFolder = Path.Combine(environment.WebRootPath, "images");
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        existingHealthArticle.Image = uniqueFileName;
                    }
                    // Update the model in your database here
                    // ...
                    return Ok(existingHealthArticle);
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }

        

        [HttpDelete]
        public async Task<ActionResult> DeleteHealthArticle(int Id)
        {
            if (_azistaEcommContext.HealthArticle == null)
            {
                return NotFound();
            }
            //if (file != null && file.Length > 0)
            //{
            //    var Image = "/images/" + Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            //    using (var stream = new FileStream("wwwroot" + Image, FileMode.Create))
            //    {
            //        await file.CopyToAsync(stream);
            //    }
            //    healthArticle.Image = Image;
            //}
            var healthArticle = _azistaEcommContext.HealthArticle.Find(Id);
            _azistaEcommContext.HealthArticle.Remove(healthArticle);
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}

