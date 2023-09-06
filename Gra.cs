using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyscigi
{
    public partial class Gra : Form
    {
        Plansza ulica;
        Pionek pionek;
        Timer ulicaTimer;
        public Gra(string predkosc,string nick)
        {
            ulica = new Plansza();
            //pozycja startowa
            for (int i = 0; i < 12; i++)
                ulica.trasaPunkty.Add(new PointF(-100 + i * 100, 100));

            for (int i = 0; i < 30; i++)
                ulica.przeszkody.Add(new PointF(100 + i * 20, 35));

            pionek = new Pionek();
            pionek.zmianaPozycji += () => Refresh();
                
            InitializeComponent();
            nickGraLabel.Text = nick;

            ulicaTimer = new Timer();
            ulicaTimer.Tick += new EventHandler(RuchUlicy);
            if(predkosc=="1")
                ulicaTimer.Interval = 100;
            if(predkosc=="2")
                ulicaTimer.Interval = 200;
            if(predkosc=="3")
                ulicaTimer.Interval = 300;
            if(predkosc=="4")
                ulicaTimer.Interval = 400;
            if(predkosc=="5")
                ulicaTimer.Interval = 500;
            if(predkosc=="6")
                ulicaTimer.Interval = 600;
            ulicaTimer.Start();
        }
        private void RuchUlicy(Object source, EventArgs myEventArgs)
        {
            //ruch planszy
            List<PointF> tmpTrasa = new List<PointF>();
            List<PointF> tmpPrzeszkody = new List<PointF>();
            
            ulica.trasaPunkty.ForEach(delegate (PointF punkt)
            {
                if (punkt.X > -100)
                    tmpTrasa.Add(new PointF(punkt.X - 10, punkt.Y));
            });
            ulica.przeszkody.ForEach(delegate (PointF punkt)
            {
                if (punkt.X > -100)
                    tmpPrzeszkody.Add(new PointF(punkt.X - 10, punkt.Y));
            });
            ulica.trasaPunkty = tmpTrasa;
            ulica.przeszkody = tmpPrzeszkody;
            //losowanie trasy
            Random rnd = new Random();
            if (ulica.trasaPunkty.ElementAt(1).X % 100 == 0)
            {
                int random = rnd.Next(60, 120);
                int minusRandom = rnd.Next(-50, 50);
                ulica.trasaPunkty.Add(new PointF(1100, random));
                ulica.przeszkody.Add(new PointF(1100, random - minusRandom));
            }
            Refresh();
        }


        private void Gra_Paint(object sender, PaintEventArgs e)
        {
            ulica.Rysuj(e.Graphics);
            pionek.Rysuj(e.Graphics);
        }

        private void Gra_KeyDown(object sender, KeyEventArgs e)
        {
            int zmiana = 5;
            if (e.KeyData == Keys.Up)
            {
                pionek.PozycjaY -= zmiana;
                List<PointF> tmpGameOverPionek = new List<PointF>();
            }
            else if (e.KeyData == Keys.Down)
            {
                pionek.PozycjaY += zmiana;
                List<PointF> tmpGameOverPionek = new List<PointF>();
            }
            else if (e.KeyData == Keys.Left)
            {
                pionek.PozycjaX -= zmiana / 2;
                List<PointF> tmpGameOverPionek = new List<PointF>();
            }
            else if (e.KeyData == Keys.Right)
            {
                pionek.PozycjaX += zmiana / 2;
                List<PointF> tmpGameOverPionek = new List<PointF>();
            }

        }
    }
}
