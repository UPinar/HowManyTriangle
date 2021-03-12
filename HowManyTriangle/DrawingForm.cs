using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowManyTriangle
{
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
            
        }

        
        Pen myPen = new Pen(Color.Black);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            
            foreach (Line drawLine in Form1.LineStaticList.ToList())
            {
                
                graphics.DrawLine(myPen, drawLine.FirstDotOfLine.DotXValue, drawLine.FirstDotOfLine.DotYValue, drawLine.SecondDotOfLine.DotXValue, drawLine.SecondDotOfLine.DotYValue);

            }
            
        }

       
    }
}
