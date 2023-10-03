using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace GraphicsPainter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = (int)GraphicType.Linear; i <= (int)GraphicType.Logarithmic; i++)
            {
                cbGraphicType.Items.Add(Program.GraphicTypeToString((GraphicType)i));
            }

            cbGraphicType.SelectedIndex = 0;
        }

        private void btnDrawGraphic_Click(object sender, EventArgs e)
        {
            DrawGraphic((GraphicType)cbGraphicType.SelectedIndex);
        }


        private void DrawLinearGraphic(Bitmap bmp, int centerX, int centerY)
        {
            for (int x = -pbGraphic.Width / 2; x < pbGraphic.Width / 2; x++)
            {
                int y = x;
                int pixelX = centerX + x;
                int pixelY = centerY - y;
                bmp.SetPixel(pixelX, pixelY, Color.Blue);
            }
        }

        private void DrawQuadraticGraphic(Graphics g, int centerX, int centerY)
        {
            int scale = 20;
            for (int x = -pbGraphic.Width / 2; x < pbGraphic.Width / 2 - 1; x++)
            {
                double y1 = x * x;
                double y2 = (x + 1) * (x + 1);

                int pixelX1 = centerX + x * scale;
                int pixelY1 = centerY - (int)(y1 * scale);
                int pixelX2 = centerX + (x + 1) * scale;
                int pixelY2 = centerY - (int)(y2 * scale);

                g.DrawLine(Pens.Red, pixelX1, pixelY1, pixelX2, pixelY2);
            }
        }
        private void DrawCubicGraphic(Graphics g, int centerX, int centerY)
        {
            int scale = 20;
            for (double x = -pbGraphic.Width / (2 * scale); x < pbGraphic.Width / (2 * scale); x += 0.01)
            {
                double y1 = x * x * x;
                double y2 = (x + 0.01) * (x + 0.01) * (x + 0.01);

                int pixelX1 = (int)(centerX + x * scale);
                int pixelY1 = (int)(centerY - y1 * scale);
                int pixelX2 = (int)(centerX + (x + 0.01) * scale);
                int pixelY2 = (int)(centerY - y2 * scale);

                g.DrawLine(Pens.Green, pixelX1, pixelY1, pixelX2, pixelY2);
            }
        }

        private void DrawRationalGraphic(Graphics g, int centerX, int centerY)
        {
            int scale = 20;
            for (double x = -pbGraphic.Width / (2 * scale); x < pbGraphic.Width / (2 * scale); x += 0.01)
            {
                double y = 0;
                if (Math.Abs(x) > 0.01)
                {
                    y = 1 / x;
                }

                double xNext = x + 0.01;
                double yNext = 0;
                if (Math.Abs(xNext) > 0.01)
                {
                    yNext = 1 / xNext;
                }

                int pixelX1 = (int)(centerX + x * scale);
                int pixelY1 = (int)(centerY - y * scale);
                int pixelX2 = (int)(centerX + xNext * scale);
                int pixelY2 = (int)(centerY - yNext * scale);

                g.DrawLine(Pens.Orange, pixelX1, pixelY1, pixelX2, pixelY2);
            }
        }

        private void DrawLogarithmicGraphic(Graphics g, int centerX, int centerY)
        {
            int scale = 20;
            for (double x = 0.01; x < pbGraphic.Width / (2 * scale); x += 0.01)
            {
                double y = Math.Log(x);

                double xNext = x + 0.01;
                double yNext = Math.Log(xNext);

                int pixelX1 = (int)(centerX + x * scale);
                int pixelY1 = (int)(centerY - y * scale);
                int pixelX2 = (int)(centerX + xNext * scale);
                int pixelY2 = (int)(centerY - yNext * scale);

                g.DrawLine(Pens.Purple, pixelX1, pixelY1, pixelX2, pixelY2);
            }
        }

        public void DrawGraphic(GraphicType type)
        {
            Bitmap bmp = new Bitmap(pbGraphic.Width, pbGraphic.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.Clear(Color.White);

            Pen axisPen = new Pen(Color.Black);
            Pen gridPen = new Pen(Color.LightGray);

            int centerX = pbGraphic.Width / 2;
            int centerY = pbGraphic.Height / 2;

            g.DrawLine(axisPen, 0, centerY, pbGraphic.Width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, pbGraphic.Height);

            int gridSize = 20; 
            for (int x = gridSize; x < pbGraphic.Width; x += gridSize)
            {
                g.DrawLine(gridPen, x, 0, x, pbGraphic.Height);
            }
            for (int y = gridSize; y < pbGraphic.Height; y += gridSize)
            {
                g.DrawLine(gridPen, 0, y, pbGraphic.Width, y);
            }

            switch (type)
            {
                case GraphicType.Linear:
                    DrawLinearGraphic(bmp, centerX, centerY);
                    break;
                case GraphicType.Quadratic:
                    DrawQuadraticGraphic(g, centerX, centerY);
                    break;
                case GraphicType.Cubic:
                    DrawCubicGraphic(g, centerX, centerY);
                    break;
                case GraphicType.Rational:
                    DrawRationalGraphic(g, centerX, centerY);
                    break;
                case GraphicType.Logarithmic:
                    DrawLogarithmicGraphic(g, centerX, centerY);
                    break;
                default:
                    {
                        MessageBox.Show("Fatal error!");
                        return;
                    }
            }

            pbGraphic.Image = bmp;
        }
    }
}
