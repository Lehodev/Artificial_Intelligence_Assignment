using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestintBeadando.AllapotTer
{
    class Allapot
    {
        public static int HUSZAROKSZAMA = 6;
        public Huszarok[] huszarok = new Huszarok[HUSZAROKSZAMA];


        private Huszarok[] celMezok = new Huszarok[]
        {
            new Huszarok(0,0), // SH1 (Sötét Huszár)
            new Huszarok(0,1), // SH2
            new Huszarok(0,2), // SH3
            new Huszarok(2,0), // VH1 (Világos Huszár)
            new Huszarok(2,1), // VH2
            new Huszarok(2,2), // VH3
        };

        public Allapot()
        {
            huszarok[0] = new Huszarok(2, 0); // SH1
            huszarok[1] = new Huszarok(2, 1); // SH2
            huszarok[2] = new Huszarok(2, 2); // SH3
            huszarok[3] = new Huszarok(0, 0); // VH1
            huszarok[4] = new Huszarok(0, 1); // VH2
            huszarok[5] = new Huszarok(0, 2); // VH3
        }

        public bool Celfeltetel()
        {
            if (huszarok[0].Sor == celMezok[0].Sor && huszarok[0].Oszlop == celMezok[0].Oszlop ||
                huszarok[0].Sor == celMezok[1].Sor && huszarok[0].Oszlop == celMezok[1].Oszlop ||
                huszarok[0].Sor == celMezok[2].Sor && huszarok[0].Oszlop == celMezok[2].Oszlop)
                if (huszarok[1].Sor == celMezok[0].Sor && huszarok[1].Oszlop == celMezok[0].Oszlop ||
               huszarok[1].Sor == celMezok[1].Sor && huszarok[1].Oszlop == celMezok[1].Oszlop ||
               huszarok[1].Sor == celMezok[2].Sor && huszarok[1].Oszlop == celMezok[2].Oszlop)
                    if (huszarok[2].Sor == celMezok[2].Sor && huszarok[2].Oszlop == celMezok[2].Oszlop ||
                    huszarok[2].Sor == celMezok[1].Sor && huszarok[2].Oszlop == celMezok[1].Oszlop ||
                    huszarok[2].Sor == celMezok[0].Sor && huszarok[2].Oszlop == celMezok[0].Oszlop)
                        if (huszarok[3].Sor == celMezok[3].Sor && huszarok[3].Oszlop == celMezok[3].Oszlop ||
                     huszarok[3].Sor == celMezok[4].Sor && huszarok[3].Oszlop == celMezok[4].Oszlop ||
                     huszarok[3].Sor == celMezok[5].Sor && huszarok[3].Oszlop == celMezok[5].Oszlop)
                            if (huszarok[4].Sor == celMezok[4].Sor && huszarok[4].Oszlop == celMezok[4].Oszlop ||
                          huszarok[4].Sor == celMezok[3].Sor && huszarok[4].Oszlop == celMezok[3].Oszlop ||
                          huszarok[4].Sor == celMezok[5].Sor && huszarok[4].Oszlop == celMezok[5].Oszlop)
                                if (huszarok[5].Sor == celMezok[5].Sor && huszarok[5].Oszlop == celMezok[5].Oszlop ||
                               huszarok[5].Sor == celMezok[4].Sor && huszarok[5].Oszlop == celMezok[4].Oszlop ||
                               huszarok[5].Sor == celMezok[3].Sor && huszarok[5].Oszlop == celMezok[3].Oszlop)
                                {
                                    return true;
                                }
            return false;
        }

        public override string ToString()
        {
            string huszar;
            StringBuilder builder = new StringBuilder();
            builder.Append("(");

            for (int i = 0; i < HUSZAROKSZAMA; i++)
            {
                if (i == 0) huszar = "SH1";
                else if (i == 1) huszar = "SH2";
                else if (i == 2) huszar = "SH3";
                else if (i == 3) huszar = "VH1";
                else if (i == 4) huszar = "VH2";
                else huszar = "VH3";

                builder.Append(huszar);
                builder.Append("-s");
                builder.Append(huszarok[i].Sor);
                builder.Append("-o");
                builder.Append(huszarok[i].Oszlop);
                builder.Append("; ");

            }
            builder.Append(")");
            return builder.ToString();
        }

        public override bool Equals(object obj)
        {
            Allapot vizsgaltAllapot = (Allapot)obj;

            for (int i = 0; i < this.huszarok.Length; i++)
            {
                if (this.huszarok[i] != vizsgaltAllapot.huszarok[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}