using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para Conversor.xaml
    /// </summary>
    public partial class Conversor : Page
    {
        private String formato;
        public Conversor(String formato)
        {
            this.formato = formato;
            InitializeComponent();
            List<Moneda> monedas = new List<Moneda>();
            if (formato.Equals("XML"))
            {
                monedas = readXML();
            }
            else if (formato.Equals("JSON"))
            {
                monedas = readJSON();
            }
          
            foreach (Moneda moneda in monedas)
            {
                cmbOrigen.Items.Add(moneda.Nombre);
                cmbDestino.Items.Add(moneda.Nombre);

            }
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement btn = e.Source as FrameworkElement;
            Button btnClicked = btn as Button;
            string btnContent = btnClicked.Content.ToString();
            switch(btnContent)
            {
                case "⌫":
                    if (txtOrigen.Text.Length > 0)
                    {
                        txtOrigen.Text = txtOrigen.Text.Remove(txtOrigen.Text.Length - 1);
                    }
                    break;
                case "CE":
                    txtOrigen.Text = "";
                    txtDestino.Text = "";
                    break;       
                default:
                    if (txtOrigen.Text.Length==1 && txtOrigen.Text == "0" && btnContent!=",")
                    {
                        txtOrigen.Text = "";

                    }

                    txtOrigen.Text += btnContent;
                    convertir();
                    break;
            }

        }

        private void cmbOrigen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            convertir();
        }
        private void cmbDestino_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            convertir();
        }


        public List<Moneda> readXML()
        {
            List<Moneda> monedas = new List<Moneda>();
            String URLString = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";

            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Cube")
                {

                    Moneda moneda = new Moneda();
                    moneda.Nombre = reader.GetAttribute("currency");
                    moneda.Valor = Convert.ToDouble(reader.GetAttribute("rate"), CultureInfo.InvariantCulture);

                    if (moneda.Nombre!=null && !moneda.Nombre.Equals(""))
                    {
                        monedas.Add(moneda);
                    }
                }
              
            }
            monedas.Add(new Moneda("EUR", 1));
            return monedas;
        }

        public List<Moneda> readJSON()
        {
            List<Moneda> monedas = new List<Moneda>();
            monedas.Add(new Moneda { Nombre = "USD", Valor = 1.0 });
            WebClient client = new WebClient();

            var json = client.DownloadString("http://www.floatrates.com/daily/usd.json");

            var data = JsonConvert.DeserializeObject<dynamic>(json);
            foreach (var item in data)
            {
                monedas.Add(item.Value.ToObject<Moneda>());

            }
            return monedas;
        }

        public double convertTo(String monedaOrigen, String monDestino, double cantidad)
        {

            List<Moneda> monedas = new List<Moneda>();
            if (this.formato.Equals("XML"))
            {
                monedas = readXML();
            }
            else if (this.formato.Equals("JSON"))
            {
                monedas = readJSON();
            }


            if (monedaOrigen == monDestino)
            {
                return cantidad;
            }
            else
            {
                foreach (Moneda moneda in monedas)
                {
                    if (moneda.Nombre == monedaOrigen)
                    {
                        foreach (Moneda moneda2 in monedas)
                        {
                            if (moneda2.Nombre == monDestino)
                            {
                                return (cantidad*moneda2.Valor)/moneda.Valor;
                            }
                        }
                    }
                }
            }

            return 0;
        }


        public void convertir()
        {
            double resultado = 0;
            if (cmbOrigen.SelectedItem != null && cmbDestino.SelectedItem != null)
            {
                resultado = convertTo(cmbOrigen.SelectedItem.ToString(), cmbDestino.SelectedItem.ToString(), Convert.ToDouble(txtOrigen.Text));
                txtDestino.Text = resultado.ToString("N2");

            }
        }

        
        

    }
}
