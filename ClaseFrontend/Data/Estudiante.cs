using System.ComponentModel.DataAnnotations;

namespace ClaseFrontend.Data
{
    public class Estudiante
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string carrera { get; set; }
        public string semestre { get; set; }
        public int prestamos { get; set; }
    }
}
