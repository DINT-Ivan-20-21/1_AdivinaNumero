using System;
using System.Windows;

namespace _1_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroAdivinar;

        public MainWindow()
        {
            InitializeComponent();
            numeroAdivinar = GeneraNumeroAleatorio();
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int valorEntrada = int.Parse(adivinarTextBox.Text);

            if (valorEntrada > numeroAdivinar)
                resultadoTextBlock.Text = "Te has pasado";
            else if (valorEntrada < numeroAdivinar)
                resultadoTextBlock.Text = "Te has quedado corto";
            else
                resultadoTextBlock.Text = "¡Has acertado!";
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Text = "";
            adivinarTextBox.Text = "";
        }

        private int GeneraNumeroAleatorio()
        {
            Random random = new Random();
            return random.Next(0, 101);
        }
    }
}
