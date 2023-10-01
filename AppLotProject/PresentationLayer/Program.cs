using BusinessLayer;
using DataAccessLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var login = serviceProvider.GetRequiredService<LogInForm>();
                Application.Run(login);
            }
        }
        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICarBusiness, CarBusiness>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<ISaleBusiness, SaleBusiness>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerBusiness, CustomerBusiness>();
            services.AddScoped<LogInForm>();
            
        }
    }
}
