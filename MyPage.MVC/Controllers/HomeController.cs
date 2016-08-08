using MyPage.Library;
using MyPage.MVC.Models;
using System;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web.Mvc;

namespace MyPage.MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "MyPage - Josué";
            return View();
        }

        public ActionResult Code()
        {
            return View();
        }

        public ActionResult Hobby()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid == false)
                return View();

            string subject = string.Format(Resources.Resources.EmailContactSubject, contact.Name);

            StringBuilder strMessage = new StringBuilder();
            strMessage.AppendFormat(string.Format(Resources.Resources.EmailContactBody, contact.Name, contact.Phone, contact.Email, DateTime.Now.ToString(CultureInfo.InvariantCulture)));

            strMessage.AppendLine(string.Format(Resources.Resources.EmailContactMessage, contact.Message.Replace("\n", "<br />")));

            Messaging.SendEmail(subject, strMessage.ToString(), ConfigurationManager.AppSettings["ContactEmail"]);

            return RedirectToAction("Index", new
            {
                message = "EmailSent"
            });
        }
      
    }
}
