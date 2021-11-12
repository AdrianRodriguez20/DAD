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
using Modelo;

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

            ViewPaciente viewPaciente = new ViewPaciente();
            viewPaciente.ShowDialog();

        }
    }
}
