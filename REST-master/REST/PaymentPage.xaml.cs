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
using REST.WebClient;
namespace REST
{
    /// <summary>
    /// Interakční logika pro PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        public Auto auto;
        Rest webClient = new Rest();
        public PaymentPage(Auto auto)
        {
            InitializeComponent();
            this.auto = auto;
            Title.Text = "Kupujete " + auto.znacka + auto.model;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Zakaznik zakaznik = new Zakaznik();
            zakaznik.jmeno = jmeno.Text;
            zakaznik.prijmeni = prijmeni.Text;
            zakaznik.email = email.Text;
            await webClient.AddOrder(zakaznik, auto);
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Page());
        }
    }
}
