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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WPFMultitoqueExperimental
{
    /// <summary>
    /// Interaction logic for Window11.xaml
    /// </summary>
    /// 

   /* 

        crear aplicacion que simule el multitoque con el multiraton  


    */
    public partial class Window11 : Window
    {
        /* 
            una estructura que guarda cada dispositivo de raton y lo relaciona con una elpise 
        */
        Dictionary<MouseDevice, Ellipse> Seguidor = new Dictionary<MouseDevice, Ellipse>();

        Point currentPoint = new Point();



        public Window11()
        {
            

            
        }

        private void Canvas_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(CanvasTouch);
        }

        private void Canvas_MouseMove_1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(CanvasTouch).X;
                line.Y2 = e.GetPosition(CanvasTouch).Y;

                currentPoint = e.GetPosition(CanvasTouch);

                CanvasTouch.Children.Add(line);
            }
        }

        public void PrecionarRaton_MouseDown ( object sender, MouseButtonEventArgs e)
        {
            // declarar los atributos de la elipse 
            Ellipse ElipseGuia = new Ellipse();
            ElipseGuia.Fill = Brushes.Red;
            ElipseGuia.Stroke = Brushes.Green;
            ElipseGuia.Height = ElipseGuia.Width = 20;

            // conseguir el dispositivo con el que se va a interactuar
            CanvasTouch.CaptureMouse();

            // conseguir punto de toque del raton
            Point PuntoToque = e.GetPosition(CanvasTouch);

            // transformar el punto de toque en el origen para el elipse indicado
            ElipseGuia.RenderTransform = new TranslateTransform(PuntoToque.X, PuntoToque.Y);

            // agregar al hash el punto de toque 
            Seguidor[e.MouseDevice] = ElipseGuia;

            // meter al elipse en el punto de toque 
            CanvasTouch.Children.Add(ElipseGuia);

        }

        public void MoverRaton_MouseMove ( object sender, MouseEventArgs e)
        {
            // verificar que el dispositivo tocado se el canvas de dibujo
            if (e.MouseDevice.Captured == CanvasTouch)
            {
                Ellipse Seguir = this.Seguidor[e.MouseDevice];

                // mover al seguidor
                TranslateTransform Transformador = Seguir.RenderTransform as TranslateTransform;

                // trabajar con el punto de toque 
                Point PuntoToque = e.GetPosition(CanvasTouch);

                // mover al punto de toque 
                Transformador.X = PuntoToque.X;
                Transformador.Y = PuntoToque.Y;

            }
        }
    }
}
