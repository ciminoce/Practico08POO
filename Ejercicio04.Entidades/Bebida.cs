using System.ComponentModel.DataAnnotations;

namespace Ejercicio04.Entidades
{
    public class Bebida : Producto
    {
        public bool EsAlcoholica { get; set; }

        public override decimal CalcularPrecioFinal()
        {
            return EsAlcoholica ? PrecioBase * 1.15m : PrecioBase;
        }


        public override string InformarDatosEspecificos()
        {
            return $" - {(EsAlcoholica ? "Con alcohol" : "Sin alcohol")}";
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
