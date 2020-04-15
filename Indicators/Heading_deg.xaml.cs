using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Heading_deg : UserControl
    {
        ViewModel db;
        public Heading_deg()
        {
            InitializeComponent();
            db = ViewModel.getInstance();
            DataContext = db;
        }
    }
}
