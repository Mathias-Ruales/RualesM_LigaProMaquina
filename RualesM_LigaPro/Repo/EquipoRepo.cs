using RualesM_LigaPro.Interfaces;
using RualesM_LigaPro.Models;

namespace RualesM_LigaPro.Repo
{
    public class EquipoRepo : iEquipoRepo
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevolverInfoEquipo()
        {
            throw new NotImplementedException();
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
                List<Equipo> equipos = new List<Equipo>();
                Equipo ldu = new Equipo
                {
                    Id = 1,
                    Nombre = "LDU",
                    partidosJugados = 10,
                    partidosGanados = 10,
                    partidosPerdidos = 0,
                    partidosEmpatados = 0
                };
                equipos.Add(ldu);

                Equipo bsc = new Equipo
                {
                    Id = 2,
                    Nombre = "BSC",
                    partidosJugados = 10,
                    partidosGanados = 1,
                    partidosPerdidos = 8,
                    partidosEmpatados = 1
                };
                equipos.Add(bsc);

                return equipos;
            }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }

}
