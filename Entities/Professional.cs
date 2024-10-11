using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Professional
    {
        public int professionalId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string mobilePhone { get; set; }
        public int specialtyId { get; set; }

        public Professional(int professionalId, string lastName, string firstName, string dni, string email, string mobilePhone, int specialtyId)
        {
            this.professionalId = professionalId;
            this.lastName = lastName;
            this.firstName = firstName;
            this.dni = dni;
            this.email = email;
            this.mobilePhone = mobilePhone;
            this.specialtyId = specialtyId;
        }

        public override string ToString()
        {
            return $"{lastName}, {firstName}";
        }
    }
}

