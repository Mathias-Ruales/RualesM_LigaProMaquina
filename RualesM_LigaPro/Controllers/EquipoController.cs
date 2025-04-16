﻿    using Microsoft.AspNetCore.Mvc;
    using RualesM_LigaPro.Models;
    using RualesM_LigaPro.Repo;

    namespace RualesM_LigaPro.Controllers
    {
        public class EquipoController : Controller
       

        {
            EquipoRepo repo = new EquipoRepo();
             public IActionResult ListaEquipos()
            {
                var equipos = repo.DevuelveListadoEquipos();
                return View(equipos);
            }

            public IActionResult Edit(int Id)
            {
                var equipo = repo.DevolverInfoEquipo(Id);
                return View(equipo);        
            }

        
        
        [HttpPost]
        public IActionResult Edit(Equipo equipo)
        {
                bool guardarCambios = repo.ActualizarEquipo(equipo);
                return RedirectToAction("ListaEquipos");

        }

    }
}
