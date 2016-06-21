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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_display.Content = ' ';
            foreach (Control c in this.g1.Children)
            {
                if (c is Label || c is Button)
                {
                    // cambiar color de botones 
                    c.Foreground = Brushes.White;

                    // cambiar el color de fuente 
                    c.FontFamily = new FontFamily("Arial");

                    //cambiar las dimenciones de la fuente
                    c.FontSize = 12;

                    // cambiar el estilo de la fuente
                    c.FontWeight = FontWeight.FromOpenTypeWeight(22);
                }
            }       
        }

        // verificar que bonton ha sido precionado 
        private void Verificar_Clik ( object sender, RoutedEventArgs e)
        {
            Button ObjetoClik = (Button)sender;
            string CadenaDisp = lbl_display.Content.ToString();

            try
            {
                if (Convert.ToInt32(ObjetoClik.Content) >= 0 && Convert.ToInt32(ObjetoClik.Content) <= 9)
                {
                    CadenaDisp += ObjetoClik.Content.ToString();
                    lbl_display.Content = CadenaDisp;
                }
            }
            catch( Exception exp )
            {
                
                int i = 0;
            }

           
        }
    }
}
