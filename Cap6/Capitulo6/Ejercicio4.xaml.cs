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

namespace Cap6.Capitulo6
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*
    Modificar el programa de la escuela para
    que utilice funciones
    */
    public partial class Ejercicio4 : Window
      {
        public static int Cantidad=3;     int[] calificaciones = new int[Cantidad];
        private int indice = 0;
        public Ejercicio4()
        {
            InitializeComponent();
        }

         private void agregar_Click(object sender, RoutedEventArgs e)
        {
            Agregar();
        }

       private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            Calcular();
        }

         private void Agregar()
        {
              int cali =int.Parse(Calificacion.Text);
            

            if(indice < Cantidad)
            {
                calificaciones[indice] = cali;
                Calificacion.Text = " ";
                indice = indice + 1;
            }
            else
            {
                MessageBox.Show("Limite de calificaciones alcanzadas");
            }

        }
        private void Calcular()
        {
               float suma = 0;
               float promedio= 0;                                                 
               int mayor = 0;
               int menor = 0;
           
            int i;
            for(i=0; i < calificaciones.Length; i++)
            {

             suma += calificaciones[i];
             mayor = calificaciones.Max();
             menor = calificaciones.Min();
                 
            }
            
             promedio = suma / i;
             imprimir.Items.Add("Calificacion mayor: "+ mayor);
             imprimir.Items.Add("Calificacion menor: "+ menor);
             imprimir.Items.Add("Promedio: "+ promedio);
        
        }
    }
}