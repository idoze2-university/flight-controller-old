using System.Windows.Controls;
using WpfApp1.Interfaces;
namespace WpfApp1.Indicators
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
