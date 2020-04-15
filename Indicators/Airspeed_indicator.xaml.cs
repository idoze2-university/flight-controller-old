using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Airspeed_indicator : UserControl
    {
        ViewModel db = ViewModel.getInstance();
        public Airspeed_indicator()
        {
            InitializeComponent();
            DataContext = db;
        }
    }
}
