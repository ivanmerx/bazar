using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Entity
{
    /// <summary>
    /// Entity class mirrors web entity
    /// </summary>
    public class Auto
    {
        public string znacka { get; set; }
        public string model { get; set; }
        public int cena { get; set; }
        public string rokVyroby { get; set; }
        public int najetoKilometru { get; set; }

        public override string ToString()
        {
            return $"znacka: {znacka}, model: {model}, cena: {cena}, rokVyroby: {rokVyroby}, najetoKilometru {najetoKilometru} km";
        }
    }
}
