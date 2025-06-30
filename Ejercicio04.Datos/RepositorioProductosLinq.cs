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
        private Producto? this[string codigo]
        {
            get
            {
                return productos.FirstOrDefault(p => p.Codigo == codigo);
            }
        }

        public void Agregar(Producto producto)
        {
            productos.Add(producto);
        }

        public void Editar(Producto producto)
        {
            Producto? productoInDb = this[producto.Codigo];
            if (productoInDb is null) return;
            var index = productos.IndexOf(productoInDb);
            productos[index] = producto;
        }

        public void Eliminar(string codigo)
        {
            Producto? productoInDb = this[codigo];
            if (productoInDb is null) return;
            productos.Remove(productoInDb);

        }

        public bool Existe(string codigo)
        {
            return this[codigo] != null;
        }

        public Producto? ObtenerPorCodigo(string codigo)
        {
            //return productos.FirstOrDefault(p => p.Codigo == codigo);
            return this[codigo];
        }

        public List<Producto> ObtenerTodos() => productos;


    }
}
