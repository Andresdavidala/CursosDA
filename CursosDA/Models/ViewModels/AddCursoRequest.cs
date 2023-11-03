using CursosDA.Models.Domain;

namespace CursosDA.Models.ViewModels
{
    public class AddCursoRequest
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime InicioCurso { get; set; }
        public DateTime FinCurso { get; set; }
        public Profesor Proferor { get; set; }
    }
}
