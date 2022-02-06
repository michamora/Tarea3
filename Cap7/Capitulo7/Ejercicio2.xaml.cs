using System;
using System.Collections;
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
    Hacer un programa que funcione como un
    diccionario, con palabra y definición,
    usando el Hashtable.
    */
    public partial class Ejercicio2 : Window
      {
       Hashtable tabla = new Hashtable();
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            

            tabla.Add(palabra.Text,definicion.Text);
            
                palabra.Text="";
                    definicion.Text="";
        }

        private void Ver_Click(object sender, RoutedEventArgs e)
        {
                      
            foreach(DictionaryEntry dato in tabla)
            {
                imprimir.Items.Add(dato.Key);
                   imprimir.Items.Add(dato.Value);
            }           
        }
    }
}