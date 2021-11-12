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
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            LoginController loginController = new LoginController();
            Usuario usuario = loginController.Login(txbUsuario.Text, txbPassword.Text);
            if (usuario!=null)
            {
                switch (usuario.Rol)
                {
                    case "direccion":
                        MessageBox.Show(
                            "Bienvenido. Direccion\n" +
                            " Te has registrado correctamente.\n" +
                            " Lo lamentamos esta zona está en construcción.", 
                            "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        break;
                    case "administrativo":
                        
                        ViewAdministrativo viewAdministrativo = new ViewAdministrativo();
                        viewAdministrativo.Show();
                        this.Hide();
                  
                        break;
                    case "administrador":
                        MessageBox.Show(
                            "Bienvenido Admin.\n" +
                            " Te has registrado correctamente.\n" +
                            " Lo lamentamos esta zona está en construcción.", 
                            "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        break;
                    case "personalsanitario":
                        
                        ViewSanitario viewSanitario = new ViewSanitario();
                        viewSanitario.Show();
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
