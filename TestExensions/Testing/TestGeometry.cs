using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions.Geometry;              //add reference to (project), add (using)
using Extensions.Extensions;            //add reference to (project), add (using)
using System.Diagnostics;

namespace TestExensions.Testing
{
    //DEAN JONES
    //JUL.31, 2017
    //TEST CLASS (GEOMETRY INHERITANCE)

    [TestClass]
    public class TestGeometry
    {
        [TestMethod]
        public void TestAreaOfPolygonInscribed()
        {
            //arrange 
            double expected6 = 2.598d;
            double expected5 = 2.378d;
            double expected4 = 2.000d;

            double actual6 = Math.Round(GeometryExtension.AreaOfPolygonInscribed(1, 6), 3); //hexagon (radius 1)
            double actual5 = Math.Round(GeometryExtension.AreaOfPolygonInscribed(1, 5), 3); //pentagon (radius 1)
            double actual4 = Math.Round(GeometryExtension.AreaOfPolygonInscribed(1, 4), 3); //square (radius 1)

            //assert
            Assert.AreEqual(expected6, actual6);
            Assert.AreEqual(expected5, actual5);
            Assert.AreEqual(expected4, actual4);

            //print
            Debug.WriteLine("expected6: " + expected6);
            Debug.WriteLine("actual6: " + actual6);
            Debug.WriteLine("expected5: " + expected5);
            Debug.WriteLine("actual5: " + actual5);
            Debug.WriteLine("expected4: " + expected4);
            Debug.WriteLine("actual4: " + actual4);

        }

        [TestMethod]
        public void GeometryGetLength()
        {
            //arrange 
            double expected = 14.142135623730951d;

            //act
            Line myLine = new Line(0, 0, 10, 10);
            double actual = myLine.GetLength();

            //assert
            Assert.AreEqual(expected, actual);

            //print
            Debug.WriteLine("expected: " + expected);
            Debug.WriteLine("actual: " + actual);

        }

        [TestMethod]
        public void GeometryPoint()
        {
            //arrange
            int xExpected = 10;
            int yExpected = 20;

            //act
            Point pt = new Point();
            pt.XCoordinate = 10;
            pt.YCoordinate = 20;

            //test 
            bool booX = xExpected == pt.XCoordinate;
            bool booY = yExpected == pt.YCoordinate;

            ////assert
            Assert.IsTrue(booX && booY);

            //print
            Debug.WriteLine("xExpected: " + xExpected);
            Debug.WriteLine("yExpected: " + yExpected);
            Debug.WriteLine("XCoordinate: " + pt.XCoordinate);
            Debug.WriteLine("YCoordinate: " + pt.YCoordinate);
            Debug.WriteLine("booX: " + booX);
            Debug.WriteLine("booY: " + booY);

        }
    }
}
