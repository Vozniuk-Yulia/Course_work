using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("dentists")]
    public class Dentist
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }     
        public string Specialization { get; set; }
        public double WorkExperience { get; set; }
        public string Education { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
    
}
