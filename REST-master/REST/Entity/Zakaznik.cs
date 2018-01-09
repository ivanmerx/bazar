using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Entity
{
    public class Zakaznik
    {
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"jmeno: {jmeno}, prijmeni: {prijmeni}, email: {email}";
        }
    }
}
