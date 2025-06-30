using Ejercicio04.Entidades;
using Ejercicio04.Ioc;
using Ejercicio04.Servicios;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Specialized;

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
                    case 2:
                        Console.Clear();
                        Listar();
                        break;
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
            string? codigo = Console.ReadLine();
            if (string.IsNullOrEmpty(codigo)) return;
            var producto = servicioProductos.ObtenerProductoPorCodigo(codigo);
            if (producto is null)
            {
                Console.WriteLine("Código no encontrado");
                return;
            }

            MostrarDatos(producto);
            MostrarDatosEspecificos(producto);
            Console.WriteLine("Ingreso de datos nuevos");
            Console.Write("\nNombre: ");
            string? nuevoNombre = Console.ReadLine();
            Console.Write("Precio Base: ");
            decimal nuevoPrecio = decimal.Parse(Console.ReadLine()!);
            Console.Write("Stock: ");
            int nuevoStock = int.Parse(Console.ReadLine()!);
            if (producto is Bebida b)
            {
                Console.Write("¿Es alcohólica?(s/n):");
                bool esAlco = Console.ReadLine()!.ToUpper() == "S";
                b.Nombre = nuevoNombre;
                b.Stock = nuevoStock;
                b.PrecioBase = nuevoPrecio;
                b.EsAlcoholica = esAlco;
            }
            else if (producto is ArticuloDeLimpieza art)
            {
                Console.Write("¿Es biodegradable?(s/n):");
                bool esBio = Console.ReadLine()!.ToUpper() == "S";
                art.Nombre = nuevoNombre;
                art.Stock = nuevoStock;
                art.PrecioBase = nuevoPrecio;
                art.EsBiodegradable = esBio;

            }
            else if (producto is Alimento a)
            {
                Console.Write($"Nueva Fecha Vto:");
                var nuevaFecha = DateTime.Parse(Console.ReadLine());
                a.Nombre = nuevoNombre;
                a.Stock = nuevoStock;
                a.PrecioBase = nuevoPrecio;
                a.FechaVencimiento = nuevaFecha;

            }

            var resultado = servicioProductos.Editar(producto);
            if (resultado.EsValido)
            {
                Console.WriteLine("Producto Editado!!!");
            }
            else
            {
                foreach (var item in resultado.Errores)
                {
                    Console.WriteLine(item);
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
        }
        private static void MostrarDatosEspecificos(Producto producto)
        {
            if(producto is Bebida b)
            {
                Console.WriteLine(b.EsAlcoholica ? "Es Bebida alcohólica" : "No Es Bebida Alcohólica");
            }else if (producto is ArticuloDeLimpieza art)
            {
                Console.WriteLine(art.EsBiodegradable?"Es Biodegradable":"No es biodegradable");
            }else if(producto is Alimento a)
            {
                Console.WriteLine($"Fecha Vto: {a.FechaVencimiento.ToShortDateString()}");
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

            Producto nuevoProducto=null;
            switch (tipo)
            {
                case 1:
                    Console.Write("Fecha de Vto:");
                    var fechaVto = DateTime.Parse(Console.ReadLine());
                    nuevoProducto = new Alimento()
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        PrecioBase=precio,
                        Stock=stock,
                        FechaVencimiento=fechaVto
                    };
                    break;
                case 2:
                    Console.Write("¿Es alcohólica?(s/n)");
                    bool esAlcoholica = Console.ReadLine()!.ToLower() == "s";
                    nuevoProducto = new Bebida()
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        PrecioBase = precio,
                        Stock = stock,
                        EsAlcoholica = esAlcoholica

                    };
                    break;
                case 3:
                    Console.Write("¿Es biodegradable?(s/n)");
                    bool esBio = Console.ReadLine()!.ToLower() == "s";
                    nuevoProducto = new ArticuloDeLimpieza()
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        PrecioBase = precio,
                        Stock = stock,
                        EsBiodegradable = esBio

                    };
                    break;

                default:
                    break;
            }

            var resultado = servicioProductos!.Agregar(nuevoProducto!);
            if (resultado.EsValido)
            {
                Console.WriteLine("Producto agregado");
            }
            else
            {
                foreach (var item in resultado.Errores)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Listar()
        {
            
            Console.WriteLine("Lista de Productos (Datos Básicos)");
            foreach (Producto producto in servicioProductos!.ObtenerTodos())
            {
                Console.WriteLine(producto.InformarDatosBasicos()+" "+producto.GetType().Name);
            }
        }


        static void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("Eliminar Productos");
            Listar();
            Console.Write("Ingrese el código del producto a eliminar:");
            string? codigo=Console.ReadLine();
            if (string.IsNullOrEmpty(codigo)) return;
            Producto? producto = servicioProductos.ObtenerProductoPorCodigo(codigo);
            if(producto is null)
            {
                Console.WriteLine("Código inexistente!!!");
                return;
            }
            MostrarDatos(producto);
            MostrarDatosEspecificos(producto);
            Console.WriteLine("¿Confirma?(s/n):");
            var respuesta = Console.ReadLine();
            if (respuesta!.ToUpper() == "S")
            {
                var resultado=servicioProductos.Eliminar(codigo);
                if (resultado.EsValido)
                {
                    Console.WriteLine("Producto eliminado");
                }
                else
                {
                    foreach (var item in resultado.Errores)
                    {
                        Console.WriteLine(item );
                    }
                }
            }
        }
    }
}
