using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("patientsHistory")]
    internal class PatientHistory
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public DateTime  DateTime { get; set; }
        public Service Service { get; set; }
        public int CountOfTeeth { get; set; }
        public int Price { get; set; }
        public Medicine Medicines { get; set; }
        public string Notes { get; set; }
        [ForeignKey(typeof(Patient), OnDelete = "CASCADE")]
        public int PatientId { get; set; }

    }
}
