using System.ComponentModel.DataAnnotations;

namespace ClaseFrontend.Data
{
    public class Estudiante
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }
        public int Prestamos { get; set; }
    }
}
