using System.Windows.Controls;
using FlightSimulatorApp.Interfaces;
namespace FlightSimulatorApp.Indicators
{
    public partial class Airspeed_indicator : UserControl , IViewable
    {
        public Airspeed_indicator()
        {
            InitializeComponent();
        }
        public void view() { }
    }
}
