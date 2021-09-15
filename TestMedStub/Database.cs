using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMedStub
{
    class Database : IDatabase
    {
        public List<Customer> GetAllCustomers()
        {
            // Forestil dig at der her er noget lækker SQL-kode, der henter kunderne fra databasen
            return new List<Customer>();
        }
    }
}
