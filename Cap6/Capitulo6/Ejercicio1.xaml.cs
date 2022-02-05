using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cap6.Capitulo6
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*      1- Agregar el cálculo del promedio para el programa jagged.
       
            2- Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.

            3- Agregar el cálculo de la menor calificación para el programa con arreglo jagged.
    */
    public partial class Ejercicio1 : Window
      {
        public static int Cantidad=3;   private int[] calificaciones = new int[Cantidad];
        private int indice = 0;   public Ejercicio1()
        {
            InitializeComponent(); 
        }
        
        private void agregar_Click(object sender, RoutedEventArgs e)
        {
            int cali = Convert.ToInt32(Calificacion.Text);
            
            if(indice < Cantidad)
            {
                calificaciones[indice] = cali;
                Calificacion.Text = " ";
                indice = indice + 1;
            }
            else
            {
                MessageBox.Show("Limite de calificaciones alcanzandas");
            }
            
        }
        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            float suma = 0;
              float promedio = 0;                                                 
                 int mayor = 0;
                    int menor = 0;
           
            int i;
            for(i=0; i < calificaciones.Length; i++)
            {
                suma +=calificaciones[i];        
                   mayor =calificaciones.Max();
                      menor =calificaciones.Min();
                 
            }
             promedio=suma/i;
                 imprimir.Items.Add("Calificacion mayor: "+ mayor);
                    imprimir.Items.Add("Calificacion menor: "+ menor);
                       imprimir.Items.Add("Promedio: "+ promedio);
                     
        }
    }

}