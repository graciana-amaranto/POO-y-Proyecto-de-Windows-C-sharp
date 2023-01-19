using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Remolque
    {
        public Remolque(int id, string capacidadMinima) { 
        
            Id = id;
            CapacidadMinima= capacidadMinima;

        
        }

        public int Id { get; set; }
        public string CapacidadMinima { get; set; }
    }
}
