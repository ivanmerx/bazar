using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using REST.Entity;
using REST.Interfaces;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace REST.WebClient
{
    class Rest
    {
        /// <summary>
        /// Downloads persons list from web source async, parse form JSON to Person entity
        /// </summary>
        /// <returns>Persons list entity</returns>

        public async Task<ObservableCollection<Auto>> GetCars()
        {
            string url = "https://student.sps-prosek.cz/~merxbiv14/prog/";
            var client = new RestClient(url);
            var request = new RestRequest("prog.php?allcars", Method.GET);
            request.AddHeader("header", "value");

            ObservableCollection<Auto> persons = new ObservableCollection<Auto>();

            IRestResponse response = client.Execute(request);
            persons = JsonConvert.DeserializeObject<ObservableCollection<Auto>>((response.Content));
            return persons;

        }

        public async Task<string> AddOrder(Zakaznik uzivatel, Auto auto)
        {
            string url = "https://student.sps-prosek.cz/~merxbiv14/prog/";
            var client = new RestClient(url);
            var request = new RestRequest("prog.php", Method.POST);
            request.AddHeader("Content-type", "application/json");
            request.AddParameter("koupit", JsonConvert.SerializeObject(uzivatel));
            request.AddParameter("auto", JsonConvert.SerializeObject(auto));

            IRestResponse response = client.Execute(request);
            string persons = response.Content;
            return persons;

        }
    }
}
