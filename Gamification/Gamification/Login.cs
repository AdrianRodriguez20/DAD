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
    public partial class ViewLogin : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public ViewLogin()
        {
            InitializeComponent();
            toolTipEntrar.SetToolTip(btnEntrar, "Press Enter to Login");
        }

    

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String usuarioRol = usuarioController.Login(txtUsuario.Text, txtPassword.Text);

            if (usuarioRol != null && !usuarioRol.Trim().Equals(""))
            {
                switch (usuarioRol)
                {
                    case "admin":
                        GamificationApp gamificationAppAdmin = new GamificationApp("admin");
                        gamificationAppAdmin.Show();
                        this.Hide();
                        break;
                    case "teacher":
                        GamificationApp gamificationAppTeacher = new GamificationApp("teacher");
                        gamificationAppTeacher.Show();
                        this.Hide();
                        break;

                    case "student":
                        GamificationApp gamificationAppStudent = new GamificationApp("student");
                        gamificationAppStudent.Show();
                        this.Hide();

                        break;

                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

         private void ViewLogin_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
         }
    }
}
