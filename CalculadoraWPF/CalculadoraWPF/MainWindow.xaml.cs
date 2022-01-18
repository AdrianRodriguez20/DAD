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
            cambioContenedor.Navigate(new Calculadora());
            menuLateral.Width = 0;
        }

    

        private void menu_Click(object sender, RoutedEventArgs e)
        {

            if (menuLateral.Width == 0)
            {

                menuLateral.BeginAnimation(WidthProperty, new DoubleAnimation(200, TimeSpan.FromSeconds(0.5)));

                }
            else
            {
                menuLateral.BeginAnimation(WidthProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(0.5)));


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
    }
}
