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


namespace Tienda
{
    public partial class Login : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public Login()
        {
            InitializeComponent();

            toolTip1.SetToolTip(btnEntrar, "Save changes");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool validado = usuarioController.Login(txbUsuario.Text, txbPassword.Text);
            if (validado)
            {
                ViewCategorias viewCategoria = new ViewCategorias();
                viewCategoria.Show();
                this.Hide();
        ;
            }
            else
            {
                MessageBox.Show("Error");
                txbPassword.Text = "";
                txbUsuario.Text = "";
            }
        }
        
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }


    }
}
