using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMedStub
{
    public class Newsletter
    {
        private IDatabase db;
        private IMailService mailService;

        public void SetDatabase(IDatabase value)
        {
            db = value;
        }

        public void SetMailService(IMailService value)
        {
            mailService = value;
        }

        public List<String> GetRecipients()
        {
            List<String> result = new();
            var customers = db.GetAllCustomers();
            foreach(Customer c in customers)
            {
                if (c.AllowedMarketing || c.SubscribedToNewsletter)
                {
                    result.Add(c.Email);
                }
            }
            return result;
        }

        public int SendNewsLetters(List<String> recipients)
        {
            int mailsSent = 0;
            foreach(String recipient in recipients) {
                mailService.SendMail(recipient, "Nyhedsbrev", "Her er dit nyhedsbrev");
                mailsSent = mailsSent + 1;
                if (mailsSent >= 10)
                {
                    break;
                }
            }

            return mailsSent;
        }
    }
}
