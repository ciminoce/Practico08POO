using System.ComponentModel.DataAnnotations;

namespace Ejercicio04.Entidades
{
    public class ArticuloDeLimpieza : Producto
    {
        public bool EsBiodegradable { get; set; }

        public override decimal CalcularPrecioFinal()
        {
            return EsBiodegradable ? PrecioBase * 0.95m : PrecioBase;
        }


        public override string InformarDatosEspecificos()
        {
            return $" - {(EsBiodegradable ? "Biodegradable" : "No biodegradable")}";
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var item in ValidateAtributosComunes())
            {
                yield return item;
            }
        }
    }
}
