using System;
using System.Windows.Forms;

namespace ExcursionProject
{
    static class StartUp
    {
        //private static object options;

        public static IServiceProvider ServiceProvider { get; set; }
        static void ConfigureServices()
        {
            var services = new ServiceConllection();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\MSSQLSERVER;Database=ExcursionProject;Trusted_Connection=True");
            });
            ServiceProvider = services.BuildServiceProvider();
        }
        
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
