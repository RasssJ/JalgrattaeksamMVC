using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JalgrattaeksamMVC.Models
{
    public class LubaViewModel
    {
        public int Id { get; set; }

        public string Eesnimi { get; set; }

        public string Perenimi { get; set; }


        public int Teooria { get; set; }
        public string Slaalom { get; set; }
        public string Ring { get; set; }
        public string Tänav { get; set; }
        public string Luba { get; set; }
    }
}
