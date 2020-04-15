using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Vertical_speed : UserControl
    {
        ViewModel db;
        public Vertical_speed()
        {
            InitializeComponent();
            db = ViewModel.getInstance();
            DataContext = db;
        }
    }
}
