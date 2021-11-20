using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Clinica
{
    public partial class ViewAdministrativo : Form
    {
        public ViewAdministrativo()
        {
            InitializeComponent();
        }


        private void crearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewCrear viewPaciente = new ViewCrear();
            viewPaciente.ShowDialog();

        }

        private void centroDeDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void guardarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Seguro que desea salir ?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBuscar viewBuscar = new ViewBuscar();
            viewBuscar.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEliminar viewEliminar = new ViewEliminar();
            viewEliminar.ShowDialog();
        }
    }
}
