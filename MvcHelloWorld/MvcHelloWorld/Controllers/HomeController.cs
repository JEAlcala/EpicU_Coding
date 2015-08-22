using MvcHelloWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Goodbye()
        {
            return View();
        }

        public ActionResult Email()
        {
            var model = new SendEmailViewModel
            {
                ToEmail = "jealcala50@yahoo.com"
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Email(SendEmailViewModel model)
        {
        Task.Run(() =>
        {
            var msg = new MailMessage();
                
                msg.From = new MailAddress("jealcala50@yahoo.com");
                msg.ReplyToList.Add(new MailAddress("jealcala50@yahoo.com"));
                msg.To.Add (new MailAddress(model.ToEmail));
                msg.Subject = model.Subject;
                msg.Body = model.Body;

                var smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("testing@epicservers.com", "Password");
                smtp.Send(msg);
         });      
                return RedirectToAction("Thank You");
           }
           
            public ActionResult ThankYou()
           {
                return View();
           
           }
            public ActionResult Lesson10()
            {
                return View();
            }
            
        }
    }
