using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTriangle
{
    public class Line : IEquatable<Line>
    {


        public Dot FirstDotOfLine { get; set; }
        public Dot SecondDotOfLine { get; set; }
        public float slopeOfLine { get; set; }

        public bool isVertical()
        {
            if (this.FirstDotOfLine.DotYValue == this.SecondDotOfLine.DotYValue & this.FirstDotOfLine.DotXValue != this.SecondDotOfLine.DotXValue)
            {
                return true;
            }

            return false;
        }

        public bool isHorizontal()
        {
            if (this.FirstDotOfLine.DotXValue == this.SecondDotOfLine.DotXValue & this.FirstDotOfLine.DotYValue != this.SecondDotOfLine.DotYValue)
            {
                return true;
            }

            return false;
        }
        public List<Dot> DotsOnLineList { get; set; }

        public Line()
        {
            this.DotsOnLineList = new List<Dot>();
        }

        public bool DotIsOntheLine(Dot dot)
        {
            //Line Equation y = mx + b

            float m = this.slopeOfLine;
            float b = 0;

            b = this.FirstDotOfLine.DotYValue - (m * this.FirstDotOfLine.DotXValue);

            if (Math.Round(dot.DotYValue) == Math.Round( m * dot.DotXValue + b))
            {
                if (this.FirstDotOfLine.DotXValue >= dot.DotXValue & this.SecondDotOfLine.DotXValue <= dot.DotXValue)
                {
                    if (this.FirstDotOfLine.DotYValue >= dot.DotYValue & this.SecondDotOfLine.DotYValue <= dot.DotYValue)
                    {
                        return true;
                    }
                    else if (this.FirstDotOfLine.DotYValue <= dot.DotYValue & this.SecondDotOfLine.DotYValue >= dot.DotYValue)
                    {
                        return true;
                    }
                }
                else if (this.FirstDotOfLine.DotXValue <= dot.DotXValue & this.SecondDotOfLine.DotXValue >= dot.DotXValue)
                {
                    if (this.FirstDotOfLine.DotYValue >= dot.DotYValue & this.SecondDotOfLine.DotYValue <= dot.DotYValue)
                    {
                        return true;
                    }
                    else if (this.FirstDotOfLine.DotYValue <= dot.DotYValue & this.SecondDotOfLine.DotYValue >= dot.DotYValue)
                    {
                        return true;
                    }
                }
            }
            else if (this.FirstDotOfLine.DotXValue == this.SecondDotOfLine.DotXValue & this.FirstDotOfLine.DotYValue != this.SecondDotOfLine.DotYValue)
            {
                if (dot.DotXValue == this.FirstDotOfLine.DotXValue & dot.DotXValue == this.SecondDotOfLine.DotXValue)
                {
                    if (this.FirstDotOfLine.DotXValue >= dot.DotXValue & this.SecondDotOfLine.DotXValue <= dot.DotXValue)
                    {
                        if (this.FirstDotOfLine.DotYValue >= dot.DotYValue & this.SecondDotOfLine.DotYValue <= dot.DotYValue)
                        {
                            return true;
                        }
                        else if (this.FirstDotOfLine.DotYValue <= dot.DotYValue & this.SecondDotOfLine.DotYValue >= dot.DotYValue)
                        {
                            return true;
                        }
                    }
                    else if (this.FirstDotOfLine.DotXValue <= dot.DotXValue & this.SecondDotOfLine.DotXValue >= dot.DotXValue)
                    {
                        if (this.FirstDotOfLine.DotYValue >= dot.DotYValue & this.SecondDotOfLine.DotYValue <= dot.DotYValue)
                        {
                            return true;
                        }
                        else if (this.FirstDotOfLine.DotYValue <= dot.DotYValue & this.SecondDotOfLine.DotYValue >= dot.DotYValue)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool Equals(Line line)
        {
            if (this.FirstDotOfLine == line.FirstDotOfLine)
            {
                if (this.SecondDotOfLine == line.SecondDotOfLine)
                {
                    return true;
                }
            }
            else if (this.FirstDotOfLine == line.SecondDotOfLine)
            {
                if(this.SecondDotOfLine == line.FirstDotOfLine)
                {
                    return true;
                }
            }

            return false;
        }

        

        
    }
}
