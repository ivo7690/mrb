using MarbleItalia.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MarbleItalia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public ActionResult About()
        {
            return View();
        }

        [Route("quarries")]
        public ActionResult Quarries()
        {
            return View();
        }

        [Route("blocks")]
        public ActionResult Blocks()
        {
            return View();
        }

        [Route("consultation")]
        public ActionResult Consultation()
        {
            return View();
        }

        [Route("slabs")]
        public ActionResult Slabs()
        {
            return View();
        }

        [Route("gallery")]
        public ActionResult Gallery()
        {
            return View();
        }

        [Route("quote")]
        [HttpGet]
        public ActionResult Quote()
        {
            return View();
        }

        [Route("quote")]
        [HttpPost]
        public ActionResult Quote(Quote model)
        {
            try
            {
                SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("mailSettings/default");

                SmtpClient Client = new SmtpClient(smtpSection.Network.Host, smtpSection.Network.Port);
                Client.Credentials = new NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password);

                HttpPostedFileBase Attach = Request.Files["attach"];
               
                MailMessage message = new MailMessage();
                if (Attach.ContentLength > 0)
                {
                    Attachment attachment = new Attachment(Attach.InputStream, Attach.FileName);
                    message.Attachments.Add(attachment);
                }
                message.To.Add(ConfigurationManager.AppSettings["mailContact"]);
                message.Subject = "Request quote mrbitalia.com";
                string quoteInfoTemplate =  "<p style='color:#444444;text-align:left;font:normal 15px/21px Arial, Helvetica, sans-serif;margin:15px 25px 5px 25px;'>"+
                                            "<span style='font:bold 13px Arial, Helvetica, sans-serif;color:#222;'>{#Type#}: </span><br /> {#Value#} </p>";
                string quoteInfo = string.Empty;

                if (!string.IsNullOrEmpty(model.Marble))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Marble").Replace("{#Value#}", model.Marble).ToString();

                if (!string.IsNullOrEmpty(model.Travertin))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Travertin").Replace("{#Value#}", model.Travertin).ToString();

                if (!string.IsNullOrEmpty(model.Limestone))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Limestone").Replace("{#Value#}", model.Limestone).ToString();

                if (!string.IsNullOrEmpty(model.OtherStone))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "OtherStone").Replace("{#Value#}", model.OtherStone).ToString();

                if (!string.IsNullOrEmpty(model.TypeSize))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Type").Replace("{#Value#}", model.TypeSize).ToString();

                if (!string.IsNullOrEmpty(model.Finishing))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Finishing").Replace("{#Value#}", model.Finishing).ToString();

                if (!string.IsNullOrEmpty(model.Thickness))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Thickness").Replace("{#Value#}", model.Thickness).ToString();

                if (!string.IsNullOrEmpty(model.Size))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Size").Replace("{#Value#}", model.Size).ToString();

                if (!string.IsNullOrEmpty(model.Lenght))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Lenght").Replace("{#Value#}", model.Lenght).ToString();

                if (!string.IsNullOrEmpty(model.Width))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Width").Replace("{#Value#}", model.Width).ToString();

                if (!string.IsNullOrEmpty(model.Height))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Height").Replace("{#Value#}", model.Height).ToString();

                if (!string.IsNullOrEmpty(model.Quantity))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Quantity").Replace("{#Value#}", model.Quantity).ToString();

                if (!string.IsNullOrEmpty(model.Edge))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "Edge").Replace("{#Value#}", model.Edge).ToString();

                if (!string.IsNullOrEmpty(model.TypeSizeDescription))
                    quoteInfo = quoteInfo + quoteInfoTemplate.Replace("{#Type#}", "DescriptionSize").Replace("{#Value#}", model.TypeSizeDescription).ToString();


                string bodyMessage = MarbleItalia.Resources.Master.QuoteMailTemplate
                                                                .Replace("{#Name#}", model.Name)
                                                                .Replace("{#Phone#}", model.Phone)
                                                                .Replace("{#Email#}", model.Mail)
                                                                .Replace("{#Address#}", model.Location)
                                                                .Replace("{#Message#}", model.Message)
                                                                .Replace("{#QuoteInfo#}", quoteInfo).ToString();

                message.Body = bodyMessage;
                message.From = new MailAddress("noreply@mrbitalia.com");
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                Client.Send(message);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", new { messageSent = false });
            }

            //feedback mail to contact
            bool res = sendFeedbackMessage(model.Mail, model.Name);

            return RedirectToAction("Index", new { messageSent = true });
        }

        [Route("contact")]
        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }


        [Route("contact")]
        [HttpPost]
        public ActionResult Contact(string mail, string name, string txtMessage)
        {
            try
            {
                SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("mailSettings/default");

                SmtpClient Client = new SmtpClient(smtpSection.Network.Host, smtpSection.Network.Port);
                Client.Credentials = new NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password);

                MailMessage message = new MailMessage();

                message.To.Add(ConfigurationManager.AppSettings["mailContact"]);
                message.Subject = "Contact by form mrbitalia.com";

                string bodyMessage = MarbleItalia.Resources.Master.ContactformMailTemplate
                                                                .Replace("{#Name#}", name)
                                                                .Replace("{#Email#}", mail)
                                                                .Replace("{#Message#}", txtMessage).ToString();

                message.Body = bodyMessage;
                message.From = new MailAddress("noreply@mrbitalia.com");

                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                Client.Send(message);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", new { messageSent = false });
            }

            //feedback mail to contact
            bool res = sendFeedbackMessage(mail, name);

            return RedirectToAction("Index", new { messageSent = true });
        }

        [Route("privacy")]
        public ActionResult Privacy()
        {
            return View();
        }

        private bool sendFeedbackMessage(string mail, string name)
        {
            bool res = false;
            try
            {
                SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("mailSettings/secondary");

                SmtpClient Client = new SmtpClient(smtpSection.Network.Host, smtpSection.Network.Port);
                Client.Credentials = new NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password);
                MailMessage message = new MailMessage();

                message.To.Add(mail);
                message.Subject = "Thank you for contact us";
                string bodyMessage = MarbleItalia.Resources.Master.FeedbackMailTemplate.Replace("{#Name#}", name).Replace("{#Email#}", mail).ToString();
                message.Body = bodyMessage;
                message.From = new MailAddress("noreply@mrbitalia.it");

                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                Client.Send(message);

                res = true;
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }
}