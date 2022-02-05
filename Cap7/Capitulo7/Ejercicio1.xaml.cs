using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;


namespace Cap7.Capitulo7
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /* Hacer el programa que calcula el
    promedio, calificación máxima y mínima
    de un salón de clases usando el ArrayList
    */
    public partial class Ejercicio1 : Window
      {
    private List<float> lista = new List<float>();
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, RoutedEventArgs e)
        {
            float numero = float.Parse(CalificacionTextBox.Text);
            lista.Add(numero);
            CalificacionTextBox.Text = "";
        }



        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            float suma = 0;
            float promedio = 0;
            float mayor = 0;
            float menor = 0;

            int i;
            for (i = 0; i < lista.Count; i++)
            {
                suma += lista[i];
                mayor = lista.Max();
                menor = lista.Min();

            }

            promedio = suma / i;
            imprimir.Items.Add("Calificacion mayor es: " + mayor);
            imprimir.Items.Add("Calificacion menor es: " + menor);
            imprimir.Items.Add("El promedio es: " + promedio);

        }
    }
}