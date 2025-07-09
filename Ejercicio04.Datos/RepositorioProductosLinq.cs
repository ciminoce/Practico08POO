using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public class RepositorioProductosLinq : IRepositorioProductos
    {
        private List<Producto> productos = new();
        public RepositorioProductosLinq()
        {
            productos = new List<Producto>
            {
                new Alimento
                {
                    Codigo = "A1001",
                    Nombre = "Pan lactal",
                    PrecioBase = 450,
                    Stock = 50,
                    FechaVencimiento = DateTime.Today.AddDays(7)
                },
                new Alimento
                {
                    Codigo = "A1002",
                    Nombre = "Leche entera",
                    PrecioBase = 600,
                    Stock = 30,
                    FechaVencimiento = DateTime.Today.AddDays(3)
                },
                new Bebida
                {
                    Codigo = "B2001",
                    Nombre = "Agua mineral",
                    PrecioBase = 350,
                    Stock = 100,
                    EsAlcoholica = false
                },
                new Bebida
                {
                    Codigo = "B2002",
                    Nombre = "Vino tinto",
                    PrecioBase = 1200,
                    Stock = 20,
                    EsAlcoholica = true
                },
                new ArticuloDeLimpieza
                {
                    Codigo = "L3001",
                    Nombre = "Lavandina",
                    PrecioBase = 300,
                    Stock = 40,
                    EsBiodegradable = false
                },
                new ArticuloDeLimpieza
                {
                    Codigo = "L3002",
                    Nombre = "Jabón ecológico",
                    PrecioBase = 500,
                    Stock = 25,
                    EsBiodegradable = true
                },
                new Alimento
                {
                    Codigo = "A1003",
                    Nombre = "Queso cremoso",
                    PrecioBase = 950,
                    Stock = 15,
                    FechaVencimiento = DateTime.Today.AddDays(5)
                },
                new Bebida
                {
                    Codigo = "B2003",
                    Nombre = "Cerveza rubia",
                    PrecioBase = 900,
                    Stock = 60,
                    EsAlcoholica = true
                },
                new ArticuloDeLimpieza
                {
                    Codigo = "L3003",
                    Nombre = "Detergente líquido",
                    PrecioBase = 420,
                    Stock = 35,
                    EsBiodegradable = true
                },
                new Alimento
                {
                    Codigo = "A1004",
                    Nombre = "Yogur bebible",
                    PrecioBase = 480,
                    Stock = 45,
                    FechaVencimiento = DateTime.Today.AddDays(6)
                }
            };
        }
        public Producto? this[string codigo]
        {
            get
            {
                // Reutilizamos la lógica de búsqueda de FirstOrDefault
                return productos.FirstOrDefault(p => p.Codigo == codigo);
            }
        }
        public void Agregar(Producto producto)
        {
            // Reutilizamos el indexador para verificar si el producto ya existe
            if (this[producto.Codigo] == null)
            {
                productos.Add(producto);
            }
            else
            {
                throw new InvalidOperationException("El producto ya existe con ese código.");
            }
        }

        public void Editar(Producto producto)
        {
            // Reutilizamos el indexador para obtener el producto existente
            var existente = this[producto.Codigo];
            if (existente != null)
            {
                int index = productos.IndexOf(existente);
                // Reemplazamos el producto en la lista
                productos[index] = producto;
            }
            else
            {
                throw new InvalidOperationException("No se encontró el producto para editar.");
            }
        }

        public void Eliminar(string codigo)
        {
            // Reutilizamos el indexador para obtener el producto
            var productoAEliminar = this[codigo];
            if (productoAEliminar != null)
            {
                productos.Remove(productoAEliminar);
            }
            else
            {
                throw new InvalidOperationException("Producto no encontrado para eliminar.");
            }
        }

        // Reutilizamos el indexador para la comprobación de existencia
        public bool Existe(string codigo) => this[codigo] != null;

        // Reutilizamos el indexador para obtener el producto por código
        public Producto? ObtenerPorCodigo(string codigo) => this[codigo];

        public List<Producto> ObtenerTodos() => productos;
    }
}

