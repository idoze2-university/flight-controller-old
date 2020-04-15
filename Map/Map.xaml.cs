using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Map
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : UserControl
    {
        ViewModel db;
        public Map()
        {
            InitializeComponent();
            db = ViewModel.getInstance();
            DataContext = db;
        }
    }
}
