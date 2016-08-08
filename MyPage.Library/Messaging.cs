using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace MyPage.Library
{
    public class Messaging
    {
        public static void SendEmail(string subject, string body, params string[] to)
        {
            using (SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["EmailSmtp"], Convert.ToInt32(ConfigurationManager.AppSettings["EmailSmtpPort"])))
            {
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["EmailSender"], ConfigurationManager.AppSettings["EmailPass"]);

                MailMessage message = new MailMessage();
                message.From = new MailAddress(ConfigurationManager.AppSettings["EmailSender"]);

                foreach (string t in to)
                {
                    message.To.Add(new MailAddress(t));
                }
                
                message.IsBodyHtml = true;

                message.Subject = subject;
                message.Body = body;

#if !DEBUG
                smtpClient.Send(message);
#endif
            }
        }
    }
}
