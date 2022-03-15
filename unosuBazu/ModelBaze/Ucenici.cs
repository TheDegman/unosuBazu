using System;
using System.Collections.Generic;
using System.Text;

namespace unosuBazu.ModelBaze
{
    class Ucenici
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Info
        {
            get { return $"{Ime} {Prezime}"; }
        }

    }
}
