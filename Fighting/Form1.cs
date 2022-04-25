using Fighting.Entites;
using Fighting.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Form1 : Form
    {
        public Image IronMan;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            //var dir = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            IronMan = new Bitmap("C:\\Users\\expla\\source\\repos\\Fighting\\Fighting\\Sprites\\IronMan.png");
            Entity player = new Entity(500, 500, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, IronMan);
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(IronMan, new Point(100, 100));
        }
    }
}
