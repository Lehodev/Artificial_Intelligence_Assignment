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
            // Segédváltozók
            int segedSor = -2;
            int segedOszlop = -2;
            for (int n = 0; n < 6; n++)
            {
                if (n == 0 || n == 2 || n == 4)
                {
                    // Ha a huszárral lépünk
                    if (mit== 0 || mit == 1 || mit == 2)
                    {
                        // Ha van L-alakban lépés azt eltároljuk
                        bool isThereValidMove = false;

                        for (int i = allapot.huszarok[mit].Sor - 2; i <= allapot.huszarok[mit].Sor + 2; i++)
                        {
                            for (int j = allapot.huszarok[mit].Oszlop - 2; j <= allapot.huszarok[mit].Oszlop + 2; j++)
                            {
                                // Ha a vizsgált állapot nem esik a játéktáblán kívülre
                                if (i >= 0 && i <= 3 && j >= 0 && j <= 3)
                                {
                                    if (i != allapot.huszarok[mit].Sor && j != allapot.huszarok[mit].Oszlop &&
                                    Math.Abs(segedSor) != Math.Abs(segedOszlop))
                                    {
                                        if (hova.Sor == i && hova.Oszlop == j)
                                        {
                                            isThereValidMove = true;
                                            break;
                                        }
                                    }
                                }
                                segedOszlop++;
                            }

                            segedSor++;
                            segedOszlop = -2;
                        }

                        // Ha nem volt L-alakban lépés
                        if (isThereValidMove == false)
                        {
                            return false;
                        }
                    }
                    else
                    {
                       
                    }
                }
                else
                {
                    // Ha a huszárral lépünk
                    if (mit == 3 || mit == 4 || mit == 5)
                    {
                        // Ha van L-alakban lépés azt eltároljuk
                        bool isThereValidMove = false;

                        for (int i = allapot.huszarok[mit].Sor - 2; i <= allapot.huszarok[mit].Sor + 2; i++)
                        {
                            for (int j = allapot.huszarok[mit].Oszlop - 2; j <= allapot.huszarok[mit].Oszlop + 2; j++)
                            {
                                // Ha a vizsgált állapot nem esik a játéktáblán kívülre
                                if (i >= 0 && i <= 3 && j >= 0 && j <= 3)
                                {
                                    if (i != allapot.huszarok[mit].Sor && j != allapot.huszarok[mit].Oszlop &&
                                    Math.Abs(segedSor) != Math.Abs(segedOszlop))
                                    {
                                        if (hova.Sor == i && hova.Oszlop == j)
                                        {
                                            isThereValidMove = true;
                                            break;
                                        }
                                    }
                                }

                                segedOszlop++;
                            }

                            segedSor++;
                            segedOszlop = -2;
                        }

                        // Ha nem volt L-alakban lépés
                        if (isThereValidMove == false)
                        {
                            return false;
                        }
                    }
                }
            }

            //Ha már foglalt a hely
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