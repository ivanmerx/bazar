using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST.Entity;
using System.Collections.ObjectModel;

namespace REST.Interfaces
{
    interface IWebClient
    {
       Task<ObservableCollection<Auto>> GetCars();
    }
}
