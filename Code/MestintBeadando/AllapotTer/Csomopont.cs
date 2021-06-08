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

            // Célsor és céloszlop
            int[] sHuszar1 = { 0,0 };
            int[] sHuszar2 = { 0,1 };
            int[] sHuszar3 = { 0,2 };
            int[] vHuszar1 = { 2,0 };
            int[] vHuszar2 = { 2,1 };
            int[] vHuszar3 = { 2, 2 };

            this.heurisztika = 0;
            if (szulo != null && CélMezőnVanEaBábú(szulo.allapot.huszarok[0], sHuszar1[0], sHuszar1[1]))
            {
                // Ha a huszár a célmező mellett áll
                MinelKozelebbKerul(allapot.huszarok[0], sHuszar1[0], sHuszar1[1]);

                // Ha a huszárral ellépünk a célmezővel szomszédos mezőről
                if (!CelMezovelSzomszedosE(allapot.huszarok[1], sHuszar2[0], sHuszar2[1]))
                {
                    this.heurisztika -= 15;
                }
            }
            else if (szulo != null && CélMezőnVanEaBábú(szulo.allapot.huszarok[1], sHuszar2[0], sHuszar2[1]))
            {
                MinelKozelebbKerul(allapot.huszarok[1], sHuszar2[0], sHuszar2[1]);

                if (!CelMezovelSzomszedosE(allapot.huszarok[2], sHuszar3[0], sHuszar3[1]))
                {
                    this.heurisztika -= 15;
                }
            }
            else if (szulo != null && CélMezőnVanEaBábú(szulo.allapot.huszarok[2], sHuszar3[0], sHuszar3[1]))
            {
                MinelKozelebbKerul(allapot.huszarok[2], sHuszar3[0], sHuszar3[1]);

                if (!CelMezovelSzomszedosE(allapot.huszarok[3], vHuszar1[0], vHuszar1[1]))
                {
                    this.heurisztika -= 15;
                }
            }
            else if (szulo != null && CélMezőnVanEaBábú(szulo.allapot.huszarok[3], vHuszar1[0], vHuszar1[1]))
            {
                MinelKozelebbKerul(allapot.huszarok[3], vHuszar1[0], vHuszar1[1]);

                if (!CelMezovelSzomszedosE(allapot.huszarok[4], vHuszar2[0], vHuszar2[1]))
                {
                    this.heurisztika -= 15;
                }
            }
            else if (szulo != null && CélMezőnVanEaBábú(szulo.allapot.huszarok[3], vHuszar2[0], vHuszar2[1]))
            {
                MinelKozelebbKerul(allapot.huszarok[4], vHuszar2[0], vHuszar2[1]);

                if (!CelMezovelSzomszedosE(allapot.huszarok[5], vHuszar3[0], sHuszar3[1]))
                {
                    this.heurisztika -= 15;
                }
            }
            else
            {
                MinelKozelebbKerul(allapot.huszarok[5], vHuszar3[0], sHuszar3[1]);
            }

            this.osszkoltseg = this.koltseg + (-1) * this.heurisztika;
        }

        // Célmezőn van-e a bábú
        bool CélMezőnVanEaBábú(Huszarok huszar, int cS, int cO)
        {
            for (int i = cS; i <= cS; i++)
            {
                for (int j = cO; j <= cO; j++)
                {
                    if (huszar.Sor == i && huszar.Oszlop == j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Célmezővel szomszédos-e egy bábu
        bool CelMezovelSzomszedosE(Huszarok huszar, int cS, int cO)
        {
            for (int i = cS - 1; i <= cS + 1; i++)
            {
                for (int j = cO - 1; j <= cO + 1; j++)
                {
                    if (huszar.Sor == i && huszar.Oszlop == j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        // Minél közelebb kerül a huszár a célmezőhöz, annál nagyobb súlyozás
        void MinelKozelebbKerul(Huszarok h, int cS, int cO)
        {
            // Minél közelebb kerül a huszár sora a célmező sorához, annál nagyobb súly
            if (h.Sor > cS)
            {
                this.heurisztika += (7 - (h.Sor - cS));
            }
            else if (h.Sor < cS)
            {
                this.heurisztika += (7 - (cS - h.Sor));
            }
            else this.heurisztika += 7;

            // Minél közelebb kerül a huszárok oszlopa a célmező oszlopához, annál nagyobb súly
            if (h.Sor > cO)
            {
                this.heurisztika += (7 - (h.Sor - cO));
            }
            else if (h.Sor < cO)
            {
                this.heurisztika += (7 - (cO - h.Sor));
            }
            else this.heurisztika += 7;
        }

        // Egyenlőségvizsgálat 
        public override bool Equals(object obj)
        {
            Csomopont vizsgalandoCsomopont = (Csomopont)obj;
            return this.allapot.Equals(vizsgalandoCsomopont.Allapot);
        }
    }
}
