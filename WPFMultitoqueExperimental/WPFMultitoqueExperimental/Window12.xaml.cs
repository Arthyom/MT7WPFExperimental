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
    /// Interaction logic for Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        Dictionary<TouchDevice, Line> Dibujo = new Dictionary<TouchDevice, Line>();
        Dictionary<TouchDevice, TouchPointCollection> ConjuntoPuntos  = new Dictionary<TouchDevice, TouchPointCollection>();

        Point PuntoActual = new Point();
        TouchPoint PuntoToqueActual;
        Brush ColorPluma;

        public Window12()
        {
            InitializeComponent();
            this.DefinirColor();
        }

        // definir metodo de precionado 
        void RatonPrecionado_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // verificar si esta precionado el raton 
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.PuntoActual = e.GetPosition(CanvasDibujo);
                CanvasDibujo.Cursor = Cursors.Cross;
                DefinirColor();
            }
        }

        void RatonMoviendo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line lin = new Line();
                lin.StrokeThickness = GrosorSliderGrosor.Value;
                lin.Stroke = this.ColorPluma;

                lin.X1 = this.PuntoActual.X;
                lin.Y1 = this.PuntoActual.Y;

                Point PuntoMov = e.GetPosition(CanvasDibujo);

                lin.X2 = PuntoMov.X;
                lin.Y2 = PuntoMov.Y;

                this.PuntoActual = e.GetPosition(CanvasDibujo);

                CanvasDibujo.Children.Add(lin);

            }
        }

        private void ArchivoBorrar_Click(object sender, RoutedEventArgs e)
        {
            CanvasDibujo.Children.Clear();
        }

        void DefinirColor()
        {
            if (rdA.IsChecked == true)
                this.ColorPluma = Brushes.Yellow;
            else
            {
                if (rdN.IsChecked == true)
                    this.ColorPluma = Brushes.Red;
                else
                    if (rdR.IsChecked == true)
                    this.ColorPluma = Brushes.Red;
                else
                    if (rdV.IsChecked == true)
                    this.ColorPluma = Brushes.Green;
            }

        }

        void Salir(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Res = MessageBox.Show("wpf", "Desea Salir", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (Res == MessageBoxResult.Yes)
                this.Close();

        }

        protected override void OnTouchDown(TouchEventArgs e)
        {
            base.OnTouchDown(e);
            // capturar el evento de toque para el evento indicado 
            this.CanvasDibujo.CaptureTouch(e.TouchDevice);

            Random R = new Random();

            // crear una nueva linea 
            Line LineToque = new Line();
            LineToque.StrokeThickness = R.Next(5);
            LineToque.Stroke = new SolidColorBrush(Color.FromRgb(Convert.ToByte(R.Next(255)), Convert.ToByte(R.Next(255)), Convert.ToByte(R.Next(255))));

            // conseguir el punto de toque 
            this.PuntoToqueActual = e.GetTouchPoint(this.CanvasDibujo);


            // agregar el punto de toque a la coleccion de puntos 
          // this.CanvasDibujo.

            // agregar la linea al diccionario 
            this.Dibujo[e.TouchDevice] = LineToque;
            


        }



        // sobreescribir el metodo touchmove
        protected override void OnTouchMove(TouchEventArgs e)
        {
            base.OnTouchMove(e);
            try
            {
                // ver si se ha tocad el canvas 
                if (e.TouchDevice.Captured == this.CanvasDibujo)
                {
                    Line LineToque = this.Dibujo[e.TouchDevice];
                   

                    // agregar coordenas del punto de toque actual a la linea  
                    LineToque.X1 = PuntoToqueActual.Position.X;
                    LineToque.Y1 = PuntoToqueActual.Position.Y;

                    LineToque.X2 = e.GetTouchPoint(this.CanvasDibujo).Position.X;
                    LineToque.Y2 = e.GetTouchPoint(this.CanvasDibujo).Position.Y;

                    // convertir el punto actual 
                    this.PuntoToqueActual = e.GetTouchPoint(this.CanvasDibujo);

                    //agregar al canvas de dibujo 
                    this.CanvasDibujo.Children.Add(LineToque);
                }

            }
            catch(Exception exp)
            {
                int i = 0;
            }

            
        }

  
    }
}
