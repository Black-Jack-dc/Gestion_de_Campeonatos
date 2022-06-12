using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Campeonatos
{
    public class Equipo
    {
        public short id { get; set; }
        public string NomEquipos { get; set; } 
        public int CantParticipantes { get; set; }
        public byte Status { get; set; }

        public Equipo(short id, byte status)
        {
            this.id = id;
            Status = status;
        }

        public Equipo(short id)
        {
            this.id = id;
        }

        public Equipo(short id, string nomEquipos, int cantParticipantes)
        {
            this.id = id;
            NomEquipos = nomEquipos;
            CantParticipantes = cantParticipantes;
        }

        public Equipo(string nomEquipos, int cantParticipantes)
        {
            NomEquipos = nomEquipos;
            CantParticipantes = cantParticipantes;
        }
    }
}
