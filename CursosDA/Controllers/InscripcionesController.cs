using CursosDA.Data;
using CursosDA.Models.Domain;
using CursosDA.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CursosDA.Controllers
{
    public class InscripcionesController : Controller
    {

        private CursosDADbContext _context;

        public InscripcionesController(CursosDADbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult InscripcionesAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InscripcionesAdd(AddInscripcionesRequest addInscripcionesRequest)
        {

            var inscripciones = new Inscripcion
            {
                CursoId = addInscripcionesRequest.CursoId,
                EstudianteId = addInscripcionesRequest.EstudianteId
            };

            _context.Inscripciones.Add(inscripciones);
            _context.SaveChanges();
            return RedirectToAction("InscripcionesAdd", "Inscripciones");

        }
    }
}
