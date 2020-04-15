using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Ground_speed : UserControl
    {
        ViewModel db;
        public Ground_speed()
        {
            InitializeComponent();
            db = ViewModel.getInstance();
            DataContext = db;
        }
    }
}
