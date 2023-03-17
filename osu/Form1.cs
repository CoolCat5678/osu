using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace osu
{
    public partial class osu : Form
    {
        public osu()
        {
            InitializeComponent();
        }

        private void osu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    string songPath = @"C:\\Users\\Leo\\source\\repos\\osu\\osu\\resource\\song\\Gennryuu Kaiko.txt ";
            //    string readText = File.ReadAllText(songPath);
            //    MessageBox.Show(readText); 
            Song song = new Song();
            song.hitObjects();
            this.Controls.Add(new HitObjects(76, 270, 1619, 6, 0));
        }
    }
}