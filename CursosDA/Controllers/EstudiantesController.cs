using CursosDA.Data;
using CursosDA.Models.Domain;
using CursosDA.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CursosDA.Controllers
{
    public class EstudiantesController : Controller
    {
        private CursosDADbContext cursosDBContext;

        public EstudiantesController(CursosDADbContext cursosDBContext)
        {
            this.cursosDBContext = cursosDBContext;
        }

        [HttpGet]
        public IActionResult EstudianteAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EstudianteAdd(AddEstudianteRequest addEstudianteRequest)
        {
            var estudiante = new Estudiante
            {
                Nombre = addEstudianteRequest.Nombre,   
                Edad = addEstudianteRequest.Edad,
            };
            cursosDBContext.Estudiantes.Add(estudiante);
            cursosDBContext.SaveChanges();
            return RedirectToAction("EstudianteAdd","Estudiantes" );
        }


        [HttpGet]
     
        public IActionResult getEstudiantes()
        {
            var getEstudiante = cursosDBContext.Estudiantes.ToList();
            return View(getEstudiante);
        }
    }
}
