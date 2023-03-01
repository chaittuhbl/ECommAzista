using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using ECommAzista.ViewModels;
using System;
using System.IO;
using System.Threading.Tasks;
using ECommAzista.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            public int Id { get; set; }
            public IFormFile files { get; set; }
            public string Employees { get; set; }
        }
        public class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string Designation { get; set; }
        }
        [HttpPost]
        public async Task<string> Post([FromForm] FIleUploadApi objFile)
        {
            //List<Employee> empList = JsonConvert.DeserializeObject<List<Employee>>(objFile.Employees);
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
                        var imgupload= "\\Upload\\" + objFile.files.FileName;
                        return imgupload;

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
