using CursosDA.Data;
using CursosDA.Models.Domain;
using CursosDA.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CursosDA.Controllers
{
    public class CursosController : Controller
    {
        private CursosDADbContext _cursosDADbContext;

        public CursosController(CursosDADbContext cursosDADbContext) {
            _cursosDADbContext = cursosDADbContext;
        }

        [HttpGet]
        public IActionResult CursoAdd()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CursoAdd(AddCursoRequest addCursoRequest)
        {
            var curso = new Curso
            {

                Nombre = addCursoRequest.Nombre,
                Descripcion = addCursoRequest.Descripcion,
                InicioCurso = addCursoRequest.InicioCurso,
                FinCurso = addCursoRequest.FinCurso,
                ProfesorId = addCursoRequest.ProfesorId
            };

            _cursosDADbContext.Cursos.Add(curso);
            _cursosDADbContext.SaveChanges();
            return RedirectToAction("CursoAdd", "Cursos");
        }


        [HttpGet]
        public IActionResult getCursos()
        {
            var cursos = _cursosDADbContext.Cursos.Include(c => c.Proferor).
                ToList();
            return View(cursos);
        }


        [HttpGet]
        public IActionResult getCursosById(int id)
        {
            var cursosById = _cursosDADbContext.Cursos.Find(id);

            var cursoViewM = new Curso
            {
                Nombre = cursosById.Nombre,
                Descripcion = cursosById.Descripcion,
                InicioCurso = cursosById.InicioCurso,
                FinCurso = cursosById.FinCurso,
                ProfesorId = cursosById.ProfesorId
            };
            return View(cursoViewM);
        }

        [HttpPost]
        public IActionResult getCursosById(Curso updatedCurso)
        {
            // Obtener el curso desde la base de datos por ID
            var curso = _cursosDADbContext.Cursos.Find(updatedCurso.IdCurso);

            // Actualizar las propiedades del curso con los valores del modelo de vista
            curso.Nombre = updatedCurso.Nombre;
            curso.Descripcion = updatedCurso.Descripcion;
            curso.InicioCurso = updatedCurso.InicioCurso;
            curso.FinCurso = updatedCurso.FinCurso;
            curso.ProfesorId = updatedCurso.ProfesorId;

            // Guardar los cambios en la base de datos
            _cursosDADbContext.SaveChanges();

            return RedirectToAction("getCursos", "Cursos"); // Redirigir a la página principal o a donde sea necesario
        }




    }
}
