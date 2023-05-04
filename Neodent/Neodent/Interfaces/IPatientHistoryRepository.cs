using Neodent.Models;
using Neodent.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Interfaces
{
    internal interface IPatientHistoryRepository
    {
        PatientHistory GetById(int id);
        void Add(PatientHistory patientHistory);
        void Delete(int id);
    }
}
