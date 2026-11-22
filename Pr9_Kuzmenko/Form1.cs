using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr9_Kuzmenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.Text = "Практична робота №9";

            Image img = new Bitmap(
             @"C:\Users\djbkfdj\source\repos\Pr9_Kuzmenko\Pr9_Kuzmenko\cat.jpg");

            e.Graphics.DrawImage(
                img,
                0,
                0,
                this.ClientSize.Width,
                this.ClientSize.Height);
        }
    }
}