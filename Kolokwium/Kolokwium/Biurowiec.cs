using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Biurowiec: ProjektDomu
    {
        public void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(kolor);
        }

        public override string ToString()
        {
            return "Biurowiec: "+ToString();
        }  

        public void ZamontujDrzwi(string rodzajDrzwi)
        {
            ZamontujDrzwi("Szklane");
        }

    }
}
