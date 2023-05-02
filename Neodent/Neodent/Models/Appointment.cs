using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("appointments")]
    public class Appointment
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Service Service { get; set; }
        public Patient Patient { get; set; }
        public Dentist Dentist { get; set; }
    }
}
