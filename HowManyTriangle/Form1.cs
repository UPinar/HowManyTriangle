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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CreateRadioButtons();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            btnRefresh_Click(sender, e);

        }

        private void RadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            radioButton.BackColor = Color.Red;
            if (firstPointTextX.Text == string.Empty)
            {
                firstPointTextX.Text = radioButton.Location.X.ToString();
                firstPointTextY.Text = radioButton.Location.Y.ToString();
            }
            else if (secondPointTextX.Text == string.Empty)
            {
                secondPointTextX.Text = radioButton.Location.X.ToString();
                secondPointTextY.Text = radioButton.Location.Y.ToString();
            }
            else if (btnTriangle.Visible.Equals(true) == true && thirdPointTextX.Text == string.Empty)
            {
                thirdPointTextX.Text = radioButton.Location.X.ToString();
                thirdPointTextY.Text = radioButton.Location.Y.ToString();
            }
            else
                return;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            firstPointTextX.Visible = false;
            secondPointTextX.Visible = false;
            thirdPointTextX.Visible = false;

            firstPointTextY.Visible = false;
            secondPointTextY.Visible = false;
            thirdPointTextY.Visible = false;

            ClearAllTextBoxes();

            btnDrawLine.Visible = false;
            btnDrawTriangle.Visible = false;
        }


        private void btnLine_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;

            firstPointTextX.Visible = true;
            firstPointTextY.Visible = true;

            secondPointTextX.Visible = true;
            secondPointTextY.Visible = true;

            thirdPointTextX.Visible = false;
            thirdPointTextY.Visible = false;

            btnDrawLine.Visible = true;
            btnDrawTriangle.Visible = false;
        }

        private void BtnTriangle_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            firstPointTextX.Visible = true;
            secondPointTextX.Visible = true;
            thirdPointTextX.Visible = true;

            firstPointTextY.Visible = true;
            secondPointTextY.Visible = true;
            thirdPointTextY.Visible = true;

            btnDrawTriangle.Visible = true;
            btnDrawLine.Visible = false;
        }

        private void CreateRadioButtons()
        {
            for (int i = -15; i < 15; i++)
            {
                for (int j = -15; j < 15; j++)
                {
                    RadioButton radioButton = new RadioButton();
                    buttonPanel.Controls.Add(radioButton);
                    radioButton.Text = "";
                    radioButton.Size = new Size(14, 13);
                    radioButton.Location = new Point(buttonPanel.Width / 2 + i * 15, buttonPanel.Height / 2 + j * 15);
                    radioButton.Checked = false;
                    radioButton.Anchor = AnchorStyles.None;
                    radioButton.Margin = new Padding(0);
                    radioButton.MouseClick += RadioButton_MouseClick;
                    radioButton.Visible = true;

                }
            }
        }

        
        // Lists
        public List<Dot> DotsList = new List<Dot>();

        public List<Line> LinesList = new List<Line>();

        public static List<Line> LineStaticList = new List<Line>();

        public List<Line> BiggerLineList = new List<Line>();

        // Drawing Part
        DrawingForm drawingClass = new DrawingForm();
        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            if (firstPointTextX.Text == "" | firstPointTextY.Text == "" | secondPointTextX.Text == "" | secondPointTextY.Text == "")
                return;

            Dot dotOne = new Dot();
            dotOne.DotXValue = float.Parse(firstPointTextX.Text);
            dotOne.DotYValue = float.Parse(firstPointTextY.Text);

            Dot dotTwo = new Dot();
            dotTwo.DotXValue = float.Parse(secondPointTextX.Text);
            dotTwo.DotYValue = float.Parse(secondPointTextY.Text);

            foreach (RadioButton item in buttonPanel.Controls)
            {
                if (item.Location.X == dotOne.DotXValue && item.Location.Y == dotOne.DotYValue)
                {
                    item.BackColor = Color.Blue;
                }
                if (item.Location.X == dotTwo.DotXValue && item.Location.Y == dotTwo.DotYValue)
                {
                    item.BackColor = Color.Blue;
                }
            }


            if (!DotsList.Any(x => x.DotXValue == dotOne.DotXValue && x.DotYValue == dotOne.DotYValue))
                DotsList.Add(dotOne);
            if (!DotsList.Any(x => x.DotXValue == dotTwo.DotXValue && x.DotYValue == dotTwo.DotYValue))
                DotsList.Add(dotTwo);


            if (!LinesList.Any(x => x.FirstDotOfLine.Equals(dotOne) & x.SecondDotOfLine.Equals(dotTwo)) || !LinesList.Any(x => x.FirstDotOfLine.Equals(dotTwo) & x.SecondDotOfLine.Equals(dotOne)))
            {
                Line line = new Line();
                float slope = (dotTwo.DotYValue - dotOne.DotYValue) / (dotTwo.DotXValue - dotOne.DotXValue);

                line.FirstDotOfLine = dotOne;
                line.SecondDotOfLine = dotTwo;
                line.slopeOfLine = slope;
                LinesList.Add(line);
            }

            foreach (Line lines in LinesList)
            {
                LineStaticList.Add(lines);
            }

            drawingClass.Refresh();
            drawingClass.Show();
            ClearAllTextBoxes();
        }

        private void btnDrawTriangle_Click(object sender, EventArgs e)
        {

            if (firstPointTextX.Text == "" | firstPointTextY.Text == "" | secondPointTextX.Text == "" | secondPointTextY.Text == "" | thirdPointTextX.Text == "" | thirdPointTextY.Text == "")
                return;

            Dot dotOne = new Dot();
            dotOne.DotXValue = float.Parse(firstPointTextX.Text);
            dotOne.DotYValue = float.Parse(firstPointTextY.Text);

            Dot dotTwo = new Dot();
            dotTwo.DotXValue = float.Parse(secondPointTextX.Text);
            dotTwo.DotYValue = float.Parse(secondPointTextY.Text);

            Dot dotThree = new Dot();
            dotThree.DotXValue = float.Parse(thirdPointTextX.Text);
            dotThree.DotYValue = float.Parse(thirdPointTextY.Text);



            if (!DotsList.Exists(x => x.DotXValue == dotOne.DotXValue && x.DotYValue == dotOne.DotYValue))
                DotsList.Add(dotOne);
            if (!DotsList.Exists(x => x.DotXValue == dotTwo.DotXValue && x.DotYValue == dotTwo.DotYValue))
                DotsList.Add(dotTwo);
            if (!DotsList.Exists(x => x.DotXValue == dotThree.DotXValue && x.DotYValue == dotThree.DotYValue))
                DotsList.Add(dotThree);


            foreach (RadioButton item in buttonPanel.Controls)
            {
                if (item.Location.X == dotOne.DotXValue && item.Location.Y == dotOne.DotYValue)
                {
                    item.BackColor = Color.Blue;
                }
                if (item.Location.X == dotTwo.DotXValue && item.Location.Y == dotTwo.DotYValue)
                {
                    item.BackColor = Color.Blue;
                }
                if (item.Location.X == dotThree.DotXValue && item.Location.Y == dotThree.DotYValue)
                {
                    item.BackColor = Color.Blue;
                }

            }


            if (LinesList.Any(x => x.FirstDotOfLine.Equals(dotOne) & x.SecondDotOfLine.Equals(dotTwo)))
            {

            }
            else if (LinesList.Any(x => x.FirstDotOfLine.Equals(dotTwo) & x.SecondDotOfLine.Equals(dotOne)))
            {

            }
            else
            {
                Line line1 = new Line();
                float slope = 0;
                if (dotTwo.DotXValue == dotOne.DotXValue)
                    slope = 0;
                else
                    slope = (dotTwo.DotYValue - dotOne.DotYValue) / (dotTwo.DotXValue - dotOne.DotXValue);

                line1.FirstDotOfLine = dotOne;
                line1.SecondDotOfLine = dotTwo;
                line1.slopeOfLine = slope;
                LinesList.Add(line1);
            }

            if (LinesList.Any(x => x.FirstDotOfLine.Equals(dotTwo) & x.SecondDotOfLine.Equals(dotThree)))
            {

            }
            else if (LinesList.Any(x => x.FirstDotOfLine.Equals(dotThree) & x.SecondDotOfLine.Equals(dotTwo)))
            {

            }
            else
            {
                Line line1 = new Line();
                float slope = 0;
                if (dotThree.DotXValue == dotTwo.DotXValue)
                    slope = 0;
                else
                    slope = (dotThree.DotYValue - dotTwo.DotYValue) / (dotThree.DotXValue - dotTwo.DotXValue);

                line1.FirstDotOfLine = dotTwo;
                line1.SecondDotOfLine = dotThree;
                line1.slopeOfLine = slope;
                LinesList.Add(line1);
            }

            if (LinesList.Any(x => x.FirstDotOfLine.Equals(dotOne) & x.SecondDotOfLine.Equals(dotThree)))
            {

            }
            else if (LinesList.Any(x => x.FirstDotOfLine.Equals(dotThree) & x.SecondDotOfLine.Equals(dotOne)))
            {

            }
            else
            {
                Line line1 = new Line();
                float slope = 0;
                if (dotOne.DotXValue == dotThree.DotXValue)
                    slope = 0;
                else
                    slope = (dotOne.DotYValue - dotThree.DotYValue) / (dotOne.DotXValue - dotThree.DotXValue);

                line1.FirstDotOfLine = dotThree;
                line1.SecondDotOfLine = dotOne;
                line1.slopeOfLine = slope;
                
                LinesList.Add(line1);
            }

            foreach (Line lines in LinesList)
            {
                LineStaticList.Add(lines);
            }

            drawingClass.Refresh();
            drawingClass.Show();
            ClearAllTextBoxes();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();

            foreach (RadioButton item in buttonPanel.Controls)
            {
                if (item.BackColor == Color.Red)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void ClearAllTextBoxes()
        {
            firstPointTextX.Text = string.Empty;
            secondPointTextX.Text = string.Empty;
            thirdPointTextX.Text = string.Empty;

            firstPointTextY.Text = string.Empty;
            secondPointTextY.Text = string.Empty;
            thirdPointTextY.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate.Visible = false;
            textBoxTriangleCount.Text = calculatingTriangles().ToString();
        }

        public int calculatingTriangles()
        {

            collectingIntersectPoints();

            collectingAllLines(LinesList.ToList());

            return CountingTriangles();
        }

        private void collectingIntersectPoints()
        {

            foreach (Line line1 in LinesList)
            {
                foreach (Line line2 in LinesList)
                {

                    if (!line1.Equals(line2) /*&& line1.slopeOfLine != line2.slopeOfLine*/)
                    {
                        Dot intersectDot = new Dot();

                        float a1, b1, c1, a2, b2, c2;
                        float determinant;


                        a1 = line1.SecondDotOfLine.DotYValue - line1.FirstDotOfLine.DotYValue;
                        b1 = line1.FirstDotOfLine.DotXValue - line1.SecondDotOfLine.DotXValue;
                        c1 = a1 * line1.FirstDotOfLine.DotXValue + b1 * line1.FirstDotOfLine.DotYValue;

                        a2 = line2.SecondDotOfLine.DotYValue - line2.FirstDotOfLine.DotYValue;
                        b2 = line2.FirstDotOfLine.DotXValue - line2.SecondDotOfLine.DotXValue;
                        c2 = a2 * line2.FirstDotOfLine.DotXValue + b2 * line2.FirstDotOfLine.DotYValue;

                        determinant = a1 * b2 - a2 * b1;

                        if (determinant == 0)
                        {
                            intersectDot.DotXValue = 0;
                            intersectDot.DotYValue = 0;
                        }
                        else
                        {
                            intersectDot.DotXValue = (b2 * c1 - b1 * c2) / determinant;
                            intersectDot.DotYValue = (a1 * c2 - a2 * c1) / determinant;
                        }

                        //INTERSECT DOT ON BOTH LINES CORNER.
                        if (intersectDot.Equals(line1.FirstDotOfLine) | intersectDot.Equals(line1.SecondDotOfLine))
                        {
                            if (intersectDot.Equals(line2.FirstDotOfLine) | intersectDot.Equals(line2.SecondDotOfLine))
                            {
                                if (!DotsList.Any(x => x.Equals(intersectDot)))
                                {
                                    DotsList.Add(intersectDot);
                                }
                            }
                        }

                        // INTERSECT DOT ON ONE OF LINES'S CORNER AND INSIDE THE OTHER LINE.
                        if (intersectDot.Equals(line1.FirstDotOfLine) | intersectDot.Equals(line1.SecondDotOfLine))
                        {
                            if (!intersectDot.Equals(line2.FirstDotOfLine) & !intersectDot.Equals(line2.SecondDotOfLine))
                            {
                                if (line2.DotIsOntheLine(intersectDot) == true)
                                {
                                    if (!DotsList.Any(x => x.Equals(intersectDot)))
                                    {
                                        DotsList.Add(intersectDot);
                                    }
                                }
                            }
                        }
                        else if (intersectDot.Equals(line2.FirstDotOfLine) | intersectDot.Equals(line2.SecondDotOfLine))
                        {
                            if (!intersectDot.Equals(line1.FirstDotOfLine) & !intersectDot.Equals(line1.SecondDotOfLine))
                            {
                                if (line1.DotIsOntheLine(intersectDot) == true)
                                {
                                    if (!DotsList.Any(x => x.Equals(intersectDot)))
                                    {
                                        DotsList.Add(intersectDot);
                                    }
                                }
                            }
                        }

                        //INTERSECT DOT IS INSIDE OF BOTH LINES 
                        if (!intersectDot.Equals(line1.FirstDotOfLine) & !intersectDot.Equals(line1.SecondDotOfLine))
                        {
                            if (!intersectDot.Equals(line2.FirstDotOfLine) & !intersectDot.Equals(line2.SecondDotOfLine))
                            {
                                if (line1.DotIsOntheLine(intersectDot) == true)
                                {
                                    if (line2.DotIsOntheLine(intersectDot) == true)
                                    {
                                        if (!DotsList.Any(x => x.Equals(intersectDot)))
                                        {
                                            DotsList.Add(intersectDot);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void collectingAllLines(List<Line> lineList)
        {
            
            foreach (Line line in lineList)
            {
                foreach (Dot dot in DotsList)
                {
                    
                    if(line.DotIsOntheLine(dot) == true)
                    {
                         
                        if (!line.DotsOnLineList.Contains(dot))
                        {
                            line.DotsOnLineList.Add(dot);
                        }
                        
                    }   
                }
            }

            foreach (Line line in lineList)
            {
                foreach(Dot dot1 in line.DotsOnLineList)
                {
                    foreach (Dot dot2 in line.DotsOnLineList)
                    {
                        if (dot1 != dot2)
                        {
                            Line newLine = new Line();
                            newLine.FirstDotOfLine = dot1;
                            newLine.SecondDotOfLine = dot2;
                            newLine.slopeOfLine = line.slopeOfLine;
                            if (!lineList.Any(x => x.FirstDotOfLine.Equals(dot1) & x.SecondDotOfLine.Equals(dot2)) & !lineList.Any(y => y.FirstDotOfLine.Equals(dot2) & y.SecondDotOfLine.Equals(dot1)))
                            {
                                lineList.Add(newLine);
                                LinesList.Clear();
                                
                                foreach(Line lines in lineList)
                                {
                                    LinesList.Add(lines);
                                }
                                collectingAllLines(lineList);
                                return;
                            }
                        }
                    }
                }
            }
        }  


        public List<Triangle> TriangleList = new List<Triangle>(); 
        public int CountingTriangles()
        {
            int triangleCount = 0;

            Line tempLine1 = new Line();
            Line tempLine2 = new Line();
            Line tempLine3 = new Line();


            foreach (Dot dot1 in DotsList)
            {
                foreach (Dot dot2 in DotsList)
                {
                    foreach (Dot dot3 in DotsList)
                    {
                        if (dot1 != dot2 & dot2 != dot3 & dot3 != dot1)
                        {
                            tempLine1 = null;
                            tempLine2 = null;
                            tempLine3 = null;

                            if (LinesList.Find(x => x.FirstDotOfLine.Equals(dot1) & x.SecondDotOfLine.Equals(dot2)) != null)
                                tempLine1 = LinesList.Find(x => x.FirstDotOfLine.Equals(dot1) & x.SecondDotOfLine.Equals(dot2));
                            else if (LinesList.Find(x => x.FirstDotOfLine.Equals(dot2) & x.SecondDotOfLine.Equals(dot1)) != null)
                                tempLine1 = LinesList.Find(x => x.FirstDotOfLine.Equals(dot2) & x.SecondDotOfLine.Equals(dot1));
                            else
                                continue;

                            if (LinesList.Find(x => x.FirstDotOfLine.Equals(dot2) & x.SecondDotOfLine.Equals(dot3)) != null)
                                tempLine2 = LinesList.Find(x => x.FirstDotOfLine.Equals(dot2) & x.SecondDotOfLine.Equals(dot3));
                            else if (LinesList.Find(x => x.FirstDotOfLine.Equals(dot3) & x.SecondDotOfLine.Equals(dot2)) != null)
                                tempLine2 = LinesList.Find(x => x.FirstDotOfLine.Equals(dot3) & x.SecondDotOfLine.Equals(dot2));
                            else
                                continue;


                            if (LinesList.Find(x => x.FirstDotOfLine.Equals(dot1) & x.SecondDotOfLine.Equals(dot3)) != null)
                                tempLine3 = LinesList.Find(x => x.FirstDotOfLine.Equals(dot1) & x.SecondDotOfLine.Equals(dot3));
                            else if (LinesList.Find(x => x.FirstDotOfLine.Equals(dot3) & x.SecondDotOfLine.Equals(dot1)) != null)
                                tempLine3 = LinesList.Find(x => x.FirstDotOfLine.Equals(dot3) & x.SecondDotOfLine.Equals(dot1));
                            else
                                continue;


                            if (tempLine1 != null & tempLine2 != null & tempLine3 != null)
                            {
                                if (tempLine1.slopeOfLine != tempLine2.slopeOfLine & tempLine1.slopeOfLine != tempLine3.slopeOfLine & tempLine2.slopeOfLine != tempLine3.slopeOfLine)
                                {
                                    if (TriangleList.Any(x => x.DotOne.Equals(dot1) & x.DotTwo.Equals(dot2) & x.DotThree.Equals(dot3)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot1) & x.DotTwo.Equals(dot3) & x.DotThree.Equals(dot2)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot2) & x.DotTwo.Equals(dot1) & x.DotThree.Equals(dot3)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot2) & x.DotTwo.Equals(dot3) & x.DotThree.Equals(dot1)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot3) & x.DotTwo.Equals(dot1) & x.DotThree.Equals(dot2)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot3) & x.DotTwo.Equals(dot2) & x.DotThree.Equals(dot1)))
                                        continue;
                                    else
                                    {
                                        Triangle newTriange = new Triangle();
                                        newTriange.DotOne = dot1;
                                        newTriange.DotTwo = dot2;
                                        newTriange.DotThree = dot3;

                                        TriangleList.Add(newTriange);
                                        triangleCount++;
                                    }

                                }
                                else if (tempLine1.isHorizontal() & tempLine2.isVertical())
                                {

                                    if (TriangleList.Any(x => x.DotOne.Equals(dot1) & x.DotTwo.Equals(dot2) & x.DotThree.Equals(dot3)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot1) & x.DotTwo.Equals(dot3) & x.DotThree.Equals(dot2)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot2) & x.DotTwo.Equals(dot1) & x.DotThree.Equals(dot3)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot2) & x.DotTwo.Equals(dot3) & x.DotThree.Equals(dot1)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot3) & x.DotTwo.Equals(dot1) & x.DotThree.Equals(dot2)))
                                        continue;
                                    else if (TriangleList.Any(x => x.DotOne.Equals(dot3) & x.DotTwo.Equals(dot2) & x.DotThree.Equals(dot1)))
                                        continue;
                                    else
                                    {
                                        Triangle newTriange = new Triangle();
                                        newTriange.DotOne = dot1;
                                        newTriange.DotTwo = dot2;
                                        newTriange.DotThree = dot3;

                                        TriangleList.Add(newTriange);
                                        triangleCount++;
                                    }
                                }
                            }
                            
                        }
                    }
                }
            }
            return triangleCount;
        }
       
    }
}