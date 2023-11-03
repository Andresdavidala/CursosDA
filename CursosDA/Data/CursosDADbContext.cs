using CursosDA.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursosDA.Data
{
    public class CursosDADbContext : DbContext
    {
        public CursosDADbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
    }
}
