using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Models
{
    [Alias("administrators")]
    public class Administrator
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Position { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
    }
}
