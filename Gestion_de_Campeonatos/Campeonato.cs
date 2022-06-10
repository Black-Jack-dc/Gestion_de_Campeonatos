using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Campeonatos
{
    public class Campeonato
    {
        public string NomCampeonato { get; set; }

        public List<Equipo> Equipo { get; set; }
        public List<Deporte> Deportes { get; set; }
        public List<Lugar> Lugares { get; set; }
    }
}
