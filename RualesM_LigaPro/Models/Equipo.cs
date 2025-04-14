﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RualesM_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName ("Nombre del equipo: ")]
        [Required]
        public string Nombre { get; set; }
        [Range(0, 100)]
        [DisplayName("Partidos Jugados: ")]
        public int partidosJugados { get; set; }
        [Range(0, 100)]
        [DisplayName("Partidos Ganados: ")]
        public int partidosGanados { get; set; }
        [Range(0, 100)]
        [DisplayName("Partidos Perdidos: ")]
        public int partidosPerdidos { get; set; }
        [Range(0, 100)]
        [DisplayName("Partidos Empatados: ")]
        public int partidosEmpatados { get; set; }

        public int Puntos { 
            get
            {
                int puntos = (partidosGanados*3) + (partidosEmpatados*1);
                return puntos;
            } 
        }

    }
}
