using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            menuLateral.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            FrameworkElement btn = e.Source as FrameworkElement;
            Button btnClicked = btn as Button;
            string btnContent = btnClicked.Content.ToString();
            switch(btnContent)
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
                    txtResultado.Text += btnContent;
                    break;
            }

            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void conversor_Click(object sender, RoutedEventArgs e)
        {
 
            Conversor conversor = new Conversor();
            conversor.Show();

        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            Timer timer = new Timer(2000);

            if (menuLateral.Visibility == Visibility.Hidden)
            {
                menuLateral.Visibility = Visibility.Visible;
                menuLateral.BeginAnimation(WidthProperty, new DoubleAnimation(200, TimeSpan.FromSeconds(0.5)));

                }
            else
            {
                menuLateral.BeginAnimation(WidthProperty, new DoubleAnimation(00, TimeSpan.FromSeconds(0.5)));
                timer.Elapsed += (s, args) =>
                {

                    timer.Stop();

                };
                menuLateral.Visibility = Visibility.Hidden;

            }

   
        }
    }
}
