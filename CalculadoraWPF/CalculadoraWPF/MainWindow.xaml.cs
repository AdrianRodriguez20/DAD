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
            cambioContenedor.Navigate(new Calculadora());
            menuLateral.Width = 0;
            menuHistorial.Width = 0;
        }

    

        private void menu_Click(object sender, RoutedEventArgs e)
        {

            if (menuLateral.Width == 0)
            {
                
                DoubleAnimation animacion = new DoubleAnimation(250, TimeSpan.FromSeconds(0.5));
                menuLateral.BeginAnimation(WidthProperty,animacion);

            }
            else
            {
                DoubleAnimation animacion = new DoubleAnimation(0, TimeSpan.FromSeconds(0.5));
                menuLateral.BeginAnimation(WidthProperty, animacion);


            }

   
        }

        private void conversor_Click(object sender, RoutedEventArgs e)
        {

           
            cambioContenedor.Navigate(new Conversor());
        }

        private void calculadora_Click(object sender, RoutedEventArgs e)
        {
            cambioContenedor.Navigate(new Calculadora());
        }

        private void verHistorial(object sender, RoutedEventArgs e)
        {

            if (menuHistorial.Width == 0)
            {

                DoubleAnimation animacion = new DoubleAnimation(250, TimeSpan.FromSeconds(0.5));
                menuHistorial.BeginAnimation(WidthProperty, animacion);

            }
            else
            {
                DoubleAnimation animacion = new DoubleAnimation(0, TimeSpan.FromSeconds(0.5));
                menuHistorial.BeginAnimation(WidthProperty, animacion);

                
            }
            txtHistorial.Text = Environment.GetEnvironmentVariable("historial");
           
        }
    }
}
