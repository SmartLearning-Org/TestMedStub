using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMedStub;
using Xunit;

namespace TestProject
{
    public class SendMailTest
    {
        [Fact]
        public void test_that_max_10_mails_are_sent()
        {
            var mailMock = new Mock<IMailService>();

            List<string> recipients = new();
            for (int i = 0; i < 20; i++)
            {
                recipients.Add("test@customer.invalid");
            }

            Newsletter newsletter = new();
            newsletter.SetMailService(mailMock.Object);

            int numberSent = newsletter.SendNewsLetters(recipients);

            Assert.Equal(10, numberSent);

            mailMock.Verify(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(10));
        }
    }
}
