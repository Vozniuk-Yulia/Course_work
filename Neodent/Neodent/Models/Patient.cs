using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("patients")]
    internal class Patient:User
    {
        [ForeignKey(typeof(User), OnDelete = "CASCADE")]
        public int UserId { get; set; }
        public DateTime RegistratedDate { get; set; }
        public List<string> Allergies { get; set; }
        public DateTime LastVisit { get; set; }
        public string BloodType { get; set; }
        public  ICollection<PatientHistory> patientHistories { get; set; }

    }
}
