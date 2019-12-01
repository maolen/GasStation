using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GasStation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            waterNumber.Value = 0;
            oil80Number.Value = 0;
            oil90Number.Value = 0;
            snikersNumber.Value = 0;

        }

        private void Buy(object sender, RoutedEventArgs e)
        {
            var price = waterNumber.Value * Convert.ToInt32(waterPrice.Text)
                      + oil80Number.Value * Convert.ToInt32(oil80Price.Text)
                      + oil90Number.Value * Convert.ToInt32(oil90Price.Text)
                      + snikersNumber.Value * Convert.ToInt32(snikersPrice.Text);
            
            MessageBox.Show($"Итого: {price} тг.\nСпасибо за покупку!");
        }

    }
}
