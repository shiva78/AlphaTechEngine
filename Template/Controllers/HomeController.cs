using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(Contactus model)
        {
            string fullName = model.fullname;
            string email = model.emailaddress;
            string city = model.city;
            string state = model.state;
            string phone = model.phone;
            string message = model.message;

            MailMessage mail = new MailMessage();
            mail.To.Add("t.shiva88@gmail.com");
            mail.From = new MailAddress("alphatechengine@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.Host = "smtp.gmail.com";
            mail.Subject = "Contact page";
            mail.Body = "<table><tr><td>Fullname</td><td>" + fullName +
                "</td></tr> <tr><td>Email</td><td>" + email +
                "</td></tr> <tr><td>City</td><td>" + city +
                "</td></tr> <tr><td>States</td><td>" + state +
                "</td></tr> <tr><td>Contact number</td><td>" + phone +
                "</td></tr> <tr><td>Message</td><td>" + message + "</td></tr> </table>";
            mail.IsBodyHtml = true;
            client.Credentials = new System.Net.NetworkCredential("alphatechengine@gmail.com", "alpha@TechEngine8");
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                ViewData["message"] = "Thank you for contacting us, one of our consultant will contact you shortly";
            }
            catch (Exception e)
            {
                ViewData["errormessage"] = "Sorry, something went wrong please try agin or email your query to info@alphatechengine.com.au";
            }

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}