using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text;
using ECommAzista.Models;

namespace ECommAzista.CommonFunctions
{
    public class Validation
    {        
        public AzistaEcommContext azistaEcommContext;
        public Validation()
        {

        }
        public Validation(AzistaEcommContext _azistaEcommContext)
        {
            azistaEcommContext = _azistaEcommContext;
        }
        public string GetIp()
        {
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            return myIP;
        }
        public string SendSms(string mobileNumber,string mobileOtp)
        {
            
            //Session["OTP"] = OTP;
            // var v= HttpContext.Session.SetString("OTP", OTP);
            //HttpContext httpContext ;
            // byte[] mobileOtpbytes = Encoding.ASCII.GetBytes(mobileOtp);  //{ 0 * 32 };
            //HttpContext.Session.SetString("mobileOtp", mobileOtp);

            

            //HttpContext.Session.SetString("emailOtp", emailOtp);

            string sAPIKey = "xcX1hfrrMkCD3Eu7bq6F5w";
            string sNumber = mobileNumber;//txtcurrenttelephonenumber.Text;

            //HttpContext.Session.Set("model", model);

            string sMessage;
            sMessage = mobileOtp + @" is your OTP verification code. Code valid for 10 minutes only, one time use. 
 Please DO NOT share this OTP with anyone to ensure account's security. Hetero";// messageParameters.message;// txtsmsmessage.Text;            
            string sSenderID = "HETERO";
            string sChannel = "2";
            string sDCS = "8";
            string sFlashsms = "0";
            string sURL = "https://www.smsgatewayhub.com/api/mt/SendSMS?APIKey=" + sAPIKey + "&senderid=" + sSenderID + "&channel=" + sChannel + "&DCS=" + sDCS + "&flashsms=" + sFlashsms + "&number=" + sNumber + "&text=" + sMessage + "&route=1";

            string sResponse = GetResponse(sURL);
            return "";
        }
        public static string GetResponse(string sURL)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);
            request.MaximumAutomaticRedirections = 4;
            request.Credentials = CredentialCache.DefaultCredentials;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string sResponse = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
                return sResponse;
            }
            catch (Exception e)
            {
                string s = e.ToString();
                return s;
            }
        }
        public string SendEmail(string email,string emailOtp)
        {
            
            using (MailMessage mm = new MailMessage("chaitanya.m@heterohealthcare.com", email))
            {
                mm.Subject = "Azista Pharmacy Email Verification";
                mm.Body = @"Your Otp for Email Verification is " + emailOtp;


                //string[] CCId = cc.Split(',');
                //foreach (string CCEmail in CCId)
                //{
                //    mailMessage.CC.Add(new MailAddress(CCEmail)); //Adding Multiple CC email Id  
                //}
                //mm.CC.Add(new MailAddress("noreply@heterohealthcare.com"));
                //if (emailParametersViewModel.attachments != null)
                //{
                //    foreach (HttpPostedFileBase attachment in emailParametersViewModel.attachments)
                //    {
                //        if (attachment != null)
                //        {
                //            string fileName = Path.GetFileName(attachment.FileName);
                //            mm.Attachments.Add(new Attachment(attachment.InputStream, fileName));
                //        }
                //    }
                //}

                //Hetero email setup
                mm.IsBodyHtml = false;
                //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.Delay;
                //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.Never;
                mm.Headers.Add("Disposition-Notification-To", "chaitanya.m@heterohealthcare.com");
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "czismtp.logix.in";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("chaitanya.m@heterohealthcare.com", "Feb@2023");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);


                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email sent.');", true);

            }
            return "Email Sent";
        }
    }
}
