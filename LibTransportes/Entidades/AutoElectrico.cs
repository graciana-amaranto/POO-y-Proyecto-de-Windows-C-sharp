using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    
    public class AutoElectrico : Vehiculo //herencia: autoelectrico hereda de vehiculo
    {
        public AutoElectrico(string origen, string marca, int velocidadmaxima) : base(origen) //constructor
        {
            Marca = marca;
            VelocidadMaxima= velocidadmaxima;
        }
        public string Marca { get; set; } //propiedades
        public int VelocidadMaxima {get; set; }

        //polimorfismo: el metodo acelerar funciona diferente en camion y auto electrico.
        public override string Acelerar()
        {
            return "Acelera rapido";
        }

        public override string Frenar()
        {
            return "Frena muy rapido";
        }
        public override string Imprimir()
        {
            return "Marca: " + Marca + " Velocidad maxima: " + VelocidadMaxima;
        }
    }
}
