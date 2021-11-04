using System.Collections.Generic;
using System.ComponentModel;

namespace Superheroes
{

    class Superheroe : INotifyPropertyChanged
    {

        private string nombre;
        private string imagen;
        private bool vengador;
        private bool xmen;
        private bool heroe;

        public Superheroe()
        {

        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; this.NotifyPropertyChanged("Nombre"); }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; this.NotifyPropertyChanged("Imagen"); }
        }

        public bool Vengador
        {
            get { return vengador; }
            set { vengador = value; this.NotifyPropertyChanged("Vengador"); }
        }

        public bool Xmen
        {
            get { return xmen; }
            set { xmen = value; this.NotifyPropertyChanged("Xmen"); }
        }

        public bool Heroe
        {
            get { return heroe; }
            set { heroe = value; this.NotifyPropertyChanged("Heroe"); }
        }
    }
}