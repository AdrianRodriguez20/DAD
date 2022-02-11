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
    public partial class BuscarPS : Form
    {
        PacienteController pacienteController = new PacienteController();
        public BuscarPS()
        {
            InitializeComponent();
            InitializeTreeView();
        }
        
        /// <summary>
        /// Método para inicializar el TreeView
        /// </summary>
        private void InitializeTreeView()
        {
          
            List<string[]> pacientes = pacienteController.listarPacientes();
            buscarPacienteTreeView.BeginUpdate();
            if (pacientes != null)
            {
                    for (int i = 0; i < pacientes.Count; i++)
                    {
                        buscarPacienteTreeView.Nodes.Add(pacientes[i][0]+ " " + pacientes[i][1]);
                    
                        for (int j = 2; j < pacientes[i].Length; j++)
                        {
                            buscarPacienteTreeView.Nodes[i].Nodes.Add(pacientes[i][j]);
                        }
                    }
                
            }
            buscarPacienteTreeView.EndUpdate();

        }

    /// <summary>
    /// Método para buscar , tras hacer click el botón buscar
    /// </summary>

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            buscarPacienteTreeView.Nodes.Clear();
            buscarPacienteTreeView.BeginUpdate();

            List<string[]> pacientes = pacienteController.listarPacienteConcidencia(cmbBuscarPor.Text, txbContenido.Text);


            if (pacientes != null)
            {
                for (int i = 0; i < pacientes.Count; i++)
                {
                    buscarPacienteTreeView.Nodes.Add(pacientes[i][0] + " " + pacientes[i][1]);

                    for (int j = 2; j < pacientes[i].Length; j++)
                    {
                        buscarPacienteTreeView.Nodes[i].Nodes.Add(pacientes[i][j]);
                    }
                }

            }

            buscarPacienteTreeView.EndUpdate();
        }
        
        private void buscarPacienteTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {


        }

    }
}
