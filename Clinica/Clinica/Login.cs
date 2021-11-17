using System;
using System.Windows.Forms;
using Controlador;

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
            String usuarioRol = loginController.Login(txbUsuario.Text, txbPassword.Text);
            if (usuarioRol != null && !usuarioRol.Trim().Equals(""))
            {
                switch (usuarioRol)
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
