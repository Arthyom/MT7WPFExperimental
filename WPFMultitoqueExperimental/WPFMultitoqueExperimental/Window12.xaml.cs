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
        Point PuntoActual = new Point;

        public Window12()
        {
            InitializeComponent();
        }

        // definir metodo de precionado 
        void RatonPrecionado_MouseDown ( object sender, MouseButtonEventArgs e)
        {
            // verificar si esta precionado el raton 
            if ( MouseButtonState.Pressed == e.ButtonState)
            {
                PuntoActual = e.GetPosition(CanvasDibujo);
                CanvasDibujo.Cursor = Cursors.Cross;
            }
        }
    }
}
