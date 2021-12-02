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
        public ViewLogin()
        {
            InitializeComponent();
            toolTipEntrar.SetToolTip(btnEntrar, "Press Enter to Login");
        }

    

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hola");
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
