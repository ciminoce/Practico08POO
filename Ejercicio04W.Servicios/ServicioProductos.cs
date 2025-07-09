using Ejercicio04W.Datos;
using Ejercicio04W.Entidades;
using Ejercicio04W.Servicios.Dto;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio04W.Servicios
{
    public class ServicioProductos : IServicioProductos
    {
        private readonly IRepositorioProductos _repositorioProductos;

        public ServicioProductos(IRepositorioProductos repositorioProductos)
        {
            _repositorioProductos = repositorioProductos;
        }

        public ValidationResultDto Eliminar(string codigo)
        {
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            if (!_repositorioProductos.Existe(codigo)) // Llama al método Existe de IRepositorioProductos
            {
                resultadoDto.EsValido = false;
                resultadoDto.Errores.Add("Código inexistente!!");
            }
            else
            {
                _repositorioProductos.Eliminar(codigo); // Llama al método Eliminar de IRepositorioProductos
            }
            return resultadoDto;
        }

        public ValidationResultDto Agregar(Producto producto)
        {
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            List<ValidationResult> errores = new List<ValidationResult>();

            ValidationContext validationContext = new ValidationContext(producto);
            if (Validator.TryValidateObject(producto, validationContext, errores, true))
            {
                // La validación del objeto completo pasó, ahora revisamos la regla de negocio
                // de unicidad del código.
                if (_repositorioProductos.Existe(producto.Codigo)) // Llama al método Existe de IRepositorioProductos
                {
                    resultadoDto.Errores.Add("El código del producto ya existe. Por favor, use uno diferente.");
                    resultadoDto.EsValido = false;
                }
                else
                {
                    _repositorioProductos.Agregar(producto); // Llama al método Agregar de IRepositorioProductos
                }
            }
            else
            {
                // Si TryValidateObject devuelve false, significa que hay errores de validación.
                resultadoDto.Errores
                    .AddRange(errores
                    .Select(r => r.ErrorMessage ?? "Error de validación desconocido."));
                resultadoDto.EsValido = false; // Importante: marcar como inválido si hay errores
            }

            return resultadoDto;
        }

        public Producto? ObtenerProductoPorCodigo(string codigo)
        {
            return _repositorioProductos.ObtenerPorCodigo(codigo); // Llama al método ObtenerPorCodigo
        }

        public List<Producto> ObtenerTodos(string? tipoProducto = null)
        {
            return _repositorioProductos.ObtenerTodos(tipoProducto); // Llama al método ObtenerTodos
        }

        public ValidationResultDto Editar(Producto producto)
        {
            ValidationContext validationContext = new ValidationContext(producto);
            List<ValidationResult> errores = new List<ValidationResult>();
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            if (Validator.TryValidateObject(producto, validationContext, errores, true))
            {
                if (!_repositorioProductos.Existe(producto.Codigo)) // Llama al método Existe de IRepositorioProductos
                {
                    resultadoDto.Errores.Add("Código inexistente!!!");
                    resultadoDto.EsValido = false;
                }
                else
                {
                    _repositorioProductos.Editar(producto); // Llama al método Editar de IRepositorioProductos
                }
            }
            else
            {
                resultadoDto.Errores
                    .AddRange(errores
                    .Select(r => r.ErrorMessage ?? "Error de validación desconocido."));
            }
            return resultadoDto;
        }
    }
}
