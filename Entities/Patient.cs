using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Patient
    {
        public int patientId {  get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public int medicalRecordNumber { get; set; }
        public string dni { get; set; }
        public DateTime birthDate { get; set; }
        public string phone {  get; set; }
        public string mobilePhone { get; set; }
        public string notes { get; set; }
        public bool status { get; set; }

     
        public Patient(int patientId, string lastName, string firstName, int medicalRecordNumber, string dni, DateTime birthDate, string phone, string mobilePhone, string notes, bool status)
        {
            this.patientId = patientId;
            this.lastName = lastName;
            this.firstName = firstName;
            this.medicalRecordNumber = medicalRecordNumber;
            this.dni = dni;
            this.birthDate = birthDate;
            this.phone = phone;
            this.mobilePhone = mobilePhone;
            this.notes = notes;
            this.status = status;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
