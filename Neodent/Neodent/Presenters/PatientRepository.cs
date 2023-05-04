using Neodent.Context;
using Neodent.Interfaces;
using Neodent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neodent.Presenters
{
    internal class PatientRepository : IPatientRepository
    {
        private readonly DentistryDBContext _dbContext;
        public PatientRepository(DentistryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Patient patient)
        {
            _dbContext.Patients.Add(patient);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var patient = GetById(id);
            _dbContext.Patients.Remove(patient);
            _dbContext.SaveChanges();
        }

        public Patient GetById(int id)
        {
            return _dbContext.Patients.FirstOrDefault(p => p.Id == id);
        }
    }
}
