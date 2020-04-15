using System.Windows.Controls;
using FlightSimulatorApp.Interfaces;
namespace FlightSimulatorApp.Indicators
{
    public partial class Ground_speed : UserControl, IViewable
    {
        public Ground_speed()
        {
            InitializeComponent();
        }
        public void view() { }
    }
}
