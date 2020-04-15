using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FlightSimulatorApp.Interfaces;
using FlightSimulatorApp.DataBase;
using System;

namespace FlightSimulatorApp.Indicators
{
    public partial class Aileron_indicator : UserControl, IViewable
    {
        public Aileron_indicator()
        {
            InitializeComponent();
        }
        public void view()
        {
        }
        public void Load(object sender, MouseEventArgs e)
        {
            Aileron_i.Text = Data.aileron_value.ToString();
        }
    }
}
