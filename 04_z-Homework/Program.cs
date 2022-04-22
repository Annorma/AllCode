using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _04_z_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Rectangle r1 = new Rectangle(5, 12);
            WriteLine(r1);

            Square s1 = new Square(3, 6);
            WriteLine(s1);

            SealedShape sealedshape = new SealedShape(new Rectangle(6, 15), new Square(12, 15));
            WriteLine(sealedshape);



            WriteLine("\n\nEnd...");
            ReadKey();
            */


        } //--------------------Main--------------------↑

        /*
        abstract class Shape
        {
            public abstract double GetArea();
        };

        class Rectangle : Shape
        {
            public int A { get; set; }
            public int B { get; set; }
            public Rectangle() : this(0, 0) { }
            public Rectangle(int a, int b)
            {
                A = a;
                B = b;
            }
            public override double GetArea()
            {
                return A * B;
            }

            public override string ToString()
            {
                return $"\nName: Rectangle\nA: {A}cm\nB: {B}cm\nArea: {GetArea()}cm^2";
            }
        };


        class Square : Shape
        {

            public int A { get; set; }
            public int B { get; set; }
            public Square() : this(0, 0) { }
            public Square(int a, int b)
            {
                A = a;
                B = b;
            }
            public override double GetArea()
            {
                return A * B;
            }

            public override string ToString()
            {
                return $"\nName: Square\nA: {A}cm\nB: {B}cm\nArea: {GetArea()}cm^2";
            }

        };

        class SealedShape : Shape
        {
            Shape[] shapes;

            public SealedShape(params Shape[] arr)
            {
                shapes = arr;
            }
            public override double GetArea()
            {
                double rez = 0;
                foreach (var item in shapes)
                {
                    rez += item.GetArea();
                }
                return rez;
            }

            public override string ToString()
            {
                string str = "";
                foreach (var item in shapes)
                {
                    str += new string('_', 15);
                    str += item + "\n";
                }
                str += $"\nSealedShape's area: {GetArea()}cm^2\n";
                return str;
            }
        }
        */


    } //--------------------Program--------------------↑
} //--------------------Namespace--------------------↑
