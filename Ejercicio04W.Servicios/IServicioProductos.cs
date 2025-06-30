using Ejercicio04W.Entidades;
using Ejercicio04W.Servicios.Dto;

namespace Ejercicio04W.Servicios
{
    public interface IServicioProductos
    {
        ValidationResultDto Agregar(Producto producto);
        ValidationResultDto Editar(Producto producto);
        ValidationResultDto Eliminar(string codigo);
        Producto? ObtenerProductoPorCodigo(string codigo);
        List<Producto> ObtenerTodos(string? tipoProducto=null);
    }
}
