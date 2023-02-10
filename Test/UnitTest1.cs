using ECommAzista.Common;
using ECommAzista.Controllers;
using ECommAzista.Models;
using Microsoft.EntityFrameworkCore;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
       
        public  AzistaEcommContext azistaEcommContext;
        
        public UnitTest1(AzistaEcommContext _azistaEcommContext)
        {
            this.azistaEcommContext = _azistaEcommContext;
            var dbOption = new DbContextOptionsBuilder<AzistaEcommContext>()
   .UseSqlServer("AzistaEcommContext")
   .Options;
        }
        //[TestMethod]
        //public void TestSendSms()
        //{
        //    Validation validation = new Validation();
        //    var v = validation.SendSms("8374630142");
        //    Assert.IsNotNull(v);
        //}
        [TestMethod]
        public void TestSendEmail()
        {
            Validation validation = new Validation();
            var v = validation.SendEmail("chaituhbl@gmail.com");
            Assert.IsNotNull(v);
        }
        [TestMethod]
        public void TestRegister()
        {
            var customersApiController = new CustomersApiController(azistaEcommContext);
            Customer customer = new Customer()
            {
                PhoneNumber= "8374630142"
            };
           var v= customersApiController.Register(customer);
           Assert.AreEqual(1, v);
        }
    }
}