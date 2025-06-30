using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public interface IRepositorioProductos
    {
        void Agregar(Producto producto);
        void Editar(Producto producto);
        void Eliminar(string codigo);
        bool Existe(string codigo);
        Producto? ObtenerPorCodigo(string codigo);
        List<Producto> ObtenerTodos();
    }
}