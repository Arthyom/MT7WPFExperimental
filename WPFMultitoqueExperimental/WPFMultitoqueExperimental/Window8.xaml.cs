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
using System.Windows.Ink;

namespace WPFMultitoqueExperimental
{
    /// <summary>
    /// Interaction logic for Window8.xaml
    /// </summary>
    /// 
    

    public partial class Window8 : Window
    {
        Point P1, P2;

        public Window8()
        {
            InitializeComponent();
        }

        // cambiar el puntero cuando pase sobre el canvas de dibujo 
        private void SobreCanvas ( object sender, MouseEventArgs e)
        {
            area.Cursor = Cursors.Cross;
        }

        // generar un punto cuando el raton se precione
        private void Precionar (object sender, MouseButtonEventArgs e)
        {
            this.P1 = e.GetPosition(area);

        }

        // conseguir el punto de soltura 
        private void Soltar (object sender, MouseButtonEventArgs e)
        {
            this.P2 = e.GetPosition(area);

            // dibujar una linea recta entre los dos puntos 
            Line l1 = new Line();
            l1.X1 = this.P1.X;
            l1.Y1 = this.P1.Y;

            l1.X2 = this.P2.X;
            l1.Y2 = this.P2.Y;

            l1.Stroke = Brushes.Black;
            l1.StrokeThickness = 2;

            area.Children.Add(l1);
        }

        // cambiar color aleatoriamente al stroke
        private void CambiarColor ( object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("cambiando color");
            Random rn = new Random();

            // usar las propiedades de dibujo para crear un color nuevo
            DrawingAttributes AtributosDibujo = new DrawingAttributes();
            AtributosDibujo.Color = Color.FromRgb(Convert.ToByte( rn.Next(255)) ,Convert.ToByte( rn.Next(255) ), Convert.ToByte( rn.Next(255)) );
            area.DefaultDrawingAttributes = AtributosDibujo;
            
            
        }


    }
}
