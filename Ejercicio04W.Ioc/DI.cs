using Ejercicio04W.Datos;
using Ejercicio04W.Servicios;
using Microsoft.Extensions.DependencyInjection;

namespace Ejercicio04W.Ioc
{
    public static class DI
    {
        public static IServiceProvider Configurar()
        {
            var servicios = new ServiceCollection();

            servicios.AddScoped<IRepositorioProductos, RepositorioProductosOperadores>();
            servicios.AddScoped<IServicioProductos, ServicioProductos>();

            return servicios.BuildServiceProvider();
        }
    }
}
