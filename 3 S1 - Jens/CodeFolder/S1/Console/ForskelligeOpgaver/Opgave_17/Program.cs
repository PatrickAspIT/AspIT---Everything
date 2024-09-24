using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box newBox = new Box();

            newBox.Height = 40;
            newBox.Length = 60;
            newBox.Width = 20;

            newBox.CalculateVolume();
            newBox.CalculateSurface();
            newBox.PrintInfo();

            Console.ReadLine();
        }

    }
}
