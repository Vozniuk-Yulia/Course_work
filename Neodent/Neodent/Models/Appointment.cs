using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("appointments")]
    internal class Appointment
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        [ForeignKey(typeof(Patient), OnDelete = "CASCADE")]
        public int PatientId { get; set; }

        [ForeignKey(typeof(Dentist), OnDelete = "CASCADE")]
        public int DentistId { get; set; }

        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Service Service { get; set; }
        
    }
}
