using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingandlearning
{
    class Point
    {
        //constructor
        public Point(int startX, int startY)
        {
            _x = startX;
            _y = startY;
        }

        int _x;

        public int GetX()
        {
            return _x;
        }

        int _y;

        public int GetY()
        {
            return _y;
        }
    }

    class Rectangle
    {
        // width
        //private float _width;

        //public float GetWidth()
        //{
        //    return _width;
        //}

        //public void SetWidth(float width)
        //{
        //    //check for illegal widths
        //    _width = width;
        //}

        //property
        public float Width { get;private set; } //does all the code below
        //{
        //    //old way

            //get
            //{
            //    return _width;
            //}
            //set
            //{
            //    //if (value < 0)
            //    //{
            //    //    _width = value;
            //    //}

            //    //else
            //    //{
            //    //    _width = 0;

            //    //    Console.ForegroundColor = ConsoleColor.Red;
            //    //    Console.WriteLine("WARNING: TRIED RECT TO SET TO NEGATIVE NUMBER");
            //    //    Console.ForegroundColor = ConsoleColor.White;
            //    //}

            //    _width = value;

            //}

            
        //}


        // height
        //float _height; //gets added automatically
        public float Height { get; private set; } //auto property

        // position
        Point _position;

        // area
        public float GetArea()
        {
            return Width * Height;
        }

        // perimeter
        public float GetPerimeter()
        {
            return (Width * 2) + (Height * 2);
        }

        // corner points
      
    }
}
