using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Models;
using WindowsEFDatos.Dac;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void btnAvion_Click_1(object sender, EventArgs e)
        {
            Avion avion = new Avion()
            { Capacidad = Convert.ToInt32(txtCapacidad.Text), Denominacion = txtDenominacion.Text };

            int filasAfectadas = AbmAvion.Insert(avion);
            if (filasAfectadas > 0 )
            {
                MessageBox.Show("Insert OK");
                MostrarTodosLosAviones();
            }

        }

        private void MostrarTodosLosAviones()
        {
            gridAvion.DataSource = AbmAvion.SelectAll();
        }

        private void btnEditarAvion_Click(object sender, EventArgs e)
        {
            //Avion avion = new Avion()
            //{
            //    AvionId = Convert.ToInt32(txtId.Text),
            //    Capacidad = Convert.ToInt32(txtCapacidad.Text),
            //    Denominacion = txtDenominacion.Text
            //};

            //int filasAfectadas = AbmAvion.Update(avion);
            //if (filasAfectadas > 0)
            //{
            //    MessageBox.Show("Update ok");
            //    MostrarTodosLosAviones();

            //}

        }
    }
    
}
