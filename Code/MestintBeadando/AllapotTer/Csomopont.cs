using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestintBeadando.AllapotTer
{
    class Csomopont
    {
        Allapot allapot = new Allapot();
        Csomopont szulo;
        int koltseg;
        int operatorIndex;
        int heurisztika;
        int osszkoltseg;

        internal Allapot Allapot { get => allapot; set => allapot = value; }
        internal Csomopont Szulo { get => szulo; set => szulo = value; }
        public int Koltseg { get => koltseg; set => koltseg = value; }
        public int OperatorIndex { get => operatorIndex; set => operatorIndex = value; }
        public int Heurisztika { get => heurisztika; set => heurisztika = value; }
        public int Osszkoltseg { get => osszkoltseg; set => osszkoltseg = value; }


        public Csomopont(Allapot allapot, int operatorIndex)
        {
            this.allapot = allapot;
            this.operatorIndex = operatorIndex;
        }


        public Csomopont(Allapot allapot, Csomopont szulo)
        {
            this.allapot = allapot;
            this.szulo = szulo;

            if (szulo == null)
            {
                koltseg = 0;
            }
            else
            {
                koltseg = 0;
            }

            this.heurisztika = 0;
        }
        // Egyenlőségvizsgálat 
        public override bool Equals(object obj)
        {
            Csomopont vizsgalandoCsomopont = (Csomopont)obj;
            return this.allapot.Equals(vizsgalandoCsomopont.Allapot);
        }
    }
}
