using System;
using System.Windows.Controls;
using FlightSimulatorApp.Interfaces;
using FlightSimulatorApp.DataBase;
namespace FlightSimulatorApp.Controllers
{
    public partial class Throttle : UserControl, IViewable
    {
        public Throttle()
        {
            InitializeComponent();
        }
        public void Controller_Drag(object sender, EventArgs e)
        {
            Data.throttle_slider_value = (Convert.ToDouble(Throttle_slider.Value.ToString()));
            view();
        }
        public void view()
        {
            Throttle_slider.Value = Data.throttle_slider_value;
        }
    }
}
