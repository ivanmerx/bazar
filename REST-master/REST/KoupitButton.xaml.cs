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
    /// Interakční logika pro KoupitButton.xaml
    /// </summary>
    public partial class KoupitButton : Page
    {
        public Frame frame;
        public Auto auto;
        public KoupitButton(Auto auto, Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
            this.auto = auto;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AddedToCart(frame, auto));
        }
    }
}
