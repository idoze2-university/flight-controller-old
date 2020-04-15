using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Elevator_indicator : UserControl
    {
        ViewModel db = ViewModel.getInstance();
        public Elevator_indicator()
        {
            InitializeComponent();
            DataContext = db;
        }
    }
}
