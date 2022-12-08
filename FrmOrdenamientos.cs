using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyectoEstructuradeDatos2022
{
    public partial class FrmOrdenamientos : Form
    {
        public FrmOrdenamientos()
        {
            InitializeComponent();
        }

        private void PBBurbuja_Click(object sender, EventArgs e)
        {
            Form burbuja = new FrmBurbuja();
            burbuja.Show();
        }

        private void PBSelección_Click(object sender, EventArgs e)
        {
            Form seleccion = new FrmSeleccion();
            seleccion.Show();
        }

        private void PInserción_Click(object sender, EventArgs e)
        {
            Form insercion = new FrmInsercion();
            insercion.Show();
        }

        private void PBCuentas_Click(object sender, EventArgs e)
        {
            Form cuentas = new FrmCuentas();
            cuentas.Show();
        }

        private void PBMezclas_Click(object sender, EventArgs e)
        {
            Form mezcla = new FrmMezclas();
            mezcla.Show();
        }

        private void PBArbol_Click(object sender, EventArgs e)
        {
            Form arbol = new FrmOrdenamientoABB();
            arbol.Show();
        }

        private void PBRadix_Click(object sender, EventArgs e)
        {
            Form radix = new FrmRadix();
            radix.Show();
        }

        private void PBShell_Click(object sender, EventArgs e)
        {
            Form shell = new FrmShell();
            shell.Show();
        }

        private void PBRapido_Click(object sender, EventArgs e)
        {
            Form rapido = new FrmRapido();
            rapido.Show();
        }
    }
}
