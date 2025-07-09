using Ejercicio04.Entidades;
using Ejercicio04.Servicios.Dto;

namespace Ejercicio04.Servicios
{
    public interface IServicioProductos
    {
        ValidationResultDto Agregar(Producto producto);
        ValidationResultDto Editar(Producto producto);
        ValidationResultDto Eliminar(string codigo);
        Producto? ObtenerProductoPorCodigo(string codigo);
        List<Producto> ObtenerTodos();
    }

}
