using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaktija.Model
{
    public class VaktijaVM
    {
        public string Zora {get;set;}
        public string IzlazakSunca {get;set;}
        public string Podne { get; set; }
        public string Ikindija { get; set; }
        public string Aksam { get; set; }
        public string Jacija { get; set; }
        public string Datum { get; set; }

        public string Grad {
            get {
                return Model.LokacijaVM.Grad;
            }
        }
    }
}
