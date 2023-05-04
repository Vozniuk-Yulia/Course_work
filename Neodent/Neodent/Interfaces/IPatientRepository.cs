using Neodent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Interfaces
{
    internal interface IPatientRepository
    {
        Patient GetById(int id);
        void Add(Patient dentist);
        void Delete(int id);
    }
}
