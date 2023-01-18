using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public abstract class Vehiculo //clase base vehiculo, de esta heredan camion y remolque
    {
        public Vehiculo(string origen) 
        {
            Origen= origen;
        }
        public string Origen { get; set; } //propiedad

        public virtual string Imprimir()
        {
            return "Origen" + Origen;
        }

        //polimorfismo
        public abstract string Frenar();
        public abstract string Acelerar();
       

    }
}
