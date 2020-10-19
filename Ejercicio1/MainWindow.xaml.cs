﻿using System;
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

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Aleatorio;
        public MainWindow()
        {
            Aleatorio = numeroAleatorio();
            InitializeComponent();
        }

        private int numeroAleatorio()
        {
            Random random = new Random();

            return random.Next(0, 101);
        }
        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            Aleatorio = numeroAleatorio();
            resultadoTextBlock.Text = "";
            numeroTextBox.Text = "";

        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {

            if(int.Parse(numeroTextBox.Text) == Aleatorio)
            {
                resultadoTextBlock.Text = "Has acertado";
            }else if(int.Parse(numeroTextBox.Text) < Aleatorio)
            {
                resultadoTextBlock.Text = "Te has quedado corto";
            }
            else
            {
                resultadoTextBlock.Text = "Te has pasado";
            }

        }
    }
}
