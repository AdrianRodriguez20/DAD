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

namespace Clinica
{
    public partial class FichaPS : Form
    {
        public FichaPS()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listViewFicha.Items.Clear();
            FichaController fichaController = new FichaController();
            List<string[]> fichas = null;

           if (txbNhc.Text != null && !txbNhc.Text.Trim().Equals(""))
            {
                fichas = fichaController.listarFichasNhc(txbNhc.Text);
            }
           if (fichas != null)
            {
                foreach (string[] paciente in fichas)
                {
                    listViewFicha.Items.Add(new ListViewItem(paciente));

                }
            }
        


        }
    }
}
