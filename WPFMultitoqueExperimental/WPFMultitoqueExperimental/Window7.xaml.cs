using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFMultitoqueExperimental
{
    /// <summary>
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        // eventos de moviento de raton
        private void Seleccion_MouseInto ( object sender, MouseEventArgs e)
        {
            // cambiar el cursor 
            Canv1.Cursor = Cursors.Cross;

            

        }

        private void Click_MouseClik ( object sender, MouseButtonEventArgs e)
        {
            Random Rd = new Random();

            /// conseguir las coordernadas del clik
            Point PuntoClick = e.GetPosition(this.Ref);

            // convertir numeros
            byte a = Convert.ToByte(Rd.Next(60,255));
            byte r = Convert.ToByte(Rd.Next(255));
            byte g = Convert.ToByte(Rd.Next(255));
            byte b = Convert.ToByte(Rd.Next(255));

            // crear una etiqueta 
            Rectangle Etiqueta = new Rectangle();
            Etiqueta.RadiusX = 5;
            Etiqueta.RadiusY = 5;
            Etiqueta.Stroke = new SolidColorBrush( Color.FromArgb(a, r, g, b));
            Etiqueta.Fill = new SolidColorBrush(Color.FromArgb(a, r, g, b));
            Etiqueta.StrokeThickness = 2;
            Etiqueta.Height = Rd.Next(20,40);
            Etiqueta.Width = Rd.Next(30,70);

            // hacer la traslacion
            Etiqueta.RenderTransform = new TranslateTransform(PuntoClick.X, PuntoClick.Y);

            Canv1.Children.Add(Etiqueta);

        }


    }
}
