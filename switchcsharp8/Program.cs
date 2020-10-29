using System;

namespace switchcsharp8
{
    class Program
    {
        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }

        public static string FromRainbow(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => "Red",
                Rainbow.Orange => "Orange",
                Rainbow.Yellow => "Yellow",
                _ => "invalid color value: " + colorBand,
            };

        static void Main(string[] args) => Console.WriteLine("Color: " + FromRainbow(Rainbow.Blue));
    }
}
