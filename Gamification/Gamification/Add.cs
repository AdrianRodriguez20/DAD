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
    public partial class AddView : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public AddView()
        {
            InitializeComponent();
        }

        /*
         * Metodo para crear un usuario
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String confirmation = txtConfirmation.Text;
            String role = comboBoxRole.Text;

            if (username != null && !username.Trim().Equals("")
                     && password != null && !password.Trim().Equals("")
                    && confirmation != null && !confirmation.Trim().Equals("")
                       && role != null && !role.Trim().Equals("")
                )
               {

                if (!password.Equals(confirmation) )
                {
                    MessageBox.Show(
                               "Por Favor , compruebe que las contraseñas coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }else if (password.Length < 8)
                {
                    MessageBox.Show("La contraseña es menor de 8 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                 bool exito=   usuarioController.crearUsuario(username, password, confirmation, role);
                    if (exito)
                    {
                        this.Close();
                        MessageBox.Show("Se ha creado Correctamente", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
               
            }
            else
            {

                MessageBox.Show(
                            "Por Favor , rellene todos los campos","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
