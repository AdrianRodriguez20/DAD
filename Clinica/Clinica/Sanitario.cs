using System;
using System.Windows.Forms;

namespace Clinica
{
    public partial class ViewSanitario : Form
    {
        public ViewSanitario()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
      
      
        private void App_Load(object sender, EventArgs e)
        {
            FormBorderStyle =FormBorderStyle.None;
        }

        private void actasClínicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BuscarPS buscarPS = new BuscarPS();
            buscarPS.MdiParent = this;      
            buscarPS.Show();
        }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichaPS fichaPS = new FichaPS();
            fichaPS.MdiParent = this;
            fichaPS.Show();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Seguro que desea salir ?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdi in MdiChildren)
            {
                mdi.WindowState = FormWindowState.Minimized;
            }
        }

        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdi in MdiChildren)
            {
                mdi.WindowState = FormWindowState.Maximized;
            }
        }

        private void cerrarActivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdi in MdiChildren)
            {
                mdi.Close();
            }
        }

        private void visualizaciónEnCascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verEnVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void eXTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMDI formMDI = new FormMDI();
            formMDI.Show();
        }
    }
}
