using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ModelPersistence.Models
{
    public class School
    {
        public string SchoolName { get; set; }

        public string ContactPerson { get; set; }

        public long PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public bool Active { get; set; }


        public override string ToString()
        {
            return $"{SchoolName} {ContactPerson} {PhoneNumber} {Address} {Email} {Active}";
        }
    }
}
