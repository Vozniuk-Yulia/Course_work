using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("dentists")]
    internal class Dentist:User
    {
        [ForeignKey(typeof(User), OnDelete = "CASCADE")]
        public int UserId { get; set; }
        public string Specialization { get; set; }
        public double WorkExperience { get; set; }
        public string Education { get; set; }
    }
}
