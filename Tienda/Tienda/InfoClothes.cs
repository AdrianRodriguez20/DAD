using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class InfoClothes : Form
    {
        public InfoClothes(string id , string name ,string category , string quantity)
        {
            InitializeComponent();
            this.infoClothe.Controls.Find("lblId", true)[0].Text =id;
            this.infoClothe.Controls.Find("lblName", true)[0].Text = name;
            this.infoClothe.Controls.Find("lblCategory", true)[0].Text = category;
            this.infoClothe.Controls.Find("lblQuantity", true)[0].Text = quantity;
        }

        private void InfoClothes_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
