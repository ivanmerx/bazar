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
using REST.Entity;

namespace REST
{
    /// <summary>
    /// Interakční logika pro AddedToCart.xaml
    /// </summary>
    public partial class AddedToCart : Page
    {
        public Auto auto;
        public AddedToCart(Frame frame, Auto auto)
        {
            InitializeComponent();
            this.auto = auto;
        }

        private void daleNakupovat_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new MainWindow());
        }

        private void doKose_Click(object sender, RoutedEventArgs e)
        {
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new PaymentPage(auto));
        }
    }
}
