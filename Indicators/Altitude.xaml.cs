using System.Windows.Controls;
using FlightSimulatorApp.Interfaces;
namespace FlightSimulatorApp.Indicators
{
    public partial class Altitude : UserControl, IViewable
    {
        public Altitude()
        {
            InitializeComponent();
        }
        public void view() { }
    }
}
