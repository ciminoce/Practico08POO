using Ejercicio04W.Entidades;

namespace Ejercicio04W.Datos
{
    public class RepositorioProductosOperadores : IRepositorioProductos
    {
        public void Agregar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void Editar(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(string codigo)
        {
            throw new NotImplementedException();
        }

        public bool Existe(string codigo)
        {
            throw new NotImplementedException();
        }

        public Producto? ObtenerPorCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerTodos(string? tipoProducto = null)
        {
            throw new NotImplementedException();
        }
    }
}
