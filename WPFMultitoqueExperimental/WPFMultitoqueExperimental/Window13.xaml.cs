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
    /// Interaction logic for Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        Random Generador = new Random();

        public Window13()
        {
            InitializeComponent();

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

        }

        void DibujarRectangulo (object sender, RoutedEventArgs e)
        {

        }

        void Borrar(object sender, RoutedEventArgs e)
        {
            this.cnvs1.Children.Clear();
        }

        void DibujarLinea (object sender, RoutedEventArgs e)
        {
            Line NuevaLinea = new Line();

            NuevaLinea.X1 = this.Generador.Next(Convert.ToInt32(255));
            NuevaLinea.Y1 = this.Generador.Next(Convert.ToInt32(300));

            NuevaLinea.X2 = this.Generador.Next(Convert.ToInt32(200));
            NuevaLinea.Y2 = this.Generador.Next(Convert.ToInt32(400));

            NuevaLinea.StrokeThickness = this.Generador.Next(10);
            NuevaLinea.Stroke = Brushes.Red;

            this.cnvs1.Children.Add(NuevaLinea);



        }

        void DibujarTriangulo (object sender, RoutedEventArgs e)
        {
            Polygon Poligon = new Polygon();

            Poligon.Fill = Brushes.Yellow;
            Poligon.Stroke = Brushes.Green;
            Poligon.StrokeThickness = this.Generador.Next(20);

            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();

            p1.X = Convert.ToInt32(this.Generador.Next(255));
            p1.Y = Convert.ToInt32(this.Generador.Next(255));

            p2.X = Convert.ToInt32(this.Generador.Next(255));
            p2.Y = Convert.ToInt32(this.Generador.Next(255));

            p3.X = Convert.ToInt32(this.Generador.Next(255));
            p3.Y = Convert.ToInt32(this.Generador.Next(255));

            Poligon.Points.Add(p1);
            Poligon.Points.Add(p2);
            Poligon.Points.Add(p3);

            this.cnvs1.Children.Add(Poligon);


        }

        void DibujarCirculo (object sender, RoutedEventArgs e)
        {

        }

    }
}
