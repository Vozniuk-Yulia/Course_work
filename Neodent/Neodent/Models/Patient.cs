using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("patients")]
    public class Patient
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public DateTime RegistratedDate { get; set; }
        public string Allergies { get; set; }
        public DateTime LastVisit { get; set; }
        public string BloodType { get; set; }
        public  ICollection<PatientHistory> patientHistories { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        //public ICollection<Appointment> appointments { get; set; }

    }
}
