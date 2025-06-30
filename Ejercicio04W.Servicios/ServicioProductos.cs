using Ejercicio04W.Datos;
using Ejercicio04W.Entidades;
using Ejercicio04W.Servicios.Dto;

namespace Ejercicio04W.Servicios
{
    public class ServicioProductos : IServicioProductos
    {
        private IRepositorioProductos _repositorioProductos;

        public ServicioProductos(IRepositorioProductos repositorioProductos)
        {
            _repositorioProductos = repositorioProductos;
        }

        public List<Producto> ObtenerTodos(string? tipoProducto = null)
        {
            return _repositorioProductos.ObtenerTodos(tipoProducto);
        }
    }
}
