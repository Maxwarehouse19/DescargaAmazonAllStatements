using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace DescargaAmazonAllStatements
{
    public class Email
    {

        public void Send(string generator, string emailsTo)
        {
            DateTime now = DateTime.Now;
            string now_str = now.ToString("yyyy-MM-dd");
            string emailFrom = ConfigurationManager.AppSettings["EmailFrom"];
            //string emailsTo = ConfigurationManager.AppSettings["EmailsTo"];
            string emailHost = ConfigurationManager.AppSettings["EmailHost"];
            string emailSubject = ConfigurationManager.AppSettings["EmailSubject"];
            string emailBodyFile = ConfigurationManager.AppSettings["EmailBodyFile"];
            string emailBodyEmpty = ConfigurationManager.AppSettings["EmailBodyEmpty"];
            string credentialUser = ConfigurationManager.AppSettings["EmailCredentialUser"];
            string credentialPassword = ConfigurationManager.AppSettings["EmailCredentialPassword"];

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(emailFrom);
                foreach(string address in emailsTo.Split(','))
                {
                    message.To.Add(new MailAddress(address));
                }
                
                message.Subject = emailSubject + " " + now_str;
                message.IsBodyHtml = true; //to make message body as html 
                emailBodyEmpty = emailBodyEmpty.Replace("@", "<br />");
                message.Body = emailBodyEmpty;

                Attachment attachment;
                if (File.Exists(generator))
                {

                    emailBodyFile = emailBodyFile.Replace("@", "<br />");
                    message.Body = emailBodyFile;
                    attachment = new Attachment(generator);
                    message.Attachments.Add(attachment);

                    smtp.Port = 587;
                    smtp.Host = emailHost; //for gmail host  
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(credentialUser, credentialPassword);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }


            }
            catch (Exception exception) {
                //clsLogguer.Log("Email: " + exception.ToString());
                string Mesagge = exception.ToString();
            }
        }
    }
}
