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
                
            string subject = string.Format("MyPage contact from {0}", contact.Name);

            StringBuilder strMessage = new StringBuilder();
            strMessage.AppendFormat(string.Format(@"
                <table>
                    <tr>
                        <td>From: </td>
                        <td><b>{0} &lt;{2}&gt;</b>   
                    </tr>
                    <tr>
                        <td>Email: </td>
                        <td><b>{2}</b></td>
                    </tr>
                    <tr>
                        <td>Phone: </td>
                        <td><b>{1}</b></td>
                    </tr>
                    <tr>
                        <td>At: </td>
                        <td><b>{3}</b></td>
                    </tr>
                </table>", contact.Name, contact.Phone, contact.Email, DateTime.Now.ToString(CultureInfo.InvariantCulture)));

            strMessage.AppendLine(string.Format("<br />Message: <br /><br /> {0}", contact.Message.Replace("\n", "<br />")));

            Messaging.SendEmail(subject, strMessage.ToString(), ConfigurationManager.AppSettings["ContactEmail"]);

            return RedirectToAction("Index", new
            {
                message = "EmailSent"
            });
        }
      
    }
}
