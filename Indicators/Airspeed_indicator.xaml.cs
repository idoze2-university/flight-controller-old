using System.Windows.Controls;
using WpfApp1.Interfaces;
namespace WpfApp1.Indicators
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
