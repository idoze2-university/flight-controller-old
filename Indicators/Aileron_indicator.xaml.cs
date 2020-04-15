using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Indicators
{
    public partial class Aileron_indicator : UserControl
    {
        ViewModel db = ViewModel.getInstance();
        public Aileron_indicator()
        {
            InitializeComponent();
            DataContext = db;
        }
    }
}
