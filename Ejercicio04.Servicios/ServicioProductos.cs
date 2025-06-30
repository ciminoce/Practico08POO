using Ejercicio04.Datos;
using Ejercicio04.Entidades;
using Ejercicio04.Servicios.Dto;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio04.Servicios
{
    public class ServicioProductos : IServicioProductos
    {
        private readonly IRepositorioProductos _repositorioProductos;

        public ServicioProductos(IRepositorioProductos repositorioProductos)
        {
            _repositorioProductos = repositorioProductos;
        }

        public ValidationResultDto Agregar(Producto producto)
        {
            ValidationResultDto validationResultDto = new ValidationResultDto() { EsValido=true };
            ValidationContext validationContext = new ValidationContext(producto);
            List<ValidationResult> errores = new List<ValidationResult>();
            if(Validator.TryValidateObject(producto, validationContext, errores, true))
            {
                if (!_repositorioProductos.Existe(producto.Codigo))
                {
                    _repositorioProductos.Agregar(producto);
                }
                else
                {
                    validationResultDto.Errores.Add("Producto existente!!!");
                    validationResultDto.EsValido = false;
                }
            }
            else
            {
                validationResultDto.Errores.AddRange(
                    errores.Select(e => e.ErrorMessage ?? "Error no contemplado"
                        ));
                validationResultDto.EsValido = false;
            }
            return validationResultDto;
        }

        public ValidationResultDto Editar(Producto producto)
        {
            ValidationResultDto validationResultDto = new ValidationResultDto() { EsValido = true };
            ValidationContext validationContext = new ValidationContext(producto);
            List<ValidationResult> errores = new List<ValidationResult>();
            if (Validator.TryValidateObject(producto, validationContext, errores, true))
            {
                if (_repositorioProductos.Existe(producto.Codigo))
                {
                    _repositorioProductos.Editar(producto);
                }
                else
                {
                    validationResultDto.Errores.Add("Producto inexistente!!!");
                    validationResultDto.EsValido = false;
                }
            }
            else
            {
                validationResultDto.Errores.AddRange(
                    errores.Select(e => e.ErrorMessage ?? "Error no contemplado"
                        ));
                validationResultDto.EsValido = false;
            }
            return validationResultDto;

        }

        public ValidationResultDto Eliminar(string codigo)
        {
            ValidationResultDto validationResultDto = new ValidationResultDto() { EsValido = true };
            Producto? producto = _repositorioProductos.ObtenerPorCodigo(codigo);
            if(producto is null)
            {
                validationResultDto.EsValido = false;
                validationResultDto.Errores.Add("Código de producto inexistente");
            }
            _repositorioProductos.Eliminar(codigo);
            return validationResultDto;
        }

        public Producto? ObtenerProductoPorCodigo(string codigo)
        {
            return _repositorioProductos.ObtenerPorCodigo(codigo);
        }

        public List<Producto> ObtenerTodos()
        {
            return _repositorioProductos.ObtenerTodos();
        }

    }
}
