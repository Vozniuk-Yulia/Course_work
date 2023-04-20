using Neodent.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Neodent.Context
{
    internal class DentistryDBContext : DbContext
    {
      
        public DentistryDBContext()
            : base("name=DentistryDBContext")
        {
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientHistory> PatientHistories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
    }

}