using System.Windows.Controls;
using WpfApp1.Interfaces;
namespace WpfApp1.Indicators
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
