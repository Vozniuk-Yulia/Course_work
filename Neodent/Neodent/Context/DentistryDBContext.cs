using Microsoft.EntityFrameworkCore;
using Neodent.Models;
using System;
using System.Linq;

namespace Neodent.Context
{
    public class DentistryDBContext : DbContext
    {
        public DentistryDBContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<PatientHistory> PatientHistories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HOME-PC;Database=Dentistry;Trusted_Connection=True" );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientHistory>()
              .HasOne<Patient>(a => a.Patient)
              .WithMany(d => d.patientHistories)
              .HasForeignKey(p => p.PatientID);

            modelBuilder.Entity<Dentist>()
            .HasOne(s => s.User)
            .WithOne(ad => ad.Dentist)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Patient>()
           .HasOne(s => s.User)
           .WithOne(ad => ad.Patient)
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Administrator>()
            .HasOne(s => s.User)
            .WithOne(ad => ad.Administrator)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
           .HasIndex(p => new { p.Name, p.Surname });
        }
    }

}