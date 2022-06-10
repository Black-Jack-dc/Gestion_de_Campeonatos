using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Campeonatos
{
    public class Equipo
    {
        public string NomEquipos { get; set; } 
        public int CantParticipantes { get; set; }

        public Equipo(string nomEquipos, int cantParticipantes)
        {
            NomEquipos = nomEquipos;
            CantParticipantes = cantParticipantes;
        }
    }
}
