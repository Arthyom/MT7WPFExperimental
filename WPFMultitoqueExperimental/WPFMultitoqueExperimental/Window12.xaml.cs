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
        Point PuntoActual = new Point();

        public Window12()
        {
            InitializeComponent();
        }

        // definir metodo de precionado 
        void RatonPrecionado_MouseDown ( object sender, MouseButtonEventArgs e)
        {
            // verificar si esta precionado el raton 
            if ( e.ButtonState == MouseButtonState.Pressed)
            {
                this.PuntoActual = e.GetPosition(CanvasDibujo);
                CanvasDibujo.Cursor = Cursors.Cross;
            }
        }

        void RatonMoviendo_MouseMove ( object sender, MouseEventArgs e)
        {
            if ( e.LeftButton == MouseButtonState.Pressed)
            {
                Line lin = new Line();

                lin.Stroke = Brushes.Red;

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
    }
}
