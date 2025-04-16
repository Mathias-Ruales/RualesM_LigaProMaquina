using RualesM_LigaPro.Interfaces;
using RualesM_LigaPro.Models;

namespace RualesM_LigaPro.Repo
{
    public class EquipoRepo : iEquipoRepo
    {

        public List<Equipo> Equipos;
        public EquipoRepo()
        {
            Equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                partidosGanados = 10,
                partidosPerdidos = 0,
                partidosEmpatados = 5
            };
            Equipos.Add(ldu);

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                partidosGanados = 1,
                partidosPerdidos = 8,
                partidosEmpatados = 1
            };
            Equipos.Add(bsc);        
        
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            if (equipo != null)
            {
                var equipoActualizado = Equipos.Where(item => item.Id == equipo.Id).First();
                equipoActualizado.partidosGanados = equipo.partidosGanados;
                equipoActualizado.partidosPerdidos = equipo.partidosPerdidos;
                equipoActualizado.partidosEmpatados = equipo.partidosEmpatados;
                return true;
            }
            return false;
        }

        public bool CrearEquipo(Equipo equipo)
        {

            throw new NotImplementedException();
        }

        public Equipo DevolverInfoEquipo(int Id)
        {
            var equipo = Equipos.Where(item => item.Id == Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            return Equipos.OrderByDescending(item => item.Puntos).ToList();

        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }

}
