using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using ECommAzista.ViewModels;
using System;
using System.IO;
using System.Threading.Tasks;
using ECommAzista.Models;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadApiController : ControllerBase
    {            

        [HttpPost]
        [Route("UploadFile")]
        public Response UploadFile([FromForm] FileModel fileModel)
        { 
            Response response=new Response();
            try
            {
                string path = Path.Combine(@"D:\Images", fileModel.FileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                { 
                    fileModel.file.CopyTo(stream);
                }
                
                response.StatusCode = 200;
                response.ErrorMessage = "Image Created Successfully";    
            }
            catch (Exception ex)
            {
                response.StatusCode = 100;
                response.ErrorMessage = "";
            }

            return response;

        }

       

    }

    public class Response
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
