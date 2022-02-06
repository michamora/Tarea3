using System;
using System.Collections.Generic;
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
using Cap7.Capitulo7;

namespace Cap7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

          
        private void Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ejer1 = new Ejercicio1();
            ejer1.Show();
        }

        private void Ejercicio2_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejer2 = new Ejercicio2();
            ejer2.Show();
        }
  
        private void Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5 ejer5 = new Ejercicio5();
            ejer5.Show();
        }
    }
}
    

