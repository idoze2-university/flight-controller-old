using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Altitude : UserControl
    {
        ViewModel db = ViewModel.getInstance();
        public Altitude()
        {
            InitializeComponent();
            DataContext = db;
        }
    }
}
