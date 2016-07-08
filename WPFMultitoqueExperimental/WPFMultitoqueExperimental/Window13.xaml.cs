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

            Rectangle Rect = new Rectangle();

            Rect.Fill = Brushes.Gold;
            Rect.Stroke = Brushes.Gray;
            Rect.StrokeThickness = this.Generador.Next(20);
            
            Rect.Height = this.Generador.Next(200);
            Rect.Width = this.Generador.Next(200);

            Rect.RenderTransform = new TranslateTransform(this.Generador.Next(255), this.Generador.Next(456));

            this.cnvs1.Children.Add(Rect);

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

            Ellipse elips = new Ellipse();

            elips.Fill = Brushes.HotPink;
            elips.Stroke = Brushes.Indigo;
            elips.StrokeThickness = this.Generador.Next(10);
            elips.Height = this.Generador.Next(100);
            elips.Width = this.Generador.Next(150);

            elips.RenderTransform = new TranslateTransform(this.Generador.Next(255), this.Generador.Next(456));

            this.cnvs1.Children.Add(elips);

        }

        void DibujarPoligono (object sender, RoutedEventArgs e)
        {
            Polygon Poligon = new Polygon();

            Poligon.Stroke = Brushes.NavajoWhite;
            Poligon.StrokeThickness = this.Generador.Next(10);
            Poligon.Fill = Brushes.Beige;

            int Puntos = this.Generador.Next(10);

            for( int i = 0; i < Puntos; i ++)
            {
                Point NuevoPunto = new Point(this.Generador.Next(200), this.Generador.Next(200));
                Poligon.Points.Add(NuevoPunto);
            }

            this.cnvs1.Children.Add(Poligon);
        }

        void DibujarPoly ( object sender, RoutedEventArgs e)
        {

            Polyline Poligon = new Polyline();

            Poligon.Stroke = Brushes.Black;
            Poligon.StrokeThickness = this.Generador.Next(10);
         //   Poligon.Fill = Brushes.BlueViolet;

            int Puntos = this.Generador.Next(5);

            for (int i = 0; i < Puntos; i++)
            {
                Point NuevoPunto = new Point(this.Generador.Next(200), this.Generador.Next(200));
                Poligon.Points.Add(NuevoPunto);
            }

            this.cnvs1.Children.Add(Poligon);
        }

        void DibujarGeom (object sender, RoutedEventArgs e)
        {
            EllipseGeometry elGeom1 = new EllipseGeometry(new Point(23, 23), 20, 20);
            EllipseGeometry elGeom2 = new EllipseGeometry(new Point(23, 53), 10, 43);

            CombinedGeometry Comb = new CombinedGeometry(elGeom1, elGeom2);

            Path Ruta = new Path();
            Ruta.Stroke = Brushes.Blue;
            Ruta.Fill = Brushes.Red;

            Ruta.Data = Comb;

            Ruta.RenderTransform = new TranslateTransform( this.Generador.Next(255), this.Generador.Next(255) );

            cnvs1.Children.Add(Ruta);
        }
    }
}
