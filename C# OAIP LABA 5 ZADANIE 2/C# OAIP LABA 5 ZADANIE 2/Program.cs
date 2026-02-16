using System;
using C__OAIP_LABA_5_ZADANIE_2;
namespace SeaNavigation
{
    
    public class Koord
    {
        public int Degrees { get; set; }
        public float Minutes { get; set; }
        public char Direction { get; set; } 

        public Koord(int degrees, float minutes, char direction)
        {
            Degrees = degrees;
            Minutes = minutes;
            Direction = direction;
        }

        
        public double ToDecimal()
        {
            double value = Degrees + Minutes / 60.0;

            if (Direction == 'S' || Direction == 'W')
                value = -value;

            return value;
        }

        
        public static Koord Input(string name)
        {
            Console.WriteLine($"Введите {name}:");

            Console.Write("Градусы: ");
            int deg = int.Parse(Console.ReadLine());

            Console.Write("Минуты: ");
            float min = float.Parse(Console.ReadLine());

            Console.Write("Направление (N/S/E/W): ");
            char dir = char.Parse(Console.ReadLine().ToUpper());

            return new Koord(deg, min, dir);
        }
    }
}