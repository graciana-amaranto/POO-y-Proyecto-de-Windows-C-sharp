using LibTransportes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónVehiculos
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            AutoElectrico auto = new AutoElectrico("Japon", "Toyota", 300);
            Camion camion = new Camion("Italia", 600, "Arena");
            MessageBox.Show("Auto: " + auto.Imprimir());
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("Italia", 600, "Arena");
            MessageBox.Show("Camion" + camion.Imprimir());

            //Remolque remolque = new Remolque();
            //MessageBox.Show(camion.QuitarRemolque(remolque));
        }
    }
}
