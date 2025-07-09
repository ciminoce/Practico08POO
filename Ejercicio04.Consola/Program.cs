using Ejercicio04.Entidades;
using Ejercicio04.Ioc;
using Ejercicio04.Servicios;
using Microsoft.Extensions.DependencyInjection;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        private static IServiceProvider? serviceProvider;
        private static IServicioProductos? servicioProductos;

        static void Main(string[] args)
        {
            serviceProvider = DI.Configurar();
            servicioProductos = serviceProvider.GetRequiredService<IServicioProductos>();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("== SUPERMERCADO ==");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Listar todos");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Editar");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Agregar(); break;
                    case 2: Listar(); break;
                    case 3: Eliminar(); break;
                    case 4: Editar(); break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 0);
        }

        private static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Editar un Producto");
            Listar();
            Console.Write("Ingrese código de producto a editar:");
            string codigo = Console.ReadLine();
            var producto = servicioProductos.ObtenerProductoPorCodigo(codigo);
            if (producto is null)
            {
                Console.WriteLine("Código no encontrado");
                return;
            }
            MostrarDatos(producto);
            Console.Write("\nNombre: ");
            string? nombre = Console.ReadLine();
            Console.Write("Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine()!);
            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine()!);

            Console.Write("Tipo: 1-Alimento 2-Bebida 3-Articulo de Limpieza");
            int tipo = int.Parse(Console.ReadLine()!);

            switch (tipo)
            {
                case 1:
                    Console.Write("Fecha Vencimiento (dd-mm-yyyy): ");
                    DateTime fv = DateTime.Parse(Console.ReadLine()!);
                    producto = new Alimento { Codigo = codigo, Nombre = nombre, PrecioBase = precio, Stock = stock, FechaVencimiento = fv };
                    break;
                case 2:
                    Console.Write("¿Es alcohólica? (s/n): ");
                    bool alcohol = Console.ReadLine().ToLower() == "s";
                    producto = new Bebida { Codigo = codigo, Nombre = nombre, PrecioBase = precio, Stock = stock,  EsAlcoholica = alcohol };
                    break;
                case 3:
                    Console.Write("¿Es biodegradable? (s/n): ");
                    bool bio = Console.ReadLine().ToLower() == "s";
                    producto = new ArticuloDeLimpieza { Codigo = codigo, Nombre = nombre, PrecioBase = precio, Stock = stock, EsBiodegradable = bio };
                    break;
                default: return;
            }

            var resultado = servicioProductos.Editar(producto);
            if (resultado.EsValido)
            {
                Console.WriteLine("Producto editado.");

            }
            else
            {
                foreach (var error in resultado.Errores)
                {
                    Console.WriteLine(error);
                }
            }

        }

        private static void MostrarDatos(Producto producto)
        {
            Console.WriteLine("Datos del Producto");
            Console.WriteLine($"Código: {producto.Codigo}");
            Console.WriteLine($"Nombre: {producto.Nombre}");
            Console.WriteLine($"Precio: {producto.PrecioBase}");
            Console.WriteLine($"Stock: {producto.Stock}");
            if (producto is Bebida)
            {
                Console.WriteLine($"Es Alcohólica?:{(((Bebida)producto).EsAlcoholica ? "Si" : "No")}");
            }
            else if (producto is Alimento)
            {
                Console.Write($"Fecha Vencimiento (dd-mm-yyyy): {((Alimento)producto).FechaVencimiento.ToShortDateString()}");

            }
            else
            {
                Console.WriteLine($"Es biodegradable?:{(((ArticuloDeLimpieza)producto).EsBiodegradable ? "Si" : "No")}");
            }
        }

        public static void Agregar()
        {
            Console.Write("Código: ");
            string? codigo = Console.ReadLine();
            Console.Write("Nombre: ");
            string? nombre = Console.ReadLine();
            Console.Write("Precio Base: ");
            decimal precio = decimal.Parse(Console.ReadLine()!);
            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine()!);

            Console.Write("Tipo: 1-Alimento 2-Bebida 3-Articulo de Limpieza");
            int tipo = int.Parse(Console.ReadLine()!);

            Producto nuevoProducto;
            switch (tipo)
            {
                case 1:
                    Console.Write("Fecha Vencimiento (dd-mm-yyyy): ");
                    DateTime fv = DateTime.Parse(Console.ReadLine()!);
                    nuevoProducto = new Alimento { Codigo = codigo, Nombre = nombre, PrecioBase = precio, Stock = stock, FechaVencimiento = fv };
                    break;
                case 2:
                    Console.Write("¿Es alcohólica? (s/n): ");
                    bool alcohol = Console.ReadLine().ToLower() == "s";
                    nuevoProducto = new Bebida { Codigo = codigo, Nombre = nombre, PrecioBase = precio, Stock = stock, EsAlcoholica = alcohol };
                    break;
                case 3:
                    Console.Write("¿Es biodegradable? (s/n): ");
                    bool bio = Console.ReadLine().ToLower() == "s";
                    nuevoProducto = new ArticuloDeLimpieza { Codigo = codigo, Nombre = nombre, PrecioBase = precio, Stock = stock, EsBiodegradable = bio };
                    break;
                default: return;
            }

            var resultado = servicioProductos.Agregar(nuevoProducto);
            if (resultado.EsValido)
            {
                Console.WriteLine("Producto agregado.");

            }
            else
            {
                foreach (var error in resultado.Errores)
                {
                    Console.WriteLine(error);
                }
            }
        }

        static void Listar()
        {
            Console.Clear();
            Console.WriteLine("Listado de Productos (Datos Básicos)");
            foreach (var item in servicioProductos!.ObtenerTodos())
            {
                Console.WriteLine(item.InformarDatosBasicos());
            }
        }

        static void Buscar()
        {
            //Console.Write("Buscar nombre: ");
            //string nombre = Console.ReadLine();
            //var lista = repo.ObtenerTodos().Where(p => p.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase));
            //foreach (var p in lista)
            //    Console.WriteLine(p.Informar());
        }

        static void Eliminar()
        {
            var listaProductos = servicioProductos.ObtenerTodos();
            Console.Clear();
            Console.WriteLine("Listado de Productos");
            foreach (var item in listaProductos)
            {
                Console.WriteLine(item.InformarDatosBasicos());
            }
            Console.Write("Ingresar código a eliminar: ");
            string codigo = Console.ReadLine();

            var resultadoDto = servicioProductos.Eliminar(codigo);
            if (resultadoDto.EsValido)
            {
                Console.WriteLine($"Producto con código {codigo} eliminado!!!");
            }
            else
            {
                foreach (var error in resultadoDto.Errores)
                {
                    Console.WriteLine(error);
                }
            }

        }
    }
}
