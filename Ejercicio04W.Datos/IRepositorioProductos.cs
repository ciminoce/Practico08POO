using Ejercicio04W.Entidades;

namespace Ejercicio04W.Datos
{
    public interface IRepositorioProductos
    {
        void Agregar(Producto producto);
        void Eliminar(string codigo);
        void Editar(Producto producto); 
        Producto? ObtenerPorCodigo(string codigo); 
        bool Existe(string codigo);
        List<Producto> ObtenerTodos(string? tipoProducto=null);
    }
}
