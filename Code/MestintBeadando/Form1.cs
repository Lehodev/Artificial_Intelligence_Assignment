using MestintBeadando.AllapotTer;
using MestintBeadando.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestintBeadando
{
    public partial class Form1 : Form
    {
        List<Kereso> keresok = new List<Kereso>();
        List<Allapot> megoldasok = new List<Allapot>();
        int aktualisAllapotIndex = 0;

        public Form1()
        {
            keresok.Add(new BackTrack());
            //keresok.Add(new Melysegi());
            InitializeComponent();
            Allapot allapot = new Allapot();
            Console.WriteLine(allapot);

            foreach (Kereso kereso in keresok)
            {
                srchCB.Items.Add(kereso.GetType().Name);
            }
            srchCB.SelectedIndex = 0;
        }

        // Előző lépés
        private void button1_Click(object sender, EventArgs e)
        {
            if (aktualisAllapotIndex > 0) aktualisAllapotIndex--;
            Kirajzol();
        }

        // Kővetkező lépés
        private void button2_Click(object sender, EventArgs e)
        {
            if (megoldasok.Count - 1 > aktualisAllapotIndex) aktualisAllapotIndex++;
            Kirajzol();
        }

        // ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            megoldasok = keresok[srchCB.SelectedIndex].Utvonal;
            aktualisAllapotIndex = 0;
            Kirajzol();
        }

        // Sakktábla kirajzolása
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Kirajzol();
            // Win kép megjelentitése
            if (aktualisAllapotIndex + 1 == megoldasok.Count)
            {
                Win();
            }
            else
            {
                logPB.Image = null;
            }
        }

        // Teljesült feltétel kép:
        private void Win()
        {
            //pictureBox2.ImageLocation = "win.png";
            //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Kirajzol()
        {
            int pB_W = tablePB.Width;
            int pB_H = tablePB.Height;
            Bitmap image = new Bitmap(pB_W, pB_H);
            tablePB.Image = image;
            Graphics g = Graphics.FromImage(image);
            Color color1, color2;
            SolidBrush blackBrush, whiteBrush;

            // Sakktábla kirajzolása
            for (int i = 0; i < 3; i++)
            {
                if (i % 2 == 0)
                {
                    color1 = Color.Black;
                    color2 = Color.White;
                }
                else
                {
                    color1 = Color.White;
                    color2 = Color.Black;
                }

                blackBrush = new SolidBrush(color1);
                whiteBrush = new SolidBrush(color2);

                for (int j = 0; j < 3; j++)
                {
                    if (j % 2 == 0) g.FillRectangle(blackBrush, i * pB_W / 3, j * pB_H / 3, pB_W / 3, pB_H / 3);
                    else g.FillRectangle(whiteBrush, i * pB_W / 3, j * pB_H / 3, pB_W / 3, pB_H / 3);
                }
            }
            Huszarok[] huszarok = megoldasok[aktualisAllapotIndex].huszarok;

            Icon SotetHuszar1 = new Icon("SotetHuszar.ico");
            int sh1X = (pB_W / 3) / 3 + (pB_W / 3) * huszarok[0].Oszlop;
            int sh1Y = (pB_H / 3) / 3 + (pB_H / 3) * (1 - huszarok[0].Sor);
            Rectangle rectSotetHuszar1 = new Rectangle(sh1X - 30, sh1Y + 90, 20, 20);
            g.DrawIconUnstretched(SotetHuszar1, rectSotetHuszar1);

            Icon SotetHuszar2 = new Icon("SotetHuszar.ico");
            int sh2X = (pB_W / 3) / 3 + (pB_W / 3) * huszarok[1].Oszlop;
            int sh2Y = (pB_H / 3) / 3 + (pB_H / 3) * (1 - huszarok[1].Sor);
            Rectangle rectSotetHuszar2 = new Rectangle(sh2X - 30, sh2Y + 90, 20, 20);
            g.DrawIconUnstretched(SotetHuszar2, rectSotetHuszar2);

            Icon SotetHuszar3 = new Icon("SotetHuszar.ico");
            int sh3X = (pB_W / 3) / 3 + (pB_W / 3) * huszarok[2].Oszlop;
            int sh3Y = (pB_H / 3) / 3 + (pB_H / 3) * (1 - huszarok[2].Sor);
            Rectangle rectSotetHuszar3 = new Rectangle(sh3X - 30, sh3Y + 90, 20, 20);
            g.DrawIconUnstretched(SotetHuszar3, rectSotetHuszar3);

            Icon VilagosHuszar1 = new Icon("VilagosHuszar.ico");
            int vh1X = (pB_W / 3) / 3 + (pB_W / 3) * huszarok[3].Oszlop;
            int vh1Y = (pB_H / 3) / 3 + (pB_H / 3) * (1 - huszarok[3].Sor);
            Rectangle rectVilagosHuszar1 = new Rectangle(vh1X - 30, vh1Y + 90, 20, 20);
            g.DrawIconUnstretched(VilagosHuszar1, rectVilagosHuszar1);

            Icon VilagosHuszar2 = new Icon("VilagosHuszar.ico");
            int vh2X = (pB_W / 3) / 3 + (pB_W / 3) * huszarok[4].Oszlop;
            int vh2Y = (pB_H / 3) / 3 + (pB_H / 3) * (1 - huszarok[4].Sor);
            Rectangle rectVilagosHuszar2 = new Rectangle(vh2X - 30, vh2Y + 90, 20, 20);
            g.DrawIconUnstretched(VilagosHuszar2, rectVilagosHuszar2);

            Icon VilagosHuszar3 = new Icon("VilagosHuszar.ico");
            int vh3X = (pB_W / 3) / 3 + (pB_W / 3) * huszarok[5].Oszlop;
            int vh3Y = (pB_H / 3) / 3 + (pB_H / 3) * (1 - huszarok[5].Sor);
            Rectangle rectVilagosHuszar3 = new Rectangle(vh3X - 30, vh3Y + 90, 20, 20);
            g.DrawIconUnstretched(VilagosHuszar3, rectVilagosHuszar3);

            stepLbl.Text = "Lépések száma (kezdőállapottal): " + megoldasok.Count;
        }
    }
}
