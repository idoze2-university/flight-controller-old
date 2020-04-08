using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Interfaces;
using WpfApp1.DataBase;
using System;

namespace WpfApp1.Indicators
{
    public partial class Aileron_indicator : UserControl, IViewable
    {
        public Aileron_indicator()
        {
            InitializeComponent();
        }
        public void view()
        {
        }
        public void Load(object sender, MouseEventArgs e)
        {
            Aileron_i.Text = Data.aileron_value.ToString();
        }
    }
}
