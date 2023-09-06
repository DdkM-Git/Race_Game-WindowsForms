using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;

namespace Wyscigi
{
    class Plansza
    {
        Pen trasa, brzeg, linia;
        public List<PointF> trasaPunkty { get; set; }
        public List<PointF> przeszkody { get; set; }
        public Plansza()
        {
            trasa = new Pen(Color.Gray, 140);
            brzeg = new Pen(Color.Black, 10);
            linia = new Pen(Color.AntiqueWhite, 10);
            trasaPunkty = new List<PointF>();
            przeszkody = new List<PointF>();
        }
        public void Rysuj(Graphics ctx)
        {
            ctx.SmoothingMode = SmoothingMode.AntiAlias;
            if (trasaPunkty.Count > 1)
            {
                List<PointF> brzegTopPunkty = new List<PointF>();
                List<PointF> brzegBottomPunkty = new List<PointF>();
                List<PointF> liniaTopPunkty = new List<PointF>();
                List<PointF> liniaBottomPunkty = new List<PointF>();
                trasaPunkty.ForEach(delegate (PointF punkt){
                    brzegTopPunkty.Add(new PointF(punkt.X, punkt.Y-75));
                    brzegBottomPunkty.Add(new PointF(punkt.X, punkt.Y+75));
                    liniaTopPunkty.Add(new PointF(punkt.X, punkt.Y-35));
                    liniaBottomPunkty.Add(new PointF(punkt.X, punkt.Y+35));
                });
                ctx.DrawCurve(trasa, trasaPunkty.ToArray());
                ctx.DrawCurve(brzeg, brzegTopPunkty.ToArray());
                ctx.DrawCurve(brzeg, brzegBottomPunkty.ToArray());
                ctx.DrawCurve(linia, liniaTopPunkty.ToArray());
                ctx.DrawCurve(linia, liniaBottomPunkty.ToArray());
                int i = 0;
                przeszkody.ForEach(delegate (PointF punkt)
                {
                    ctx.FillEllipse(
                    Brushes.Black,
                    przeszkody.ElementAt(i).X,
                    przeszkody.ElementAt(i).Y,
                    20, 20);
                    ctx.FillEllipse(
                    Brushes.Gray,
                    przeszkody.ElementAt(i).X+7,
                    przeszkody.ElementAt(i).Y+7,
                    6, 6);
                    i++;
                });
            }
        }
    }
}
