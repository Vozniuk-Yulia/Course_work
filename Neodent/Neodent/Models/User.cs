using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("users")]
    public class User
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }

        public Dentist Dentist { get; set; }

        public Patient Patient { get; set; }
      
        public Administrator Administrator { get; set; }
    }
}
