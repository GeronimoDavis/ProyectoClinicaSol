using System.Data;
using System.Data.SqlClient;


namespace Entities
{
    public class Specialty
    {
        public int specialtyId { get; set; }
        public string specialtyName { get; set; }

        public Specialty(int specialtyId, string specialtyName)
        {
            this.specialtyId = specialtyId;
            this.specialtyName = specialtyName;
        }

        public override string ToString()
        {
            return specialtyName;
        }
    }

}
