using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawFractal();
        }

        private void DrawFractal()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Random random = new Random();

            int x0 = 200;
            int y0 = 250;

            int x1 = 20;
            int y1 = 350;

            int x2 = 150;
            int y2 = 20;

            int x3 = 600;
            int y3 = 400;

            Pen pen = new Pen(Color.Blue);
            graph.DrawRectangle(pen, x1, y1, 1, 1);
            graph.DrawRectangle(pen, x2, y2, 1, 1);
            graph.DrawRectangle(pen, x3, y3, 1, 1);

            graph.DrawRectangle(pen, x0, y0, 1, 1);

            for (int i = 0; i < 100000; i++)
            {

                int choice = random.Next(0, 3);

                switch (choice)
                {
                    case 0:
                        x0 = (x0 + x1) / 2;
                        y0 = (y0 + y1) / 2;

                        graph.DrawRectangle(pen, x0, y0, 1, 1);
                        break;

                    case 1:
                        x0 = (x0 + x2) / 2;
                        y0 = (y0 + y2) / 2;

                        graph.DrawRectangle(pen, x0, y0, 1, 1);
                        break;

                    case 2:
                        x0 = (x0 + x3) / 2;
                        y0 = (y0 + y3) / 2;

                        graph.DrawRectangle(pen, x0, y0, 1, 1);
                        break;
                }
            }
            picture.Image = bmp;
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
