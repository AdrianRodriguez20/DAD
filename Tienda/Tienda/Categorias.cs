using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;


namespace Tienda
{
    public partial class ViewCategorias : Form
    {
        CategoriaController categoriaController = new CategoriaController();


        public ViewCategorias()
        {
         
            InitializeComponent();
          
        }

    

        private void ViewCategorias_Load(object sender, EventArgs e)
        {
            
            for(int i =0;  i < categoriaController.listarCategorias().Count; i++)
            {
                Button btn = new Button();
                btn.Text= categoriaController.listarCategorias()[i];
                btn.Margin = new Padding(4, 3, 4, 3);
                btn.BackColor = Color.Black;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Roboto Bk", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                btn.Location = new Point(30, 30 + i * 60);
                btn.Size = new Size(125, 54);
                Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
            }
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            if (btn.Text == "Man")
            {
                ManView manView = new ManView();
                manView.Show();
                Hide();
            }

        }
    }
}