using System;
using System.Windows.Controls;
using WpfApp1.Components;
namespace WpfApp1.Controllers
{
    public partial class Throttle : UserControl
    {
        ViewModel vm = ViewModel.getInstance();
        public delegate void View();
        public Throttle()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
