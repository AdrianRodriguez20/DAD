using Controlador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinica
{
    public partial class ViewEliminar : Form
    {
        PacienteController pacienteController = new PacienteController();
        public ViewEliminar()
        {
            InitializeComponent();
            inicializarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listViewPacientes.Items.Clear();


            List<string[]> pacientes = pacienteController.listarPacienteConcidencia(cmbBuscarPor.Text ,txbContenido.Text);


            foreach (string[] paciente in pacientes)
            {
                listViewPacientes.Items.Add(new ListViewItem(paciente));

            }
        }


        public void inicializarLista()
        {
   
            List<string[]> pacientes = pacienteController.listarPacientes();
            if (pacientes != null)
            {
                foreach (string[] paciente in pacientes)
                {
                    listViewPacientes.Items.Add(new ListViewItem(paciente));

                }
            }

        }

        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //take the selected row
            ListView.SelectedListViewItemCollection items = listViewPacientes.SelectedItems;

            
            var confirmResult =  MessageBox.Show("Estás seguro que desea eliminar el paciente ??","Confirmar", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (pacienteController.eliminarPaciente(items[0].SubItems[5].Text))
                {
                    MessageBox.Show("Paciente eliminado correctamente");
                    listViewPacientes.Items.Clear();
                    inicializarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el paciente");
                }
              
            }
        }


    }
}
