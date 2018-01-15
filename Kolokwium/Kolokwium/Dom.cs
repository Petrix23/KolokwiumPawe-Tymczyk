using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    enum Kolor : byte 
    {
        Biel=1,
        Czerwony, 
        Zielony,
        Czarny
    };

    class Dom
    {
        private string drzwi;
        private Kolor kolorElewacji;
        private string okno;

        public void PomalujElewacje(Kolor kolor)
        {
            this.kolorElewacji = kolor;
        }

        public override string ToString()
        {
            return "Okna {0} " + okno + " Drzwi {1}" + drzwi + "Kolor{2}. " + kolorElewacji;
        }

        public void WstawOkna(string okno)
        {
            this.okno = okno;
        }

        public void ZamontujDrzwi(string drzwi)
        {
            this.drzwi = drzwi;
        }

    }
}
