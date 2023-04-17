using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace grafika_1naloga
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Narisi(object sender, PaintEventArgs e)
        {
            List<Point> polyPoints = new List<Point>();
            polyPoints.Add(new Point((int)(pictureBox.Width * 0.18), (int)(pictureBox.Height * 0.4)));
            polyPoints.Add(new Point((int)(pictureBox.Width * 0.42), (int)(pictureBox.Height * 0.4)));
            polyPoints.Add(new Point((int)(pictureBox.Width * 0.3), (int)(pictureBox.Height * 0.2)));
            Graphics platno = e.Graphics;
            platno.SmoothingMode = SmoothingMode.AntiAlias;
            platno.FillRectangle(new SolidBrush(Color.SkyBlue), new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            platno.FillRectangle(new SolidBrush(Color.Green), new Rectangle(0, (int)(pictureBox.Height * 0.75), pictureBox.Width, (int)(pictureBox.Height * 0.25)));
            platno.FillRectangle(new SolidBrush(Color.White), new Rectangle((int)(pictureBox.Width * 0.2), (int)(pictureBox.Height * 0.4), (int)(pictureBox.Width * 0.2), (int)(pictureBox.Height * 0.4)));
            platno.FillPolygon(new SolidBrush(Color.SaddleBrown), polyPoints.ToArray());
            platno.FillEllipse(new SolidBrush(Color.Yellow), new Rectangle((int)(pictureBox.Width * 0.75), (int)(pictureBox.Height * 0.15), (int)(pictureBox.Height * 0.15), (int)(pictureBox.Height * 0.15)));
        }

        private void spremeniVelikost(object sender, System.EventArgs e)
        {
            pictureBox.Size = new Size(this.Width, this.Height);
        }
    }
}