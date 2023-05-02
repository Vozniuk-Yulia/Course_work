using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("patientsHistory")]
    public class PatientHistory
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public DateTime  DateTime { get; set; }
        public Service Service { get; set; }
        public int CountOfTeeth { get; set; }
        public string Notes { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
