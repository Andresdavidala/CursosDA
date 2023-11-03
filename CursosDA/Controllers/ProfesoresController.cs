using CursosDA.Data;
using CursosDA.Models.Domain;
using CursosDA.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace CursosDA.Controllers
{
    public class ProfesoresController : Controller
    {
        private CursosDADbContext cursosDADbContext;
        public ProfesoresController (CursosDADbContext cursosDADbContext)
        {
            this.cursosDADbContext = cursosDADbContext;
        }

        [HttpGet]
        public IActionResult ProfesorAdd()
        {
            return View();
        }


        [HttpPost]

        public IActionResult ProfesorAdd(AddProfesorRequest addProfesorRequest)
        {
            var profesor = new Profesor
            {
                Nombre = addProfesorRequest.Nombre,
                Especialidad = addProfesorRequest.Especialidad
           };

            cursosDADbContext.Profesor.Add(profesor);
            cursosDADbContext.SaveChanges();
            return RedirectToAction("ProfesorAdd", "Profesores");
        }
    }
}
