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
            Random rnd = new Random();


            // agregar etiqueta al refrigerador 
            Label etiqueta = new Label();
            etiqueta.Background = new SolidColorBrush(Color.FromArgb( Convert.ToByte( rnd.Next(250)), Convert.ToByte(rnd.Next(250)), Convert.ToByte(rnd.Next(250)), Convert.ToByte(rnd.Next(250) )));
            etiqueta.Foreground = new SolidColorBrush(Color.FromArgb(Convert.ToByte(rnd.Next(250)), Convert.ToByte(rnd.Next(250)), Convert.ToByte(rnd.Next(250)), Convert.ToByte(rnd.Next(250))));
            etiqueta.FontSize = 12;
            etiqueta.FontFamily = new FontFamily("Comic Sans");

            etiqueta.Height = rnd.Next(200);
            etiqueta.Width = rnd.Next(200);


            Canv1.Children.Add(etiqueta);

        }


    }
}
