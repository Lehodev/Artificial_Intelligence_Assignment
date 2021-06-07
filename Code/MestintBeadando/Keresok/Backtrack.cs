using MestintBeadando.AllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestintBeadando.Keresok
{
    class BackTrack : Kereso
    {
        public BackTrack()
        {
            Kereses();

            
        }
        public override void Kereses()
        {
            Stack<Csomopont> ut = new Stack<Csomopont>();
            ut.Push(new Csomopont(new Allapot(), 0));

            int szamlalo = 0;

            while (ut.Count > 0 && ut.Peek().Allapot.Celfeltetel() == false)
            {
                Csomopont aktualisCsomopont = ut.Peek();

                if (aktualisCsomopont.OperatorIndex < Operatorok.Count)
                {
                    Operator aktualisOperator = Operatorok[aktualisCsomopont.OperatorIndex];

                    if (aktualisOperator.Elofeltetel(aktualisCsomopont.Allapot))
                    {
                        Allapot ujAllapot = aktualisOperator.HuszarAthelyezes(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);
                        if (ut.Contains(ujCsomopont) == false)
                        {
                            ut.Push(ujCsomopont);
                        }
                    }
                    aktualisCsomopont.OperatorIndex++;

                }

                else
                {
                    szamlalo++;
                    ut.Pop();
                }
            }

            if (ut.Count > 0)
            {
                foreach (Csomopont csomopont in ut)
                {
                    Utvonal.Add(csomopont.Allapot);
                }
                Utvonal.Reverse();
            }
        }

    }
}