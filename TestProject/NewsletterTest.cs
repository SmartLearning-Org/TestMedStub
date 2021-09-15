using Moq;
using System;
using System.Collections.Generic;
using TestMedStub;
using Xunit;

namespace TestProject
{
    public class NewsletterTest
    {
        [Fact]
        public void Test_that_subscribed_customers_are_included()
        {
            var databaseStub = new Mock<IDatabase>();

            Customer testCustomer = new();
            testCustomer.SubscribedToNewsletter = true;
            testCustomer.Email = "test@customer.invalid";
            List<Customer> testCustomerList = new();
            testCustomerList.Add(testCustomer);


            databaseStub.Setup(x => x.GetAllCustomers()).Returns(testCustomerList);

            Newsletter newsletter = new();
            newsletter.SetDatabase(databaseStub.Object);

            List<string> list = newsletter.GetRecipients();

            Assert.Single(list);
                 
        }
    }
}
