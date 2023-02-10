using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;using ECommAzista.Models;using ECommAzista.ViewModels;
using System.Threading.Tasks;
using System;using ECommAzista.CommonFunctions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;
using System.Linq;

namespace ECommAzista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersApiController : ControllerBase
    {
        Validation validation=new Validation();
        public AzistaEcommContext _azistaEcommContext;
        public CustomersApiController(AzistaEcommContext azistaEcommContext) 
        {
            _azistaEcommContext=azistaEcommContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var customers = await _azistaEcommContext.Customer.ToListAsync();
            return Ok(customers);
        }
        // [HttpGet("Id")]        
        [Route("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var customer = await _azistaEcommContext.Customer.FindAsync(Id);
            return Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Register(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }         
            //sms otp
            Random r = new Random();
            string mobileOtp = r.Next(1000, 9999).ToString();            
            OtpValidation otpValidation = new OtpValidation() {
                MobileNumber = customer.PhoneNumber, 
                Otp = mobileOtp,
                CreatedOn = DateTime.Now,
                IpAddress = validation.GetIp()};
           await _azistaEcommContext.OtpValidation.AddAsync(otpValidation);
          await _azistaEcommContext.SaveChangesAsync();
            validation.SendSms(customer.PhoneNumber, mobileOtp);
            //email otp
            Random r2 = new Random();
            string emailOtp = r2.Next(1000, 9999).ToString();
            OtpValidation otpValidation1 = new OtpValidation() { EmailId = customer.Email, Otp = emailOtp, CreatedOn = DateTime.Now, IpAddress =validation.GetIp() };
            _azistaEcommContext.OtpValidation.Add(otpValidation1);
            _azistaEcommContext.SaveChanges();
            //await _azistaEcommContext.Customer.AddAsync(customer);
            // return Ok(azistaEcommContext.SaveChangesAsync());
            return Ok();
        }
        [HttpPost]
        //[Route("VerifyUser/{,mobileNumber,smsOtp,emailOtp}")]
        [Route("VerifyUser")]
        public ActionResult VerifyUser(VerifyUserVm verifyUserVm)
        {
            var smsValidation = _azistaEcommContext.OtpValidation.Where(x => x.MobileNumber == verifyUserVm.mobileNumber).OrderByDescending(x=>x.Id).FirstOrDefault();
            var emailValidation=_azistaEcommContext.OtpValidation.Where(x=>x.EmailId== verifyUserVm.emailId).OrderByDescending(x => x.Id).FirstOrDefault();
            if(smsValidation.Otp!= verifyUserVm.smsOtp) { return Ok("Sms_Otp_Error"); }
            if(emailValidation.Otp!= verifyUserVm.emailOtp) { return Ok("Email_Otp_Error"); }

            return Ok("Verified");
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUser(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }
            customer.CreatedOnUtc = DateTime.UtcNow;

            await _azistaEcommContext.Customer.AddAsync(customer);
            return Ok(_azistaEcommContext.SaveChangesAsync());
        }
        [HttpPut]
        public async Task<ActionResult<Customer>> UpdateCustomer(Customer customer)
        {            
            _azistaEcommContext.Customer.Update(customer);            
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCustomer(int Id)
        {
            if (_azistaEcommContext.Customer == null)
            {
                return NotFound();
            }
            var customers = _azistaEcommContext.Customer.Find(Id);
            _azistaEcommContext.Customer.Remove(customers);            
            return Ok(await _azistaEcommContext.SaveChangesAsync());
        }
    }
}
