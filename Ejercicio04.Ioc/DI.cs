using Ejercicio04.Datos;
using Ejercicio04.Servicios;
using Microsoft.Extensions.DependencyInjection;

namespace Ejercicio04.Ioc
{
    public static class DI
    {
        public static IServiceProvider Configurar()
        {
            var servicios = new ServiceCollection();

            servicios.AddScoped<IRepositorioProductos, RepositorioProductosLinq>();
            servicios.AddScoped<IServicioProductos, ServicioProductos>();

            return servicios.BuildServiceProvider();
        }
    }
}
