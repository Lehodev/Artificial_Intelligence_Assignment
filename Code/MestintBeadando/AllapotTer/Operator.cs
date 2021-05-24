using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestintBeadando.AllapotTer
{
    class Operator
    {
        private int mit;
        private Huszarok hova;

        public Huszarok Hova { get => hova; set => hova = value; }
        public int Mit { get => mit; set => mit = value; }

        public Operator(int mit, Huszarok hova)
        {
            this.Mit = mit;
            this.Hova = hova;
        }

        public Allapot HuszarAthelyezes(Allapot allapot)
        {
            Allapot ujAllapot = new Allapot();
            Console.WriteLine(ujAllapot.ToString());

            for (int i = 0; i < Allapot.HUSZAROKSZAMA; i++)
            {
                ujAllapot.huszarok[i] = allapot.huszarok[i];
            }

            ujAllapot.huszarok[mit] = hova;
            Console.WriteLine(ujAllapot.ToString());
            return ujAllapot;
        }
        // Előfeltétel
        public bool Elofeltetel(Allapot allapot)
        {
            for (int i = allapot.huszarok[mit].Sor - 1; i <= allapot.huszarok[mit].Sor + 1; i++)
            {
                // Oszlop
                for (int j = allapot.huszarok[mit].Oszlop - 1; j <= allapot.huszarok[mit].Oszlop + 1; j++)
                {
                    // Ha a vizsgált állapot nem esik a játéktáblán kívülre
                    if (i >= 0 && i <= 3 && j >= 0 && j <= 3)
                    {
                        // Ugyan az a sor || oszlop
                        if (i != allapot.huszarok[mit].Sor && j != allapot.huszarok[mit].Oszlop)
                        {
                            if (mit == 0|| mit == 1 || mit == 2 || mit == 3 || mit == 4 || mit == 5)
                            {
                                if (allapot.huszarok[mit].Sor + 1 < hova.Sor || allapot.huszarok[mit].Sor - 1 > hova.Sor ||
                                                   allapot.huszarok[mit].Oszlop + 1 < hova.Oszlop || allapot.huszarok[mit].Oszlop - 1 > hova.Oszlop)
                                {
                                    return false;

                                }
                                //// Ha van L-alakban lépés azt eltároljuk
                                //bool isThereValidMove = false;

                                //for (int i = allapot.huszarok[mit].Sor - 2; i <= allapot.huszarok[mit].Sor + 2; i++)
                                //{
                                //    for (int j = allapot.huszarok[mit].Oszlop - 2; j <= allapot.huszarok[mit].Oszlop + 2; j++)
                                //    {
                                //        // Ha a vizsgált állapot nem esik a játéktáblán kívülre
                                //        if (i >= 0 && i <= 3 && j >= 0 && j <= 3)
                                //        {
                                //            if (i != allapot.huszarok[mit].Sor && j != allapot.huszarok[mit].Oszlop &&
                                //            Math.Abs(segedSor) != Math.Abs(segedOszlop))
                                //            {
                                //                if (hova.Sor == i && hova.Oszlop == j)
                                //                {
                                //                    isThereValidMove = true;
                                //                    break;
                                //                }
                                //            }
                                //        }

                                //        segedOszlop++;
                                //    }

                                //    segedSor++;
                                //    segedOszlop = -2;
                                //    // Ha nem volt L-alakban lépés
                                //    if (isThereValidMove == false)
                                //    {
                                //        return false;
                                //    }
                                //}
                                //Foglalt - e a pozíció
                            }
                        }
                    }
                }
            }
            for (int b = 0; b < Allapot.HUSZAROKSZAMA; b++)
            {
                if (hova.Sor == allapot.huszarok[b].Sor && hova.Oszlop == allapot.huszarok[b].Oszlop)
                {
                    return false;
                }
            }
            return true;
        }
    }
}