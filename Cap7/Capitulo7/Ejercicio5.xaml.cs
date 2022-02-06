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
using System.Windows.Shapes;

namespace Cap7.Capitulo7
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*
    5-Hacer un programa que funcione como
    una agenda telefónica y que guarde el
    nombre de la persona y su número telefonico.
    */  
     public partial class Ejercicio5 : Window
    {
          private List<string> NOMBRE = new List<string>();
          private List<long> TELEFONO = new List<long>();
          public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            long num=long.Parse(numero.Text);
                NOMBRE.Add(nombre.Text);
                    TELEFONO.Add(num);
                          numero.Text = " ";
                               nombre.Text = " ";
        }
         private void Ver_Click(object sender, RoutedEventArgs e)
        {
                imprimir.Items.Clear();
                for(int i=0; i <NOMBRE.Count; i++)
            {

               imprimir.Items.Add(NOMBRE[i]);
               imprimir.Items.Add(TELEFONO[i]);
                                
            }         
        }
    }
}