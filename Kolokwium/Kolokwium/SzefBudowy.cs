using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class SzefBudowy
    {
        private ProjektDomu projektDomu;
        
        public void WybierzProjekt(ProjektDomu projekt)
        {
            projektDomu = projekt;
        }
        
        public void Buduj(string rodzajOkien, string rodzajDrzwi, Kolor kolor)
        {
        //    projektDomu.NowyDom();
        //    projektDomu.WstawOkna(rodzajOkien);
        //    projektDomu.PomalujElewacje();
        //    projektDomu.ZamontujDrzwi(rodzajDrzwi);
        }

        public void Buduj(string rodzajOkien, string rodzajDrzwi)
        {
            //    projektDomu.NowyDom();
            //    projektDomu.WstawOkna(rodzajOkien);
            //    projektDomu.PomalujElewacje();
            //    projektDomu.ZamontujDrzwi(rodzajDrzwi);
        }

        //public override string ToString()
        //{
        //    return projektDomu.ToString();
        //}

    }
}
