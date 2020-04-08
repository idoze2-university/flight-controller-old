using System.Windows.Controls;
using WpfApp1.Interfaces;
namespace WpfApp1.Indicators
{
    public partial class Altitude : UserControl, IViewable
    {
        public Altitude()
        {
            InitializeComponent();
        }
        public void view() { }
    }
}
