using Microsoft.AspNetCore.Http;

namespace ECommAzista.ViewModels
{
    public class FileModel
    {
        public string FileName { get; set; }
        public IFormFile file { get; set; }
    }
}
