using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Controllers
{
    public partial class Aileron : UserControl
    {
        ViewModel vm = ViewModel.getInstance();
        public Aileron()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}