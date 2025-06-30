using Ejercicio04W.Entidades;
using Ejercicio04W.Servicios.Dto;

namespace Ejercicio04W.Servicios
{
    public class ServicioProductos : IServicioProductos
    {
        public ValidationResultDto Agregar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public ValidationResultDto Editar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public ValidationResultDto Eliminar(string codigo)
        {
            throw new NotImplementedException();
        }

        public Producto? ObtenerProductoPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerTodos(string? tipoProducto = null)
        {
            throw new NotImplementedException();
        }
    }
}
