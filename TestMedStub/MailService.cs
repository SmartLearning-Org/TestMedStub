using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMedStub
{
    public class MailService : IMailService
    {
        public void SendMail(String to, String subject, String body)
        {
            // Her lader vi som om der er noget kode som rent faktisk får 
            // mailen sendt
        }
    }
}
