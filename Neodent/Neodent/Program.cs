using Neodent.Context;
using Neodent.Forms;
using Neodent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neodent
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            using (var dbContext = new DentistryDBContext())
            {
                Service service = new Service() { Name="Консультація", Price=150};
                Service service1 = new Service() { Name = "Лікування", Price = 800 };
                Service service2 = new Service() { Name = "Протезування", Price = 4000 };
                dbContext.Services.Add(service);
                dbContext.Services.Add(service1);
                dbContext.Services.Add(service2);
            }
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
