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
    public partial class ListView : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public ListView()
        {
            InitializeComponent();
            loadData();
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.Text.Equals("admin"))
            {
                usuarioController = new UsuarioController();
                dataGridViewUsuarios.DataSource = usuarioController.loadDataByRoleDA("admin");
                dataGridViewUsuarios.Update();
            }

            if (comboBoxRole.Text.Equals("student"))
            {
                usuarioController = new UsuarioController();
                dataGridViewUsuarios.DataSource = usuarioController.loadDataByRoleDA("student");
                dataGridViewUsuarios.Update();
            }

            if (comboBoxRole.Text.Equals("teacher"))
            {
                usuarioController = new UsuarioController();
                dataGridViewUsuarios.DataSource = usuarioController.loadDataByRoleDA("teacher");
                dataGridViewUsuarios.Update();
            }

            if (comboBoxRole.Text.Equals("all"))
            {
                loadData();
            }
        }
        private void loadData()
        {
            usuarioController = new UsuarioController();
            dataGridViewUsuarios.DataSource = usuarioController.loadDataDA();
            dataGridViewUsuarios.Update();

        }
    }
}
