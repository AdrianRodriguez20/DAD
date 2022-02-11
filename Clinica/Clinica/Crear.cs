using System;
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

        /// <summary>
        /// Método para crear un nuevo paciente , tras hacer click en el botón
        /// </summary>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            PacienteController pacienteController = new PacienteController();
            
          bool exito=  pacienteController.AgregarPaciente(
                txbNombre.Text, 
                txbApellidos.Text, 
                txbDireccion.Text, 
                txbCodigoPostal.Text,
                txbPoblacion.Text,
                txbDni.Text, 
                txbNhc.Text );
          if (exito)
          {
              MessageBox.Show("Paciente creado correctamente");
              Close();
          }
          else
          {
              MessageBox.Show("Error al crear paciente");
          }
        }

        private void ViewCrear_Load(object sender, EventArgs e)
        {

        }
    }
}
