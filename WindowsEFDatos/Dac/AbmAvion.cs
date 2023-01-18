using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public class AbmAvion
    {
        //private static DBProductosContext context = new DBProductosContext(); //instancia de dbContext
        
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> SelectAll()
        {
            return context.Aviones.ToList();
        }

        public static int Insert(Avion avion)
        {
            context.Aviones.Add(avion);
            return context.SaveChanges(); //devuelve un int que es la cantidad de filas afectadas
        }

        public static int Update(Avion avion)
        {
            Avion avionOrigen = context.Aviones.Find(avion.AvionId);
            avionOrigen.Denominacion= avion.Denominacion;
            return context.SaveChanges();
        }
    }
}
