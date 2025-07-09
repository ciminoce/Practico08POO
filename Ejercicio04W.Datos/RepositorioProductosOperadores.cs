using Ejercicio04W.Entidades;

namespace Ejercicio04W.Datos
{
    public class RepositorioProductosOperadores : IRepositorioProductos
    {
        private List<Producto> productos;

        public RepositorioProductosOperadores()
        {
            productos = new List<Producto>();
        }


        public void Agregar(Producto nuevoProducto)
        {
            // Llama directamente al operador estático '+' y modifica la lista interna.
            RepositorioProductosOperadores resultado = this + nuevoProducto;
            productos = resultado.productos; // Actualiza la lista interna con el resultado.
        }

        // Implementación de IRepositorioProductos.Eliminar
        public void Eliminar(string codigoProducto)
        {
            // Llama directamente al operador estático '-' y modifica la lista interna.
            RepositorioProductosOperadores resultado = this - codigoProducto;
            productos = resultado.productos; // Actualiza la lista interna con el resultado.
        }

        // Implementación de IRepositorioProductos.Editar
        public void Editar(Producto productoActualizado)
        {
            if (productoActualizado == null)
            {
                throw new ArgumentNullException(nameof(productoActualizado), "El producto a editar no puede ser nulo.");
            }

            var productoExistente = this[productoActualizado.Codigo];
            if (productoExistente != null)
            {
                // Encuentra el índice para reemplazar el producto existente
                int index = productos.IndexOf(productoExistente);
                //si el index==-1 quiere decir que no existe!!! Joder
                if (index != -1)
                {
                    productos[index] = productoActualizado; // Usamos el indexador para reemplazar
                }
            }
        }


        // Implementación de IRepositorioProductos.ObtenerPorCodigo
        public Producto? ObtenerPorCodigo(string codigo)
        {
            // No hay un operador == que devuelva el objeto, solo la existencia.
            // Directamente buscamos el producto.
            return this[codigo];
        }

        // Implementación de IRepositorioProductos.Existe
        public bool Existe(string codigo)
        {
            // Reutilizamos la sobrecarga del operador ==
            return this == codigo; // Llama a la sobrecarga del operador ==
        }


        // --- Sobrecargas de Operadores (que serán llamadas por los métodos de la interfaz) ---

        // Sobrecarga del operador + para agregar un producto
        public static RepositorioProductosOperadores operator +(RepositorioProductosOperadores repositorio, Producto nuevoProducto)
        {
            if (repositorio is null)
            {
                throw new ArgumentNullException(nameof(repositorio), "El repositorio no puede ser nulo.");
            }
            if (nuevoProducto == null)
            {
                throw new ArgumentNullException(nameof(nuevoProducto), "El producto a agregar no puede ser nulo.");
            }

            // Reutilizando la sobrecarga del operador == para verificar la existencia
            if (!(repositorio == nuevoProducto.Codigo))
            {
                repositorio.productos.Add(nuevoProducto);
            }
            return repositorio;
        }

        public static RepositorioProductosOperadores operator -(RepositorioProductosOperadores repositorio, string codigoProducto)
        {
            if (repositorio is null)
            {
                throw new ArgumentNullException(nameof(repositorio), "El repositorio no puede ser nulo.");
            }
            if (string.IsNullOrWhiteSpace(codigoProducto))
            {
                throw new ArgumentException("El código del producto no puede ser nulo o vacío.", nameof(codigoProducto));
            }

            var productoAEliminar = repositorio[codigoProducto]; // Replace 'this' with 'repositorio'
            if (productoAEliminar != null)
            {
                repositorio.productos.Remove(productoAEliminar);
            }
            return repositorio;
        }

        // Sobrecarga del operador == para verificar la existencia de un producto por código
        public static bool operator ==(RepositorioProductosOperadores repositorio, string codigoProducto)
        {
            if (repositorio is null)
            {
                return string.IsNullOrWhiteSpace(codigoProducto);
            }
            if (string.IsNullOrWhiteSpace(codigoProducto))
            {
                return false;
            }
            return repositorio.productos.Any(p => p.Codigo == codigoProducto);
        }

        // Sobrecarga del operador != para complementar el operador ==
        public static bool operator !=(RepositorioProductosOperadores repositorio, string codigoProducto)
        {
            return !(repositorio == codigoProducto);
        }
        public Producto? this[string codigo]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(codigo)) throw new ArgumentException(nameof(codigo));
                Producto? producto = productos.FirstOrDefault(p => p.Codigo == codigo);
                return producto;
            }
        }

        // Indexador para acceder a productos por índice
        public Producto this[int index]
        {
            get
            {
                if (index < 0 || index >= productos.Count)
                {
                    throw new IndexOutOfRangeException("Índice fuera de los límites del arreglo.");
                }
                return productos[index];
            }
            set
            {
                if (index < 0 || index >= productos.Count)
                {
                    throw new IndexOutOfRangeException("Índice fuera de los límites del arreglo.");
                }
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "El producto no puede ser nulo.");
                }
                productos[index] = value;
            }
        }

        // Método para mostrar todos los productos en el repositorio (puede ser un método de ayuda o para debug)
        public List<Producto> ObtenerTodos(string? tipoProducto=null)
        {
            IQueryable<Producto> query = productos.AsQueryable();
            switch (tipoProducto)
            {
                case "Alimento":
                    return query.Where(p => p.GetType() == typeof(Alimento)).ToList();
                case "ArticuloDeLimpieza":
                    return query.Where(p => p.GetType() == typeof(ArticuloDeLimpieza)).ToList();
                case "Bebida":
                    return query.Where(p => p.GetType() == typeof(Bebida)).ToList();

                default:
                    return query.ToList();
            }
            
        }

        // Propiedad para obtener el conteo de productos
        public int Count
        {
            get { return productos.Count; }
        }

        // --- Implementación de Equals y GetHashCode para el repositorio ---
        public override bool Equals(object? obj) // Cambiar el tipo de parámetro a "object?" para que coincida con la nulabilidad del miembro base.
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            RepositorioProductosOperadores other = (RepositorioProductosOperadores)obj;

            if (this.productos.Count != other.productos.Count)
            {
                return false;
            }

            for (int i = 0; i < this.productos.Count; i++)
            {
                if (!this.productos[i].Equals(other.productos[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                foreach (var producto in productos)
                {
                    hash = hash * 23 + (producto != null ? producto.GetHashCode() : 0);
                }
                return hash;
            }
        }

    }
}
