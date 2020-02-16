using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsmetlesNelkuliRandom
{
    class Nyeremeny
    {
        public int NyeremenySorszam;
        public string NyeremenyOsszeg;

        public Nyeremeny(string sor)
        {
            var dbok = sor.Split(';');
            this.NyeremenySorszam = int.Parse(dbok[0]);
            this.NyeremenyOsszeg = dbok[1];

        }
    }
}
