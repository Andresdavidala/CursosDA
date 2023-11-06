using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursosDA.Models.Domain
{
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCurso { get; set; }  
        public string Nombre { get; set; }  
        public string Descripcion { get; set; } 
        public DateTime InicioCurso { get; set; }   
        public DateTime FinCurso { get; set;}

        public int ProfesorId { get; set; }
        public Profesor Proferor { get; set; }
    }
}
