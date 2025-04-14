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
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                partidosJugados = 10,
                partidosGanados = 10,
                partidosPerdidos = 0,
                partidosEmpatados = 0
            };
            return View(ldu);
        }
    }
}
