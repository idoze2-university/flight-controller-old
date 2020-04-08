using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Interfaces;
using WpfApp1.DataBase;
namespace WpfApp1.Controllers
{
    public partial class Joystick : UserControl, IViewable
    {
        public Joystick()
        {
            InitializeComponent();
        }
        private void KnobBase_MoveKnob(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point p = e.GetPosition(inner_Pad);
                Data.rudder = (p.X - Data.PAD_RADIUS)/Data.PAD_RADIUS;
                Data.elevator = -(p.Y - Data.PAD_RADIUS)/ Data.PAD_RADIUS;
                view();
            }
        }
        private void KnobBase_ReleaseKnob(object sender, MouseEventArgs e)
        {
            Data.rudder = 0;
            Data.elevator = 0;
            view();
        }
        public void view()
        {
            Thickness margin = KnobBase.Margin;
            margin.Left = Data.X;
            margin.Top = Data.Y;
            KnobBase.Margin = margin;
        }
    }
}
