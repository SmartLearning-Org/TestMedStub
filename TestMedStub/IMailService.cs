using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMedStub
{
    public interface IMailService
    {
        public void SendMail(String to, String subject, String body);
    }
}
