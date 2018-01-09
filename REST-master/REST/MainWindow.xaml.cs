using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
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
using Newtonsoft.Json;
using RestSharp;
using REST.Entity;
using System.Timers;
using System.Windows.Threading;
using REST.Interfaces;
using REST.Tools;
using REST.WebClient;

namespace REST
{
 
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Persons list code behind collection
        /// </summary>
        private ObservableCollection<Auto> _listCollection = new ObservableCollection<Auto>();

        /// <summary>
        /// Persons list item source for UI
        /// </summary>
        public ObservableCollection<Auto> ListCollection
        {
            get { return _listCollection; }
            set { _listCollection = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
       
            ListBox.ItemsSource = ListCollection;
            GetPersonListAndPopulateAsync();
        }

      
        private async Task GetPersonListAndPopulateAsync()
       {
            await Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.IsBackground);

                Rest webClient = new Rest();
                ObservableCollection<Auto> persons = webClient.GetCars().Result;

                if (persons != null && persons.Count != 0)
                {
                    ObservableCollection<Auto> pl = new ObservableCollection<Auto>(persons);

                    this.Dispatcher.InvokeAsync(() =>
                    {
                        MessageBox.Show("OK");
                        SetPersonsItemSource(pl);
                    });
                }
                else
                {
                    this.Dispatcher.InvokeAsync(() =>
                    {
                        MessageBox.Show("Error");
                    }); 
                }
            });
       }

        /// <summary>
        /// Set persons list item source
        /// </summary>
        /// <param name="pl">Item source collection</param>
        /// 

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Auto auto = ListBox.SelectedItem as Auto;
            frame.Navigate(new KoupitButton(auto, frame));
            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }

        private void SetPersonsItemSource (ObservableCollection<Auto> pl)
        {
            _listCollection = pl;
            ListBox.ItemsSource = ListCollection;
        }

        
        private void GetData_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
