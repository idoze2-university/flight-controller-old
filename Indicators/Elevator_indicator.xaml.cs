using System.Windows.Controls;
using FlightSimulatorApp.Interfaces;
namespace FlightSimulatorApp.Indicators
{
    public partial class Elevator_indicator : UserControl, IViewable
    {
        public Elevator_indicator()
        {
            InitializeComponent();
        }
        public void view() { }
    }
}
