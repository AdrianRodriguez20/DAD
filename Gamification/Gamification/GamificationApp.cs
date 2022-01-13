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
    public partial class GamificationApp : Form
    {
        public GamificationApp(String role)
        {
            InitializeComponent();
            IsMdiContainer = true;
            if (role.Equals("teacher")){
                usersManagerToolStripMenuItem.Visible = false;
                toolStripOpciones.Visible = false;
            }

            if (role.Equals("student"))
            {
                usersManagerToolStripMenuItem.Visible = false;
                toolStripOpciones.Visible = false;
                gamificationManagentToolStripMenuItem.Visible = false;
                studentToolStripMenuItem.DropDownItems[0].Visible = false;
                studentToolStripMenuItem.DropDownItems[2].Visible = false;

            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GamificationApp_Load(object sender, EventArgs e)
        {

        }

        private void listAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView list = new ListView();
            list.MdiParent = this;
            list.Show();
        }

        private void addAUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddView add = new AddView();
            add.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ListView list = new ListView();
            list.MdiParent = this;
            list.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddView add = new AddView();
            add.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DeleteView delete = new DeleteView();
            delete.Show();
            
        }

        private void modifyAUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   ModifyView modify = new ModifyView( );
         //   modify.Show();
        }

        private void deleteAUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteView delete = new DeleteView();
            delete.Show();
        }
    }
}
