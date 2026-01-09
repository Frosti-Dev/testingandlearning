using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace testingandlearning
{
    class Program
    {
        //structs and classes

        //scrcut == value type
        //class == reference type

        //struct Point //could also be class. Functionally they are the same thing.
        //{
        //    //constructor
        //    public Point(int startX, int startY)
        //    {
        //        _x = startX;
        //        _y = startY;
        //    }

        //    int _x;

        //    public int GetX()
        //    {
        //        return _x;
        //    }

        //    int _y;

        //    public int GetY()
        //    {
        //        return _y;
        //    }

        //}

        //class Rupee
        //{
        //    //constructor
        //    //contructor is a special method that gets called when we instantiate a rupee.
        //    public Rupee(Point position, ConsoleColor color, int moneyValue)
        //    {
        //        _position = position;
        //        _color = color; 
        //        _moneyValue = moneyValue;
        //    }

        //    Point _position;
        //    public Point GetPosition()
        //    {
        //        return _position;
        //    }

        //    ConsoleColor _color;
        //    public ConsoleColor GetColor()
        //    {
        //        return _color;
        //    }

        //    int _moneyValue;
        //    public int GetMoneyValue()
        //    {
        //        return _moneyValue;
        //    }
        //}

        static void Main(string[] args)
        {
            //Point p = new Point(10, 20);

            //p._x = 100;
            //p._y = 200;

            //Point rupeeSpawnPos = new Point(startX: 5, startY: 5);
            //Rupee myRupee = new Rupee(
            //    position: rupeeSpawnPos, 
            //    color: ConsoleColor.Green, 
            //    moneyValue: 10
            //    );
            //do this if line is too long



            //Console.BackgroundColor = myRupee.GetColor();

            //Point rupeePoint = myRupee.GetPosition();
            //Console.SetCursorPosition(rupeePoint.GetX(), rupeePoint.GetY());

            //Console.Write(" ");
            //Console.ReadKey();

            //rectangle class in another file

            Rectangle rect = new Rectangle();


            float recWidth = rect.Width;

            Console.ReadKey();      

        }
    }
}
