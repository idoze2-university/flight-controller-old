using System.Windows.Controls;
using FlightSimulatorApp.Interfaces;
namespace FlightSimulatorApp.Indicators
{
    public partial class Rudder_indicator : UserControl, IViewable
    {
        public Rudder_indicator()
        {
            InitializeComponent();
        }
        public void view() { }
    }
}
