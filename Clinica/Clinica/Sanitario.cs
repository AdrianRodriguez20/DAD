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
      
      /// <summary>
      /// Método para quitar el border de los controles
      /// </summary>
      private void App_Load(object sender, EventArgs e)
        {
            FormBorderStyle =FormBorderStyle.None;
        }

        private void actasClínicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
/// <summary>
/// Método para abrir la ventana de buscar pacientes
/// </summary>

        private void buscarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BuscarPS buscarPS = new BuscarPS();
            buscarPS.MdiParent = this;      
            buscarPS.Show();
        }
/// <summary>
/// Método para abrir la ventana de ver fichas
/// </summary>

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichaPS fichaPS = new FichaPS();
            fichaPS.MdiParent = this;
            fichaPS.Show();
        }

/// <summary>
/// Método para salir del programa
/// </summary>

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Seguro que desea salir ?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }
/// <summary>
/// Método para minimizar la ventana
/// </summary>


        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdi in MdiChildren)
            {
                mdi.WindowState = FormWindowState.Minimized;
            }
        }
/// <summary>
/// Método para maximizar la ventana
/// </summary>
        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdi in MdiChildren)
            {
                mdi.WindowState = FormWindowState.Maximized;
            }
        }
/// <summary>
/// Método para cerrar la ventana activa
/// </summary>
        private void cerrarActivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }
/// <summary>
/// Método para cerrar todas las ventanas
/// </summary>
        private void cerrarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdi in MdiChildren)
            {
                mdi.Close();
            }
        }
/// <summary>
/// Método para visualizar las ventanas en cascada
/// </summary>
        private void visualizaciónEnCascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
/// <summary>
/// Método para visualizar las ventanas en vertical
/// </summary>
        private void verEnVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
/// <summary>
/// Método para abrir la ventana de extra
/// </summary>
        private void eXTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMDI formMDI = new FormMDI();
            formMDI.Show();
        }
    }
}
