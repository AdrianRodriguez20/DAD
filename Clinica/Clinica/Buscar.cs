using Controlador;
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
            listViewPacientes.Items.Clear();
            PacienteController pacienteController = new PacienteController();


            List<string[]> pacientes = pacienteController.listarPacienteConcidencia(txbDni.Text, txbNhc.Text);



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
    }
}
