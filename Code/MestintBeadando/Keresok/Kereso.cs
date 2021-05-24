using MestintBeadando.AllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestintBeadando.Keresok
{
    abstract class Kereso
    {
        private List<Allapot> utvonal = new List<Allapot>();
        internal List<Allapot> Utvonal { get => utvonal; set => utvonal = value; }

        private List<Operator> operatorok = new List<Operator>();
        internal List<Operator> Operatorok { get => operatorok; set => operatorok = value; }

        // Operátorok: bábuk minden lehetséges elhelyezése a játéktáblán
        private void operatorokGeneralasa()
        {
            for (int h = 0; h < Allapot.HUSZAROKSZAMA; h++) //huszárok száma
            {
                for (int s = 0; s < 3; s++) //játéktábla sorai
                {
                    for (int o = 0; o < 3; o++) //játéktábla oszlopai
                    {
                        Huszarok huszarPozicio = new Huszarok(s, o);
                        Operator ujOperator = new Operator(h, huszarPozicio);
                        operatorok.Add(ujOperator);
                    }
                }
            }
        }

        // Init
        public Kereso()
        {
            operatorokGeneralasa();
            Operatorok.Reverse();
        }

        // Keresés absztrakt metódusa
        abstract public void Kereses();

        // Útvonal kiíratása
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Allapot allapot in utvonal)
            {
                builder.Append(allapot).Append("\n");
            }
            builder.Append(utvonal.Count);
            return builder.ToString();
        }
    }
}
