using Controlador;
using Modelo;
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
    public partial class ViewBuscar : Form
    {
        public ViewBuscar()
        {
            InitializeComponent();
            inicializarLista();
        }

   

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void inicializarLista()
        {
            
           PacienteController pacienteController = new PacienteController();

           List<Paciente> pacientes = pacienteController.listarPacientes();

            foreach (Paciente paciente in pacientes)
            {
                listViewPacientes.Items.Add(new ListViewItem(new string[] { paciente.Nombre, paciente.Apellidos, paciente.Direccion,paciente.Direccion,paciente.Poblacion, paciente.Dni, paciente.Nhc+"" }));

            }
        }
    }
}
