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
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        /// <summary>
        /// Método para crear un hijo de tipo Form
        /// </summary>

        private void crearHijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (elPadreToolStripMenuItem.DropDownItems.Count>2)
            {
                ToolStripMenuItem lastElement = (ToolStripMenuItem)elPadreToolStripMenuItem.DropDownItems[elPadreToolStripMenuItem.DropDownItems.Count-1];
                 num = Convert.ToInt32(lastElement.Text.Split('_')[1]) + 1;
            }
            else
            {
                num = elPadreToolStripMenuItem.DropDownItems.Count - 1;
            }

            Form hijo = new Form();
            hijo.Text = "Hijo_" + num;
            hijo.SetBounds(10, 10, 200, 200);
            hijo.Name = "Hijo_" + num;
            hijo.MdiParent = this;
            hijo.Show();

            ToolStripMenuItem hijoItem = (ToolStripMenuItem)elPadreToolStripMenuItem.DropDownItems.Add(hijo.Name);
            hijoItem.CheckOnClick = true;

        }
        
        /// <summary>
        /// Método para cerar un hijo de tipo Form
        /// </summary>

        private void cerrarHijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuNuevo = new ToolStripMenuItem();
            foreach (ToolStripMenuItem item in elPadreToolStripMenuItem.DropDownItems)
            {
                if (!item.Checked)
                {
                    menuNuevo.DropDownItems.Add(item.Text);
                    Console.WriteLine("Añadir ANTES " + item.Text);
                }
                else
                {
                    foreach (Form mdi in MdiChildren)
                    {
                        if (item.Text.Equals(mdi.Text))
                        {
 
                                mdi.Close();
 

                        }
                    }
                  
                }


            }

            elPadreToolStripMenuItem.DropDownItems.Clear();

            foreach (ToolStripMenuItem item in  menuNuevo.DropDownItems)
            {
                elPadreToolStripMenuItem.DropDownItems.Add(item.Text);
            }

            ToolStripMenuItem crear = (ToolStripMenuItem)elPadreToolStripMenuItem.DropDownItems[0];
            crear.Click += new EventHandler(this.crearHijoToolStripMenuItem_Click);

            ToolStripMenuItem borrar = (ToolStripMenuItem)elPadreToolStripMenuItem.DropDownItems[1];
            borrar.Click += new EventHandler(this.cerrarHijoToolStripMenuItem_Click);

            for (int i = 2; i <= elPadreToolStripMenuItem.DropDownItems.Count-1; i++)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)elPadreToolStripMenuItem.DropDownItems[i];
                item.CheckOnClick = true;
            }
        }




    }
}


    

