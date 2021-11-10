using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Superheroes
{
    public partial class MainWindow : Window
    {
        List<Superheroe> listaHeroes;
        int count;
        Superheroe heroe;

        public MainWindow()
        {
            InitializeComponent();

            listaHeroes = Superheroe.GetSamples();
            heroe = new Superheroe();
            count = 0;

            MainDockPanel.DataContext = heroe;

            CargarHeroe();
        }

        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int num = Convert.ToInt32((sender as Image).Tag.ToString());

            if (num == 1 && (count + num) < listaHeroes.Count)
                count++;
            else if (num == -1 && (count + num) >= 0)
                count--;

            CargarHeroe();
        }

        private void CargarHeroe()
        {
            heroe.Nombre = listaHeroes[count].Nombre;
            heroe.Imagen = listaHeroes[count].Imagen;
            heroe.Vengador = listaHeroes[count].Vengador;
            heroe.Xmen = listaHeroes[count].Xmen;
            heroe.Heroe = listaHeroes[count].Heroe;

            ContadorTextBlock.Text = count + 1 + "/" + listaHeroes.Count;
        }
    }
}
