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

namespace Gamification
{
    public partial class DeleteView : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public DeleteView()
        {
            InitializeComponent();
        }

        private void DeleteView_Load(object sender, EventArgs e)
        {
            inicializarLista();
        }
        /*Listar usuarios en el tree
         * 
         */
        public void inicializarLista()
        {
            List<string[]> usuarios = usuarioController.listarUsuarios();
            treeViewUsuarios.BeginUpdate();
            if (usuarios != null)
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    treeViewUsuarios.Nodes.Add(usuarios[i][0]);

                    for (int j = 2; j < usuarios[i].Length; j++)
                    {
                        treeViewUsuarios.Nodes[i].Nodes.Add(usuarios[i][j]);
                    }
                }

            }
            treeViewUsuarios.EndUpdate();
        }

        private void treeViewUsuarios_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
   

        }

        public void eliminarUsuario()
        {
            var confirmResult = MessageBox.Show("Estás seguro que desea eliminar el usuario ??", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (usuarioController.eliminarUsuario(treeViewUsuarios.SelectedNode.Text))
                {
                    MessageBox.Show("Usuario eliminado correctamente");

                    inicializarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
        }
    }
}
