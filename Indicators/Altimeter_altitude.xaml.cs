using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Altimeter_altitude : UserControl
    {
        ViewModel db = ViewModel.getInstance();
        public Altimeter_altitude()
        {
            InitializeComponent();
            DataContext = db;
        }
    }
}
