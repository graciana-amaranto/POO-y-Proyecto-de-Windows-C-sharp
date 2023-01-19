using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{

    public class Camion : Vehiculo //herencia: camion hereda de vehiculo
    {
        public Remolque Remolque { get; set; }

        public Camion(string origen, int cargamaxima, string tipocarga) : base(origen) //constructor
        {
            CargaMaxima= cargamaxima;
            TipoCarga= tipocarga;
        }
        public int CargaMaxima { get; set; } //propiedades
        public string TipoCarga { get; set; }

        public override string Acelerar() //polimorfismo
        {
            return "Acelera lento";
        }
        public override string Frenar()
        {
            return "Frena muy lento";
        }

        public void QuitarRemolque()
        {
            this.Remolque = null;
        }

        public override string Imprimir()
        {
            return "Origen" + this.Origen + "Carga maxima: " + this.CargaMaxima + " Tipo de carga: " + this.TipoCarga;
        }
    }
}
