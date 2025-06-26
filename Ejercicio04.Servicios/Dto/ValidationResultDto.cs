namespace Ejercicio04.Servicios.Dto
{
    public class ValidationResultDto
    {
        public bool EsValido { get; set; }
        public List<string> Errores { get; set; } = new List<string>();
    }
}
