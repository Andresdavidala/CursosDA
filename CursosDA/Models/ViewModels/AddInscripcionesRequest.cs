using CursosDA.Models.Domain;

namespace CursosDA.Models.ViewModels
{
    public class AddInscripcionesRequest
    {
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
