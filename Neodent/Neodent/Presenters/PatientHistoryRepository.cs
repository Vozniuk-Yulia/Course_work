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
    internal class PatientHistoryRepository : IPatientHistoryRepository
    {
        private readonly DentistryDBContext _dbContext;
        public PatientHistoryRepository(DentistryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(PatientHistory patientHistory)
        {
            _dbContext.PatientHistories.Add(patientHistory);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var patientHistory = GetById(id);
            _dbContext.PatientHistories.Remove((PatientHistory)patientHistory);
            _dbContext.SaveChanges();
        }

        public PatientHistory GetById(int id)
        {
            return _dbContext.PatientHistories.FirstOrDefault(p => p.Id == id);
        }
    }
}
