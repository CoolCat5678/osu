using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu
{
    internal class HitObjects : PictureBox  
    {
        public int x;
        public int y;
        public double time;
        public int hitsound;
        public int objectParams;
        // public string? curveType;

        public HitObjects(int X, int Y, double Time, int Hitsound, int ObjectParams)
        {
            x = Convert.ToInt32(X * 1.6);
            y = Convert.ToInt32(Y * 1.6);
            time = Time/100;
            hitsound = Hitsound;
            objectParams = ObjectParams;
            this.BackColor = Color.Transparent;
            this.Location = new Point(x, y);
            this.Size = new Size(128, 128);
            this.Image = Properties.Resources.hitcircle;
        }
    }
}
