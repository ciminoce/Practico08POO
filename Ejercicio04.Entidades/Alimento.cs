using System.ComponentModel.DataAnnotations;

namespace Ejercicio04.Entidades
{
    public class Alimento : Producto
    {
        public DateTime FechaVencimiento { get; set; }

        public override decimal CalcularPrecioFinal()
        {
            var dias = (FechaVencimiento - DateTime.Now).TotalDays;
            return dias < 10 ? PrecioBase * 0.9m : PrecioBase;
        }


        public override string InformarDatosEspecificos()
        {
            return $" - Vence: {FechaVencimiento:d}";
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var item in ValidateAtributosComunes())
            {
                yield return item;
            }
            if (FechaVencimiento<=DateTime.Today.Date)
            {
                yield return new ValidationResult("Fecha de vencimiento no válida");
            }
        }
    }
}
