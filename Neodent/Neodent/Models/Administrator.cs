using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("administrators")]
    internal class Administrator:User
    {
        [ForeignKey(typeof(User), OnDelete = "CASCADE")]
        public int UserId { get; set; }
        public string Position { get; set; }
    }
}
