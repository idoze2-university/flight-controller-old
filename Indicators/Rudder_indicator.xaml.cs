using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Rudder_indicator : UserControl
    {
        ViewModel db;
        public Rudder_indicator()
        {
            InitializeComponent();
            db = ViewModel.getInstance();
            DataContext = db;
        }
    }
}
