using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Page
    {
        public static RoutedCommand MyCommand = new RoutedCommand();
        public Calculadora()
        {
            InitializeComponent();

            MyCommand.InputGestures.Add(new KeyGesture(Key.D0, ModifierKeys.Control));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FrameworkElement btn = e.Source as FrameworkElement;
            Button btnClicked = btn as Button;
            string btnContent = btnClicked.Content.ToString();
            switch (btnContent)
            {
                case "⌫":
                    if (txtResultado.Text.Length > 0)
                    {
                        txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
                    }
                    break;
                case "+/-":
                    txtResultado.Text = (-1 * int.Parse(txtResultado.Text)).ToString();
                    break;
                case "C":
                    txtResultado.Text = "";
                    break;
                case "=":
                    try
                    {
                        String operacion = txtResultado.Text;
                        txtResultado.Text = new DataTable().Compute(txtResultado.Text, null).ToString();
                        txtUltimaOperacion.Text = operacion + " = " + txtResultado.Text;
                    }
                    catch (Exception ex)
                    {
                        txtResultado.Text = "Syntax Error";
                    }
                    break;
                default:
                    if (txtResultado.Text.Length == 1 && txtResultado.Text == "0" && btnContent != ".")
                    {
                        txtResultado.Text = "";

                    }

                    txtResultado.Text += btnContent;
                    break;
            }


        }
        

        private void txtResultado_KeyDown(object sender, KeyEventArgs e)
        {
            
           
            Console.WriteLine("Tecla"+e.Key);
 
            switch (e.Key)
            {
                case Key.D0:
                    txtResultado.Text += "0";
                    break;
                case Key.D1:
                    txtResultado.Text += "1";
                    break;
                case Key.D2:
                    txtResultado.Text += "2";
                    break;
                case Key.D3:
                    txtResultado.Text += "3";
                    break;
                case Key.D4:
                    txtResultado.Text += "4";
                    break;
                case Key.D5:
                    txtResultado.Text += "5";
                    break;
                case Key.D6:
                    txtResultado.Text += "6";
                    break;
                case Key.D7:
                    txtResultado.Text += "7";
                    break;
                case Key.D8:
                    txtResultado.Text += "8";
                    break;
                case Key.D9:
                    txtResultado.Text += "9";
                    break;
                case Key.OemMinus:
                    txtResultado.Text += "-";
                    break;
                case Key.OemPeriod:
                    txtResultado.Text += ".";
                    break;
                case Key.OemPlus:
                    txtResultado.Text += "+";
                    break;
                case Key.Divide:
                    txtResultado.Text += "/";
                    break;
                case Key.Multiply:
                    txtResultado.Text += "*";
                    break;
                case Key.NumPad0 :
                    txtResultado.Text += "0";
                    break;
                case Key.NumPad1:
                    txtResultado.Text += "1";
                    break;
                case Key.NumPad2:
                    txtResultado.Text += "2";
                    break;
                case Key.NumPad3:
                    txtResultado.Text += "3";
                    break;
                case Key.NumPad4:
                    txtResultado.Text += "4";
                    break;
                case Key.NumPad5:
                    txtResultado.Text += "5";
                    break;
                case Key.NumPad6:
                    txtResultado.Text += "6";
                    break;
                case Key.NumPad7:
                    txtResultado.Text += "7";
                    break;
                case Key.NumPad8:
                    txtResultado.Text += "8";
                    break;
                case Key.NumPad9:
                    txtResultado.Text += "9";
                    break;
    
                case Key.Back:
                    if (txtResultado.Text.Length > 0)
                    {
                        txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
                    }
                    break;
                case Key.Delete:
                    txtResultado.Text = "";
                    break;

            }

        }

        private void CalcularAtajo(object sender, ExecutedRoutedEventArgs e) {
            try
            {
                String operacion = txtResultado.Text;
                txtResultado.Text = new DataTable().Compute(txtResultado.Text, null).ToString();
                txtUltimaOperacion.Text = operacion + " = " + txtResultado.Text;
            }
            catch (Exception ex)
            {
                txtResultado.Text = "Syntax Error";
            }

        }


    }

}
