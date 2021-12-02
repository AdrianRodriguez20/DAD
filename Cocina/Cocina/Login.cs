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

namespace Cocina
{
    public partial class ViewLogin : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public ViewLogin()
        {
            InitializeComponent();
        
        }

        private void Login_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Save changes");

            
           

     
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                progressBar1.Refresh();
                System.Threading.Thread.Sleep(10);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usuarioRol = usuarioController.Login(txtUsuario.Text, txtPassword.Text);

            if (usuarioRol != null && !usuarioRol.Trim().Equals(""))
            {
                switch (usuarioRol)
                {
                    case "alumno":
                        MessageBox.Show(
                            "Bienvenido. Alumno\n" +
                            " Te has registrado correctamente.\n" +
                            " Lo lamentamos esta zona está en construcción.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case "alumna":
                        MessageBox.Show(
                            "Bienvenido. Alumna\n" +
                            " Te has registrado correctamente.\n" +
                            " Lo lamentamos esta zona está en construcción.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case "profesor":

                        Receta receta = new Receta();
                        receta.Show();
                        this.Hide();

                        break;

                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
    
}
