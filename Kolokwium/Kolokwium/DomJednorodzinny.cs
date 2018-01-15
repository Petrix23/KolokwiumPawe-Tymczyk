using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class DomJednorodzinny: ProjektDomu
    {
        public void PomalujElewacje(Kolor kolor)
        {
            int elewacja = Convert.ToInt32("Czerwony");
            Kolor kol = (Kolor)elewacja;
            dom.PomalujElewacje(kol);
        }

        public override string ToString()
        {
            return "Dom Jednorodzinny:" +ToString();
        }


    }
}
