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
        public void SetDatabase(IDatabase value)
        {
            db = value;
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
    }
}
