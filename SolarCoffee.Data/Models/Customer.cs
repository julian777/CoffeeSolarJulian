using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarCoffee.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime UpdateOn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public CustomerAddresses PrimaryAddress { get; set; }

    }
}
