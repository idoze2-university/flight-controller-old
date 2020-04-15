using System;
using System.Windows.Controls;
using FlightSimulatorApp.Interfaces;
using FlightSimulatorApp.DataBase;
namespace FlightSimulatorApp.Indicators
{
    public partial class Throttle_indicator : UserControl
    {
        public Throttle_indicator()
        {
            InitializeComponent();
        }
        public void view() { }
        public void Load(object sender,EventArgs e)
        {
            Throttle_i.Text = Data.throttle_value.ToString();

        }
    }
}
