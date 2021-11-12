using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class ViewSanitario : Form
    {
        public ViewSanitario()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            FormBorderStyle =FormBorderStyle.None;
        }

        private void actasClínicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sacarEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarNotaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Seguro que desea salir ?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }
    }
}
