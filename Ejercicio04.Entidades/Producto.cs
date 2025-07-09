using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Ejercicio04.Entidades
{
    public abstract class Producto : IValidatableObject
    {
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public decimal PrecioBase { get; set; }
        public int Stock { get; set; }

        public abstract decimal CalcularPrecioFinal();

        public string InformarDatosBasicos()
        {
            return $"[{Codigo}] {Nombre} - Stock: {Stock} - Precio Final: {CalcularPrecioFinal():C}";
        }
        public abstract string InformarDatosEspecificos();
        public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
        protected IEnumerable<ValidationResult> ValidateAtributosComunes()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                yield return new ValidationResult("Nombre obligatorio");

            if (string.IsNullOrWhiteSpace(Codigo) || Codigo.Length != 5 ||
                    !Regex.IsMatch(Codigo, @"^[A-Za-z0-9]{5}$"))
                yield return new ValidationResult("Código debe tener 5 caracteres alfanuméricos");

            if (PrecioBase <= 0)
                yield return new ValidationResult("Precio base debe ser mayor que 0");

            if (Stock < 0)
                yield return new ValidationResult("El stock no puede ser negativo");

        }
    }
}
