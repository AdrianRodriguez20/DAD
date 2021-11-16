using System;
using Modelo;
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
    public partial class ViewCrear : Form
    {
        public ViewCrear()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PacienteController pacienteController = new PacienteController();
            
            pacienteController.AgregarPaciente(
                txbNombre.Text, 
                txbApellidos.Text, 
                txbDireccion.Text, 
                txbCodigoPostal.Text,
                txbPoblacion.Text,
                txbDni.Text, 
                txbNhc.Text );
        }
    }
}
