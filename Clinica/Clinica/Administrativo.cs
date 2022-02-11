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
        /// <summary>
        ///  Método para abrir la ventana de registro de pacientes
        /// </summary>
        private void crearPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewCrear viewPaciente = new ViewCrear();
            viewPaciente.ShowDialog();

        }

        /// <summary>
        ///  Método para abrir la ventana Centro de dia  , en construcción
        /// </summary>

        private void centroDeDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        ///  Método para abrir la ventana Cita , en construcción
        /// </summary>

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        ///  Método para abrir la ventana Guardar Actividad  , en construcción
        /// </summary>

        private void guardarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///  Método para salir de la aplicación
        /// </summary>

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Seguro que desea salir ?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        ///  Método para abrir la ventana de buscar pacientes
        /// </summary>
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBuscar viewBuscar = new ViewBuscar();
            viewBuscar.ShowDialog();
        }
        /// <summary>
        /// Método para abrir la ventana de eliminar pacientes
        /// </summary>

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEliminar viewEliminar = new ViewEliminar();
            viewEliminar.ShowDialog();
        }
        /// <summary>
        /// Método para abrir el help 
        /// </summary>

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "../../../Documentacion/Help/Clinica Windows Form.chm");
        }
    }
}
