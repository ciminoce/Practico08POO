using Ejercicio04W.Ioc;
using Ejercicio04W.Servicios;
using Microsoft.Extensions.DependencyInjection;

namespace Ejercicio04.Windows
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceProvider serviceProvider = DI.Configurar();
            IServicioProductos servicioProductos= serviceProvider.GetRequiredService<IServicioProductos>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmProductos(servicioProductos));
        }
    }
}