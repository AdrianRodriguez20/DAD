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
    public partial class ManView : Form
    {
        private ManController manController;
        public ManView()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            manController = new ManController();
            dataGridViewMan.DataSource = manController.loadDataDA();
            dataGridViewMan.Update(); 
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewMan.CurrentRow.Cells[0].Value);
            BasketView basketView = new BasketView(id);
            basketView.Closed += (s, args) => this.loadData();
            basketView.Show();
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
          
            int id = Convert.ToInt32(dataGridViewMan.CurrentRow.Cells[0].Value);
  
            if (id!=0)
            {
                manController = new ManController();
                String[] properties = manController.findClotheProperties(id);
                if (properties!=null){
                    InfoClothes infoClothes = new InfoClothes(properties[0], properties[1], properties[2], properties[5]);
                    infoClothes.Show();
                  
                }
              
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            manController = new ManController();
            if(listBoxFilter.SelectedItem.ToString().Equals("ALL"))
            {
                dataGridViewMan.DataSource = manController.loadDataDA();
            }else if (listBoxFilter.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Seleccione una opcion");
            }
            else
            {
                Console.WriteLine("Elemento: "+listBoxFilter.SelectedItem.ToString());
                dataGridViewMan.DataSource = manController.loadDataByCategoryDA(listBoxFilter.SelectedItem.ToString());
            }

          
            dataGridViewMan.Update(); 
            
        }

        private void Man_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
