using System;
using System.Windows.Forms;
using Serilog;

namespace PalaceGestion
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configuration du logger Serilog pour écrire les logs dans la console,
            // les fichiers log.txt et errorlog.txt, ainsi que dans l'EventLog Windows
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .WriteTo.File("logs/log.txt",
                rollingInterval: RollingInterval.Day)
                .WriteTo.File("logs/errorlog.txt",
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information)
                .WriteTo.EventLog("NombreCache",
                manageEventSource: true,
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Fatal)
                .CreateLogger();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
