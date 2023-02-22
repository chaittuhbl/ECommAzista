using ECommAzista.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;
using static ECommAzista.Controllers.UploadApiController;
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
        //[HttpPost]
        //public async Task<IActionResult> PostHealthArticle([FromForm] HealthArticle healthArticle)
        //{
        //    if (healthArticle == null)
        //    {
        //        return BadRequest();
        //    }
        //    // generic.CreatedOnUtc = DateTime.UtcNow;
        //    string path = await UploadImage(imgupload.FileUri);
        //    healthArticle.Image = path;
        //    healthArticle.CreatedOnUtc = DateTime.UtcNow;
        //    await _azistaEcommContext.HealthArticle.AddAsync(healthArticle);
        //    return Ok(await _azistaEcommContext.SaveChangesAsync());
        //}
        [HttpPost]
        [Route("UploadImage")]
        public async Task<string> UploadImage([FromForm] FIleUploadApi objFile, HealthArticle healthArticle)
        {
            try
            {
                if (objFile.files.Length > 0)
                {
                    string wwwPath = this.environment.WebRootPath;
                    string contentPath = this.environment.ContentRootPath;
                    if (!Directory.Exists(wwwPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        var imgupload = "\\Upload\\" + objFile.files.FileName;
                        // return imgupload;
                        string path = imgupload;
                        healthArticle.Image = path;
                        healthArticle.CreatedOnUtc = DateTime.UtcNow;
                        await _azistaEcommContext.HealthArticle.AddAsync(healthArticle);
                        return "Success";
                     //   return Ok(await _azistaEcommContext.SaveChangesAsync());
                     //   return Ok(await _azistaEcommContext.SaveChangesAsync());

                    }
                }
                else
                {
                    return "Failed";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //[HttpPost]
        //[Route("UploadImage")]
        //public async Task<string> UploadImage(IFormFile file)
        //{

        //    var special = Guid.NewGuid().ToString();
        //    var filepath = Path.Combine(Directory.GetCurrentDirectory(),
        //        @"\Images", special + "-" + file.FileName);
        //    using (FileStream ms = new FileStream(filepath, FileMode.Create))
        //    {
        //        await file.CopyToAsync(ms);
        //    }
        //    var filename = special + "-" + file.FileName;
        //    return filepath;

        //}
        [HttpPut]
        public async Task<ActionResult<HealthArticle>> UpdateHealthArticle([FromForm] HealthArticle healthArticle)
        {
            if (healthArticle == null)
            {
                return BadRequest();
            }

            healthArticle.CreatedOnUtc = DateTime.UtcNow;
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

