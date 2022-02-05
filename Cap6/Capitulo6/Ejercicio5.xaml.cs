using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cap6.Capitulo6
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*
    Crear un programa que pase un arreglo
    como parámetro a una función
    */
    public partial class Ejercicio5 : Window
      {
        public static int Cantidad=3;        private int[] calificaciones = new int[Cantidad];
        private int indice = 0;
        public Ejercicio5()
        {
            InitializeComponent(); 
        }    
        private void agregar_Click(object sender, RoutedEventArgs e)
        {
          
            Agregar();
        }
        
        private void Agregar()
        {
            
            int cali =int.Parse(calificacion.Text);
            
            if(indice < Cantidad)
            {
                calificaciones[indice] = cali;
                  calificacion.Text = " ";
                    indice = indice + 1;
                       if(indice==Cantidad){
                          Calcular(calificaciones);
               }
                
            }
            else
            {
                MessageBox.Show("Limite de calificaciones alcanzadas");
            }
            
        }

        private void Calcular(int [] calificaciones)
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
    

