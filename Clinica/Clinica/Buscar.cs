using Controlador;
using System;
using System.Collections.Generic;
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
            listViewPacientes.Items.Clear();
            PacienteController pacienteController = new PacienteController();
            List<string[]> pacientes = null;
            if (txbDni.Text!=null && !txbDni.Text.Trim().Equals("")){
              pacientes = pacienteController.listarPacienteConcidencia("DNI", txbDni.Text);
            }
            else if (txbNhc.Text != null && !txbNhc.Text.Trim().Equals(""))
            {
              pacientes = pacienteController.listarPacienteConcidencia("NHC", txbNhc.Text);
            }
            else
            {
                pacientes = pacienteController.listarPacientes();
            }

            foreach (string[] paciente in pacientes)
            {
                listViewPacientes.Items.Add(new ListViewItem(paciente));

            }


        }

        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void inicializarLista()
        {

            PacienteController pacienteController = new PacienteController();

            List<string[]> pacientes = pacienteController.listarPacientes();
            if (pacientes != null)
            {
                foreach (string[] paciente in pacientes)
                {
                    listViewPacientes.Items.Add(new ListViewItem(paciente));

                }
            }

        }

        private void txbDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
