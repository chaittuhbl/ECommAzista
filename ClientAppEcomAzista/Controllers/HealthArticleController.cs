using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Drawing.Drawing2D;

namespace ClientAppEcomAzista.Controllers
{
    public class HealthArticleController : Controller
    {
        public  ActionResult Index()
        {           
           return View();
        }
        //public async Task<JsonResult> GetBrandsByType(int id)
        //{
        //    List<Brand> brands = new List<Brand>();
        //    if (id == 1)
        //    {
        //        brands = await db.Brands.Where(x => x.BrandCompanyId == "12").ToListAsync();
        //    }
        //    else
        //    {
        //        brands = await db.Brands.Where(x => x.BrandCompanyId != "12").ToListAsync();
        //    }
        //    return Json(brands, JsonRequestBehavior.AllowGet);
        //}

        //public async Task<JsonResult> GetById(int id)
        //{
        //    Brand brand = new Brand();
        //    brand = await db.Brands.FindAsync(id);
        //    return Json(brand, JsonRequestBehavior.AllowGet);
        //}
        //public async Task<JsonResult> Add(Brand brand)
        //{
        //    string ip = Request.UserHostAddress;
        //    db.Brands.Add(brand);
        //    int i = await db.SaveChangesAsync();
        //    var v = "";
        //    if (i > 0)
        //    {
        //        v = "added";
        //    }
        //    else
        //    {
        //        v = "error";
        //    }
        //    return Json(v, JsonRequestBehavior.AllowGet);
        //}
        //public async Task<JsonResult> Update(Brand brand)
        //{
        //    BrandsResponseData responseData = new BrandsResponseData();
        //    string ip = Request.UserHostAddress;
        //    Brand exists = db.Brands.Find(brand.BrandId);
        //    if (exists.BrandId == 0)
        //    {
        //        return Json("NoData", JsonRequestBehavior.AllowGet);
        //    }

        //    exists.BrandName = brand.BrandName;
        //    exists.BrandCompanyId = brand.BrandCompanyId;
        //    exists.MoleculeId = brand.MoleculeId;
        //    exists.Active = brand.Active;
        //    exists.ModifiedOn = DateTime.Now;
        //    exists.ModifiedBy = "test";// Session["LoggedUserName"].ToString();
        //    await db.SaveChangesAsync();
        //    responseData.Status = "Success";
        //    BrandsVm brandsVm = new BrandsVm();
        //    brandsVm.BrandName = exists.BrandName;
        //    int companyid = Convert.ToInt32(exists.BrandCompanyId);
        //    brandsVm.BrandCompanyName = db.Companies.Where(x => x.CompanyId == companyid).Select(x => x.CompanyName).SingleOrDefault();
        //    int moleculeid = Convert.ToInt32(exists.MoleculeId);
        //    brandsVm.MoleculeName = db.Molecules.Where(x => x.Id == moleculeid).Select(x => x.MoleculeName).SingleOrDefault();
        //    brandsVm.Active = exists.Active;
        //    responseData.brandsVm = brandsVm;
        //    return Json(responseData, JsonRequestBehavior.AllowGet);
        //}

        //public async Task<JsonResult> Active(int id)
        //{
        //    string status = "";
        //    Brand exists = await db.Brands.FindAsync(id);
        //    if (exists.Active == "Y".ToUpper())
        //    {
        //        exists.Active = "N";
        //        status = "DeActivated";
        //    }
        //    else
        //    {
        //        exists.Active = "Y";
        //        status = "Activated";
        //    }
        //    exists.ModifiedBy = "test";
        //    exists.ModifiedOn = DateTime.Now;
        //    await db.SaveChangesAsync();
        //    return Json(status, JsonRequestBehavior.AllowGet);
        //}
    }
    //public class BrandsResponseData
    //{
    //    public BrandsVm brandsVm { get; set; }
    //    public string Status { get; set; }
    //}
}
