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
    public partial class BasketView : Form
    {
        private BasketController basketController;
        private int id;
        public BasketView(int id)
        {
            InitializeComponent();
            loadData();
            this.id = id;
        }
        
        private void loadData()
        {
            basketController = new BasketController();
            dataGridViewBasket.DataSource = basketController.loadDataDA();
            dataGridViewBasket.Update(); 
            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txbCantidad.Text);
            Console.WriteLine(id);
            bool guardado = basketController.insertBasket(id, cantidad);
            
            
            if (guardado)
            {
                MessageBox.Show("Producto agregado");
                loadData();
            }
            else
            {
                MessageBox.Show("No quedan tantas existencias del producto");
            }

        }
    }
}
