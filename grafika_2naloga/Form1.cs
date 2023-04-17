using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace grafika_2naloga
{
    public partial class Form1: Form
    {
        private static Random VrecaNakljucnihStevil = new Random();
        private List<DeznaKapljica> Kapljice = new List<DeznaKapljica>();

        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }   

        public void UstvariKapljice()
        {
            int koliko_kapljic = VrecaNakljucnihStevil.Next(2, 5);
            for (int i = 0; i < koliko_kapljic; i++)
            {
                DeznaKapljica kapljica = new DeznaKapljica(VrecaNakljucnihStevil.Next(0, pictureBox.Width), 0, false);
                Kapljice.Add(kapljica);
            }
        }

        private void Osvezi(object sender, EventArgs e)
        {
            foreach (DeznaKapljica kapljica in Kapljice)
            {
                if (!kapljica.NaMestu)
                {
                    if (kapljica.Y + 1 > pictureBox.Height)
                    {
                        kapljica.NaMestu = true;
                    }
                    else if (Kapljice.Contains(new DeznaKapljica(kapljica.X, kapljica.Y + 1, true)))
                    {
                        kapljica.NaMestu = true;
                    }
                    else
                    {
                        kapljica.Y += 1;
                    }
                }
            }
            UstvariKapljice();
            pictureBox.Refresh();
        }

        private void Narisi(object sender, PaintEventArgs e)
        {
            Graphics platno = e.Graphics;
            foreach (DeznaKapljica kapljica in Kapljice)
            {
                platno.DrawEllipse(new Pen(Color.Blue, 3), new Rectangle(kapljica.X, kapljica.Y, 1, 3));
            }
        }
    }
}