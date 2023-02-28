using ClientAppEcomAzista.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.Text;

namespace ClientAppEcomAzista.Controllers
{
    public class GenericsNewController : Controller
    {
        HttpClientHandler clientHandler=new HttpClientHandler();
        Generic generic=new Generic();
        List<Generic> generics=new List<Generic>();
        public GenericsNewController()
        {
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<List<Generic>> GetGenerics()
        {
            generics = new List<Generic>();
            using (var httpClient = new HttpClient(clientHandler))
            {
                using (var response = await httpClient.GetAsync("http://52.172.49.176:8087/api/GenericsApi"))
                { 
                    string apiResponse=await response.Content.ReadAsStringAsync();
                    generics=JsonConvert.DeserializeObject<List<Generic>>(apiResponse);
                }
            }
                return generics;
        }
        [HttpGet]
        public async Task <Generic> GetGenericsById(int Id)
        {
            generic = new Generic();
            using (var httpClient = new HttpClient(clientHandler))
            {
                using (var response = await httpClient.GetAsync("http://52.172.49.176:8087/api/GenericsApi"+Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    generic = JsonConvert.DeserializeObject<Generic>(apiResponse);
                }
            }
            return generic;
        }
        [HttpPost]
        public async Task<Generic> AddUpdateGenerics(Generic generic)
        {
            generic = new Generic();
            using (var httpClient = new HttpClient(clientHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(generic), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://52.172.49.176:8087/api/GenericsApi",content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    generic = JsonConvert.DeserializeObject<Generic>(apiResponse);
                }
            }
            return generic;
        }
        [HttpDelete]
        public async Task<string> Delete(int Id)
        {
            string message = "";
            
            using (var httpClient = new HttpClient(clientHandler))
            {
                using (var response = await httpClient.DeleteAsync("http://52.172.49.176:8087/api/GenericsApi" + Id))
                {
                    message = await response.Content.ReadAsStringAsync();
                  //  generic = JsonConvert.DeserializeObject<Generic>(apiResponse);
                }
            }
            return message;
        }
        }
    }

