using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;using ECommAzista.Models;
using Newtonsoft.Json;

namespace ClientAppEcomAzista.Controllers
{
    public class GenericsResponseData
    {
        public GenericMaster GenericMaster{ get; set; }
        public string Status { get; set; }
    }
    public class GenericsController : Controller
    {
        //readonly string baseUrl = System.Configuration.ConfigurationManager.AppSettings["baseUrl"].ToString();
       readonly string baseUrl = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["baseUrl"];
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> ToList()
        {
            //IEnumerable<GenericMaster> GenericMaster = objBs.GenericMastersBs.GetAll();
            //return View(GenericMaster);
            IEnumerable<GenericMaster> listinfo = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl.ToString());
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("52.172.49.176:8087/api/GenericsApi");
                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;
                    listinfo = JsonConvert.DeserializeObject<List<GenericMaster>>(Response);
                }
                return View(listinfo);
                // return Json(listInfo, JsonRequestBehavior.AllowGet);
            }
        }
        //public async Task<JsonResult> GetById(int id)
        //{
        //    GenericMaster Info = new GenericMaster();
        //    //GenericMastersViewModel tTypesViewModel = new GenericMastersViewModel();
        //    using (var client = new HttpClient())
        //    {
        //        var a = JsonConvert.SerializeObject(id);
        //        client.BaseAddress = new Uri(baseUrl);
        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage Res = await client.GetAsync("api/GenericMastersApi/GetGenericMaster" + "?id=" + a);

        //        if (Res.IsSuccessStatusCode)
        //        {
        //            var response = Res.Content.ReadAsStringAsync().Result;
        //            Info = JsonConvert.DeserializeObject<GenericMaster>(response);
        //        }

        //        // return View("GetGenericMasters", tTypesViewModel);
        //        return Json(Info);
        //    }
        //}
        //public JsonResult AddType(GenericMaster GenericMaster)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(baseUrl + "/api/GenericMastersApi/");
        //        var obj = new GenericMaster()
        //        {
        //            Type = GenericMaster.Type,
        //            ActiveStatus = GenericMaster.ActiveStatus,
        //            CreatedOn = DateTime.Now,
        //            CreatedBy = Session["AssistantName"].ToString()
        //        };

        //        //HTTP POST
        //        var postTask = client.PostAsJsonAsync<GenericMaster>("Post", obj);
        //        postTask.Wait();

        //        var result = postTask.Result;
        //        //  if (result.RequestMessage.ToString() != null)
        //        var v = "";
        //        if (result.IsSuccessStatusCode)
        //        {
        //            v = result.Content.ReadAsAsync<string>().Result;
        //            // string s= result.Content.ToString();
        //            //ViewBag.message = obj.Type + result.RequestMessage.ToString();
        //            // ViewBag.message = tb.DoctorName + "Doctor added succesfully";
        //            ModelState.Clear();
        //            //return Json(v.Result, JsonRequestBehavior.AllowGet);
        //        }
        //        return Json(v);
        //    }
        //}
        //public JsonResult Update(GenericMaster model)
        //{
        //    string ip = Request.UserHostAddress; GenericsResponseData v = new GenericsResponseData();
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(baseUrl + "/api/GenericMastersApi/");
        //        var tb = new GenericMaster()
        //        {
        //            Id = model.Id,
        //            Type = model.Type,
        //            ActiveStatus = model.ActiveStatus,
        //            CreatedOn = DateTime.Now,
        //            CreatedBy = (Session["LoggedAdminName"] + ip).ToString()
        //        };
        //        //HTTP POST
        //        // var postTask = client.PostAsJsonAsync<PmsHospital>("UpdateHospital", tb);
        //        var postTask = client.PutAsJsonAsync<GenericMaster>("Put", tb);
        //        postTask.Wait();
        //        var result = postTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            TempData["message"] = tb.Type + " Type updated succesfully";
        //            // await Task.Delay(5000);
        //            var readdata = result.Content.ReadAsAsync<string>();
        //            readdata.Wait();
        //            v.Status = readdata.Result;
        //            v.Cancer = tb;
        //            ModelState.Clear();
        //        }
        //        return Json(v, JsonRequestBehavior.AllowGet);
        //    }
        //}
        //[HttpPost]
        //public async Task<JsonResult> Active(int id)
        //{
        //    string Info = "";
        //    using (var client = new HttpClient())
        //    {
        //        var a = JsonConvert.SerializeObject(id);
        //        client.BaseAddress = new Uri(baseUrl);
        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        HttpResponseMessage Res = await client.GetAsync("api/GenericMastersApi/Active" + "?id=" + a);

        //        if (Res.IsSuccessStatusCode)
        //        {
        //            var response = Res.Content.ReadAsStringAsync().Result;
        //            //Info = JsonConvert.DeserializeObject<TreatmentType>(response);
        //            Info = JsonConvert.DeserializeObject<string>(response);
        //        }

        //        // return View("GetGenericMasters", tTypesViewModel);
        //        return Json(Info, JsonRequestBehavior.AllowGet);
        //    }
        //}
    }
}
