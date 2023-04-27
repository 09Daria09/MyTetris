using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellSize = 38;
            int rows = 20;
            int cols = 10;
            panel1.BackColor = Color.DimGray;
            Pen pen = new Pen(Color.Black);

            for (int y = 0; y <= rows * cellSize; y += cellSize)
            {
                g.DrawLine(pen, 0, y, cols * cellSize, y);
            }

            for (int x = 0; x <= cols * cellSize; x += cellSize)
            {
                g.DrawLine(pen, x, 0, x, rows * cellSize);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
