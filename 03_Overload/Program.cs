﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _03_Overload
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////////// Unary Operators
            //Point p1 = new Point()
            //{
            //    X = 3,
            //    Y = 2
            //};

            //Console.WriteLine("Point 1: " + p1);
            ////Console.WriteLine("Point 1(++p): " + ++p1);
            ////Console.WriteLine("Point 1(-p): " + -p1);
            ////Console.ReadKey();

            //Point p2 = -p1;

            ////Console.WriteLine("Point 1: " + p1);
            //Console.WriteLine("Point 2: " + p2);
            //Console.WriteLine("Point 1(p--): " + p1--);

            ////////////////////// Binary Operators
            //Point p3 = p1 + p2;

            //Console.WriteLine("Point 1: " + p1);
            //Console.WriteLine("Point 2: " + p2);
            //Console.WriteLine("Point 3(p1 + p2): " + p3);
            //Console.ReadKey();

            /////////////////////////////// Equals
            //Point p1 = new Point(2, 5);
            //Point p2 = new Point(2, 5);
            ////p1 = p2;

            //Console.WriteLine(p1.ToString());
            ////p2++;
            //Console.WriteLine(p1.ToString());

            //// Equals
            //if (p1.Equals(p2))
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Equals");

            //// Reference Equals
            //if (object.ReferenceEquals(p1, p2))
            //    Console.WriteLine("Reference Equals");
            //else
            //    Console.WriteLine("Reference Not Equals");

            //Point p1 = new Point(2, 5);
            //Point p2 = null;

            //// Equals
            //if (p1.Equals(p2))
            //    Console.WriteLine("Equals");
            //else
            //    Console.WriteLine("Not Equals");

            //// Equals
            //if (p1 == p2)
            //    Console.WriteLine("==");
            //else
            //    Console.WriteLine("!=");

            //////////////////////////// True/False Operators
            //Point p1 = new Point(0, 0);
            //Point p2 = new Point(3, 20);

            //if (p1)
            //    Console.WriteLine("TRUE");
            //else
            //    Console.WriteLine("FALSE");

            //// error
            //if (p2)
            //    Console.WriteLine("TRUE");
            //else
            //    Console.WriteLine("FALSE");

            //p1++;

            //if (p1)
            //    Console.WriteLine("TRUE");
            //else
            //    Console.WriteLine("FALSE");

            ////////////////////////////// Conversion Operators
            int a = 5;
            double d = 6.7;

            // int to double
            d = a;          // implicit
            a = (int)d;     // explicit

            Point p1 = new Point(1, 1);

            a = (int)p1;    // explicit
            d = p1;         // implicit
            Point3D p3d = p1;

            Console.WriteLine(a);

        } //--------------------Main--------------------↑


        class Point3D
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
            // Constructors
            public Point3D() : this(0, 0, 0) { }
            public Point3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }
        class Point
        {
            // Auto-properties
            public int X { get; set; }
            public int Y { get; set; }

            // Constructors
            public Point() : this(0, 0) { }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Override ToString
            public override string ToString()
            {
                return $"Point: x: {X}, y: {Y}";
            }

            /*
             * ref out - not allow
            public static return_type operator[symbol](parameters)
            {
                // code...
            }
            */

            #region Унарні оператори
            public static Point operator -(Point p)
            {
                Point p1 = new Point
                {
                    X = p.X * -1,
                    Y = p.Y * -1
                };
                return p1;
            }
            public static Point operator ++(Point p)
            {
                p.Y++;
                p.X++;
                return p;
            }
            public static Point operator --(Point p)
            {
                p.Y--;
                p.X--;
                return p;
            }
            #endregion

            #region Бінарні оператори
            public static Point operator +(Point p1, Point p2)
            {
                Point p3 = new Point
                {
                    X = p1.X + p2.X,
                    Y = p1.Y + p2.Y
                };
                return p3;
            }
            public static Point operator -(Point p1, Point p2)
            {
                Point p3 = new Point
                {
                    X = p1.X - p2.X,
                    Y = p1.Y - p2.Y
                };
                return p3;
            }
            public static Point operator *(Point p1, Point p2)
            {
                Point p3 = new Point
                {
                    X = p1.X * p2.X,
                    Y = p1.Y * p2.Y
                };
                return p3;
            }
            public static Point operator /(Point p1, Point p2)
            {
                Point p3 = new Point
                {
                    X = p1.X / p2.X,
                    Y = p1.Y / p2.Y
                };
                return p3;
            }
            #endregion

            #region Оператори відношення
            // Override Equals and GetHashCode
            public override bool Equals(object obj)
            {
                Point point = obj as Point;
                return this.X == point?.X && Y == point?.Y;
                //return point != null &&
                //       x == point.x &&
                //       y == point.y;
            }
            // in pair
            public override int GetHashCode()
            {
                var hashCode = 1861411795;
                hashCode = hashCode * -1521134295 + X.GetHashCode();
                hashCode += hashCode * -1521134295 + Y.GetHashCode();
                return hashCode;
            }

            public static bool operator ==(Point p1, Point p2)
            {
                return p1.Equals(p2);
            }
            // in pair
            public static bool operator !=(Point p1, Point p2)
            {
                return !(p1 == p2);
            }
            #endregion

            #region Логічні оператори       
            public static bool operator >(Point p1, Point p2)
            {
                return p1.X + p1.Y > p2.X + p2.Y;
            }
            // in pair
            public static bool operator <(Point p1, Point p2)
            {
                return !(p1 > p2);
            }

            public static bool operator >=(Point p1, Point p2)
            {
                return p1.X + p1.Y >= p2.X + p2.Y;
            }
            // in pair
            public static bool operator <=(Point p1, Point p2)
            {
                return !(p1 >= p2);
            }
            #endregion

            #region true/false operators
            public static bool operator true(Point p)
            {
                return p.X != 0 || p.Y != 0;
            }
            // in pair
            public static bool operator false(Point p)
            {
                return p.X == 0 && p.Y == 0;
            }
            #endregion

            #region Оператори приведення типу
            public static explicit operator int(Point p)
            {
                return p.X + p.Y;
            }
            public static implicit operator double(Point p)
            {
                return p.X + p.Y;
            }
            public static implicit operator Point3D(Point p)
            {
                return new Point3D(p.X, p.Y, 0);
            }
            #endregion
        }

    }
}
