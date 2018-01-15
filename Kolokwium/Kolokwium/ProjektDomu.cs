using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class ProjektDomu
    {
        public Dom dom;

        public void NowyDom()
        {
            Dom dom = new Dom();
        }

        public void PomalujElewacje()
        {}

        virtual public void ZamontujDrzwi(string drzwi)
        {
            dom.ZamontujDrzwi(drzwi);
        }

        new virtual public string ToString()
        {
            return dom.ToString();
        }

        virtual public void WstawOkna(string RodzajOkien)
        {
            dom.WstawOkna(RodzajOkien);
        }
    }
}
