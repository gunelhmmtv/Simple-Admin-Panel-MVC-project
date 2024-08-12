using ProjectEntities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Concrete.Classes
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; }= string.Empty;

        public int CardNumber { get; set; }

        public int PhoneNumber { get; set; }
        public string Email { get; set; } = string.Empty;

        public ICollection<Order> Orders { get; set; }


    }
}
