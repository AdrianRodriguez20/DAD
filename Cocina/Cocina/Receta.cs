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

namespace Cocina
{
    public partial class Receta : Form
    {
        RecetaController recetaController = new RecetaController();
        public Receta()
        {
            InitializeComponent();

            loadData();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            recetaController = new RecetaController();
            dataGridViewReceta.DataSource = recetaController.loadDataDA();
            dataGridViewReceta.Update();

        }

        private void Receta_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < recetaController.listarCategorias().Count; i++)
            {
                ToolStripMenuItem hijoItem = (ToolStripMenuItem)RecetasToolStripMenuItem.DropDownItems.Add(recetaController.listarCategorias()[i]);
                if (hijoItem.Text.Equals("carne"))
                {
                    hijoItem.Click += new EventHandler(this.carne_Click);
                }
                if (hijoItem.Text.Equals("pescado"))
                {
                    hijoItem.Click += new EventHandler(this.pescado_Click);
                }
            }

            ToolStripMenuItem hijoItem2 = (ToolStripMenuItem)RecetasToolStripMenuItem.DropDownItems.Add("ALL");
              hijoItem2.Click += new EventHandler(this.all_Click);
        }

        private void all_Click(object sender, EventArgs e)
        {
            recetaController = new RecetaController();
            dataGridViewReceta.DataSource = recetaController.loadDataDA();
            dataGridViewReceta.Update();
        }

        private void pescado_Click(object sender, EventArgs e)
        {
            recetaController = new RecetaController();
            dataGridViewReceta.DataSource = recetaController.loadDataByCategoryDA("pescado");
            dataGridViewReceta.Update();
        }

        private void carne_Click(object sender, EventArgs e)
        {
            recetaController = new RecetaController();
            dataGridViewReceta.DataSource = recetaController.loadDataByCategoryDA("carne");
            dataGridViewReceta.Update();
        }
    }
}
