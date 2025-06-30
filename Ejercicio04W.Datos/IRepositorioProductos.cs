using Ejercicio04W.Entidades;

namespace Ejercicio04W.Datos
{
    public interface IRepositorioProductos
    {
        void Agregar(Producto producto);
        void Eliminar(string codigo);
        void Editar(Producto producto); // Asumiendo que esta es la operación de Modificación
        Producto? ObtenerPorCodigo(string codigo); // Asumiendo que esta es la operación de Búsqueda
        bool Existe(string codigo);
        List<Producto> ObtenerTodos(string? tipoProducto=null);
    }
}
