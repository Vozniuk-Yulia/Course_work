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
    public class DentistRepository:IDentistRepository
    {
        private readonly DentistryDBContext _dbContext;

        public DentistRepository(DentistryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Dentist> GetAll()
        {
            return _dbContext.Dentists.ToList();
        }
        public void Add(Dentist dentist)
        {
            _dbContext.Dentists.Add(dentist);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dentist = GetById(id);
            _dbContext.Dentists.Remove(dentist);
            _dbContext.SaveChanges();
        }

        public Dentist GetById(int id)
        {
            return _dbContext.Dentists.FirstOrDefault(p => p.Id == id);
        }
    }
}
