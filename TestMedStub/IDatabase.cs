using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMedStub
{
    public interface IDatabase
    {
        public List<Customer> GetAllCustomers();
    }
}
