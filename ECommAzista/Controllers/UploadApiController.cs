using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using ECommAzista.ViewModels;
using System;
using System.IO;
using System.Threading.Tasks;
using ECommAzista.Models;
using Microsoft.AspNetCore.Hosting;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadApiController : ControllerBase
    {

        private IWebHostEnvironment environment;
        public UploadApiController(IWebHostEnvironment _environment)
        {
            environment = _environment;
        }
        public class FIleUploadApi
        {
            public IFormFile files { get; set; }
        }
        [HttpPost]
        public async Task<string> Post([FromForm] FIleUploadApi objFile)
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
                        return "\\Upload\\" + objFile.files.FileName;

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
    }
}
