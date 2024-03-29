﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 2;
            p1.Y = 3;

            Human h1; //Loome viite
            h1 = new Human(); //Loome objekti
            h1.Age = 12;
            h1.Name = "ABC";

            Point p2 = p1;
            Human h2 = h1;

            p2.X = 23;
            h2.Age = 24;

            Console.WriteLine("Point x={0}, y={1}", p1.X, p1.Y);
            Console.WriteLine("Point x={0}, y={1}", p2.X, p2.Y);

            Console.WriteLine("Human name = {0}, age = {1}", h1.Name, h1.Age);
            Console.WriteLine("Human name = {0}, age = {1}", h2.Name, h2.Age);

            //string tekst1 = "Hello world!";
            //int arv1 = 12;

            //string tekst2 = tekst1;
            //int arv2 = arv1;

            //tekst2 = "Muutsin!";
            //arv2 = 999;
            //char[] a = new char[4];
            //a[0] = 't';
            //a[1] = 'e';
            //a[2] = 'r';
            //a[3] = 'e';

            //Console.WriteLine("Arv1={0}, Arv2={1}", arv1, arv2);
            //Console.WriteLine("tekst1={0}, tekst2={1}", tekst1, tekst2);
        }
    }

    struct Point //Struct on value tüüpi, class on reference tüüpi. Nende töötlemine on erinev.
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }

    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
