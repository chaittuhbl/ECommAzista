using ECommAzista.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthArticlesNew : ControllerBase
    {
        public AzistaEcommContext _azistaEcommContext;
        public HealthArticlesNew(AzistaEcommContext azistaEcommContext)
        {
            _azistaEcommContext = azistaEcommContext;
        }
        [HttpPost]
        public async Task<ActionResult<HealthArticle>> AddHealthArticle(HealthArticle healthArticle, IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var Image = "/images/" + Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                using (var stream = new FileStream("wwwroot" + Image, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }
                healthArticle.Image = Image;
            }
                 _azistaEcommContext.HealthArticle.Add(healthArticle);
                await _azistaEcommContext.SaveChangesAsync();
                return Ok();
        }    
    }
}
