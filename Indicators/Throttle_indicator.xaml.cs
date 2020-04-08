using System;
using System.Windows.Controls;
using WpfApp1.Interfaces;
using WpfApp1.DataBase;
namespace WpfApp1.Indicators
{
    public partial class Throttle_indicator : UserControl
    {
        public Throttle_indicator()
        {
            InitializeComponent();
        }
        public void view() { }
        public void Load(object sender,EventArgs e)
        {
            Throttle_i.Text = Data.throttle_value.ToString();

        }
    }
}
