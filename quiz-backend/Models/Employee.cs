using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_backend.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Gender { get; set; }
        public string address { get; set; }
        public string addres2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int postCode { get; set; }

        public int Mobile { get; set; }

    }
}
