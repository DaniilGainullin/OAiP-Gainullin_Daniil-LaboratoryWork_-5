using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SeaNavigation;

namespace C__OAIP_LABA_5_ZADANIE_2
{
    
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Первая точка:");
                Koord lat1 = Koord.Input("широту");
                Koord lon1 = Koord.Input("долготу");
                PointGeo point1 = new PointGeo(lat1, lon1);

                Console.WriteLine("\nВторая точка:");
                Koord lat2 = Koord.Input("широту");
                Koord lon2 = Koord.Input("долготу");
                PointGeo point2 = new PointGeo(lat2, lon2);

                double distance = point1.DistanceTo(point2);

                Console.WriteLine($"\nРасстояние между точками: {distance:F2} км");

                Console.ReadKey();
            }
        }
    }

