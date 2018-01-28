using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Extensions.Extensions
{
    //DEAN JONES
    //JUL.31, 2017
    //GEOMETRY EXTENTIONS

    //TODO
    //SYMMETRY (1, 2, 3)(3, 2, 1)
    //ROTATION
    //MOVE
    //SCALE
    //MIRROR(REFLECTION)
    //TRANSFORMATIONS... (from array 2d?)
    //get outline (of box)
    //get rows
    //divide rows up (by 2, by 3, etc)

    //TODO
    //PI constant TAU constant (2*pi)

    //MATH SIN ... 
    //MATH COS ...
    //AREA OF POLYGON... (REGULAR)

    public static class GeometryExtension
    {
        //AREA OF A (REGULAR) POLYGON
        public static double AreaOfPolygonInscribed(double r, int n)
        {
            //REGULAR POLYGON (same side lengths)
            //FORMULA (area = (r^2 * n * sin(360/n)) / 2)
            //r = radius (circumscribed polygon)
            //n = number of polygon sides

            double result;
            //calc
            result = (Math.Pow(r, 2) * n * Math.Sin(ToRadians(360) / n)) / 2;
            //rounding
            result = Math.Round(result, 3);

            return result;
        }

        //METHOD (RADIANS TO DEGREES)
        public static double ToDegrees(this double radians)
        {
            return radians * (180 / Math.PI);
        }

        //METHOD (DEGREES TO RADIANS)
        public static double ToRadians(this double degrees)
        {
            return degrees * (Math.PI / 180);
        }

        //METHOD (LENGTH OF LINE)
        public static double GetLength(int x1, int y1, int x2, int y2)
        {
            //formula
            //sqrt((x2-x1)^2 + (y2-y1)^2)

            double myDouble = 0;

            //int myX = x2 - x1;
            //int myY = y2 - y1;
            //double myX2 = myX.Power(2);
            //double myY2 = myY.Power(2);
            //double result1 = myX2 + myY2;
            //double result2 = result1.SquareRoot();

            return myDouble;
        }

        //METHOD (LENGTH OF LINE)
        public static double GetLength(Point pt1, Point pt2)
        {
            //formula
            //sqrt((x2-x1)^2 + (y2-y1)^2)

            double myDouble = 0;

            return myDouble;
        }

        //To convert from Polar Coordinates(r, θ) to Cartesian Coordinates(x, y) :

        //x = r × cos(θ )
        //y = r × sin(θ )
        //To convert from Cartesian Coordinates(x, y) to Polar Coordinates(r, θ):

        //r = √ (x2 + y2 )
        //θ = tan-1 (y / x )
        //The value of tan-1(y/x ) may need to be adjusted:

        //Quadrant I: Use the calculator value
        //Quadrant II: Add 180°
        //Quadrant III: Add 180°
        //Quadrant IV: Add 360°


    }
}
