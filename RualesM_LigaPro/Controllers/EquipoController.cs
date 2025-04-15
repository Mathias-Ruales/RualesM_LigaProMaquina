using Microsoft.AspNetCore.Mvc;
using RualesM_LigaPro.Models;
using RualesM_LigaPro.Repo;

namespace RualesM_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepo equipoRepo = new EquipoRepo();
            var equipos = equipoRepo.DevuelveListadoEquipos();
            return View(equipos);
        }

        public IActionResult Edit(int Id)
        {
            EquipoRepo repository = new EquipoRepo();
            var equipo = repository.DevolverInfoEquipo(Id);
            return View(equipo);        
        }
    }
}
