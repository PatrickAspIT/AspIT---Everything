using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_19 // KOPIERET!!!!
{
    internal class Box
    {
        // Opgave 17.1
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        // Opgave 17.2
        public void PrintInfo()
        {
            Console.WriteLine("Kassen har følgende mål:");
            Console.WriteLine("Højde: {0} cm", Height);
            Console.WriteLine("Længde: {0} cm", Length);
            Console.WriteLine("Bredde: {0} cm", Width);
            Console.WriteLine("Rumfang: {0} m3", Volume);
            Console.WriteLine("Overflade: {0} cm^2", Surface);
        }

        // Opgave 17.3
        public int Volume { get; private set; }

        public int CalculateVolume()
        {
            Volume = Width * Height * Length;
            return Volume;
        }

        // Opgave 17.4
        public int Surface { get; private set; }

        public int CalculateSurface()
        {
            Surface = 2 * Width + 2 * Height + 2 * Length;
            return Surface;
        }

        public Box()
        {

        }

        // Opgave 19.2
        public Box( int height, int length, int width)
        {
            Height = height;
            Length = length;
            Width = width;
        }
    }
}
