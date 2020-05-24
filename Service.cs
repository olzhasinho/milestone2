using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ArtShop3
{
    public class Service
    {
        private readonly ILogger<Service> logger;

        public Service(ILogger<Service> logger)
        {
            this.logger = logger;
        }

        public void SendEmailDefault()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress("admin@gmail.com", "Art Shop");
                message.To.Add("zhas1ko@bk.ru");
                message.Subject = "your art on road";
                message.Body = "" +
                    "<div style=\"color: red;\"> Message from Art Shop Company</div><br><p>Your Art will be soon sent to ArtShop@gmail.com if you will have questsions <3</p>";

                using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Credentials = new NetworkCredential("beatboxbmgalem@gmail.com", "olzhas997");
                    client.Port = 587;
                    client.EnableSsl = true;

                    client.Send(message);
                    logger.LogInformation("message succesfull");
                }
            }

            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        }


        public void SendEmailCustom()
        {
            try
            {
                logger.LogInformation("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        
        }
    }
}
