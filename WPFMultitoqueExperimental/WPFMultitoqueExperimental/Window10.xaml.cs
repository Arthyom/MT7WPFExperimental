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
    /// Interaction logic for Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        public Window10()
        {
            InitializeComponent();
        }


        // sobreescribir el meotodo touch 
        protected override void OnTouchDown(TouchEventArgs e)
        {
            base.OnTouchDown(e);
           // this.cnvsimg.ManipulationDelta += Canvas_ManipulationDelta;
            this.cnvsimg.ManipulationDelta += Canvas_ManipulationDelta2;



        }

        void Canvas_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
   
        
            MatrixTransform transform =  this.Imagen1.RenderTransform as MatrixTransform;

            if (transform != null)
            {
                // Apply any deltas to the matrix,
                // then apply the new Matrix as the MatrixTransform data:
                Matrix matrix = transform.Matrix;
                matrix.Translate(e.DeltaManipulation.Translation.X,
                e.DeltaManipulation.Translation.Y);

                matrix.RotateAt(e.DeltaManipulation.Rotation, e.ManipulationOrigin.X, e.ManipulationOrigin.Y);
                matrix.ScaleAt(e.DeltaManipulation.Scale.X, e.DeltaManipulation.Scale.Y,
                e.ManipulationOrigin.X, e.ManipulationOrigin.Y);
                transform.Matrix = matrix;
                e.Handled = true;
            }
        }

        void Canvas_ManipulationDelta2(object sender, ManipulationDeltaEventArgs e)
        {
           

            MatrixTransform transform = this.Imagen2.RenderTransform as MatrixTransform;

            if (transform != null)
            {
                // Apply any deltas to the matrix,
                // then apply the new Matrix as the MatrixTransform data:
                Matrix matrix = transform.Matrix;
                matrix.Translate(e.DeltaManipulation.Translation.X,
                e.DeltaManipulation.Translation.Y);

                matrix.RotateAt(e.DeltaManipulation.Rotation, e.ManipulationOrigin.X, e.ManipulationOrigin.Y);
                matrix.ScaleAt(e.DeltaManipulation.Scale.X, e.DeltaManipulation.Scale.Y,
                e.ManipulationOrigin.X, e.ManipulationOrigin.Y);
                transform.Matrix = matrix;
                e.Handled = true;
            }
        }


    }
}
