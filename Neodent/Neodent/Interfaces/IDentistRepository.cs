using Neodent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Interfaces
{
    public interface IDentistRepository
    {
        Dentist GetById(int id);
        void Add(Dentist dentist);
        void Delete(int id);
    }
}
