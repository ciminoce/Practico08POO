﻿using Ejercicio04.Datos;
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


        public ValidationResultDto Eliminar(string codigo)
        {
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            if (!_repositorioProductos.Existe(codigo))
            {
                resultadoDto.EsValido = false;
                resultadoDto.Errores.Add("Código inexistente!!");
            }
            else
            {
                _repositorioProductos.Eliminar(codigo);

            }
            return resultadoDto;
        }

        public ValidationResultDto Agregar(Producto producto)
        {
            ValidationContext validationContext = new ValidationContext(producto);
            List<ValidationResult> errores= new List<ValidationResult>();
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            if (Validator.TryValidateObject(producto, validationContext, errores, true))
            {
                if (_repositorioProductos.Existe(producto.Codigo))
                {
                    resultadoDto.Errores.Add("Código existente!!!");
                    resultadoDto.EsValido = false;
                }
                else
                {
                    _repositorioProductos.Agregar(producto);
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

        public Producto? ObtenerProductoPorCodigo(string codigo)
        {
            return _repositorioProductos.ObtenerPorCodigo(codigo);
        }

        public List<Producto> ObtenerTodos()
        {
            return _repositorioProductos.ObtenerTodos();
        }

        public ValidationResultDto Editar(Producto producto)
        {
            ValidationContext validationContext = new ValidationContext(producto);
            List<ValidationResult> errores = new List<ValidationResult>();
            ValidationResultDto resultadoDto = new ValidationResultDto() { EsValido = true };
            if (Validator.TryValidateObject(producto, validationContext, errores, true))
            {
                if (!_repositorioProductos.Existe(producto.Codigo))
                {
                    resultadoDto.Errores.Add("Código inexistente!!!");
                    resultadoDto.EsValido = false;
                }
                else
                {
                    _repositorioProductos.Editar(producto);
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
