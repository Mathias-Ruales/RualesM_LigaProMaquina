using RualesM_LigaPro.Models;

namespace RualesM_LigaPro.Interfaces
{
    public interface iEquipoRepo
    {
        List<Equipo> DevuelveListadoEquipos();
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();

        Equipo DevolverInfoEquipo();
    }
}
