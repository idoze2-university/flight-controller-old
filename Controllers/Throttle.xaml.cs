using System;
using System.Windows.Controls;
using WpfApp1.Interfaces;
using WpfApp1.DataBase;
namespace WpfApp1.Controllers
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
