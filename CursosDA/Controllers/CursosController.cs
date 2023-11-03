using CursosDA.Data;
using CursosDA.Models.Domain;
using CursosDA.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
                
            };

            _cursosDADbContext.Cursos.Add(curso);
            _cursosDADbContext.SaveChanges();   
            return RedirectToAction("CursoAdd", "Cursos");
        }
    }
}
