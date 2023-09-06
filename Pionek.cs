using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyscigi
{
    public delegate void ZmianaPozycjiHendler();
    class Pionek
    {
        public event ZmianaPozycjiHendler zmianaPozycji;
        public int pozycjaX;
        public int pozycjaY;
        public Pionek()
        {
            PozycjaX = 20;
            PozycjaY = 100;

        }
        public int PozycjaX
        {
            get { return pozycjaX; }
            set
            {
                pozycjaX = value;
                zmianaPozycji?.Invoke();
            }
        }
        public int PozycjaY
        {
            get { return pozycjaY; }
            set
            {
                pozycjaY = value;
                zmianaPozycji?.Invoke();
            }
        }
        public void Rysuj(Graphics ctx)
        {
            ctx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //korpus
            ctx.FillRectangle(Brushes.Red, PozycjaX, PozycjaY, 25, 10);
            ctx.FillRectangle(Brushes.Red, PozycjaX, PozycjaY - 5, 3, 20);
            ctx.FillRectangle(Brushes.Black, PozycjaX + 10, PozycjaY + 3, 10, 4);
            //koła
            ctx.FillRectangle(Brushes.Black, PozycjaX + 4, PozycjaY - 5, 5, 5);
            ctx.FillRectangle(Brushes.Black, PozycjaX + 4, PozycjaY + 10, 5, 5);
            ctx.FillRectangle(Brushes.Black, PozycjaX + 20, PozycjaY - 5, 5, 5);
            ctx.FillRectangle(Brushes.Black, PozycjaX + 20, PozycjaY + 10, 5, 5);
        }
    }
}
