using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaNavigation;

namespace C__OAIP_LABA_5_ZADANIE_2
{
    
    
       public class PointGeo
        {
            public Koord Latitude { get; set; }
            public Koord Longitude { get; set; }

            public PointGeo(Koord lat, Koord lon)
            {
                Latitude = lat;
                Longitude = lon;
            }

            
            public double DistanceTo(PointGeo other)
            {
                double lat1 = Latitude.ToDecimal();
                double lat2 = other.Latitude.ToDecimal();

                double lon1 = Longitude.ToDecimal();
                double lon2 = other.Longitude.ToDecimal();

                double dLat = lat2 - lat1;
                double dLon = lon2 - lon1;

                
                double avgLatRad = ((lat1 + lat2) / 2.0) * Math.PI / 180.0;

                double kmLat = dLat * 111.0;
                double kmLon = dLon * 111.0 * Math.Cos(avgLatRad);

                return Math.Sqrt(kmLat * kmLat + kmLon * kmLon);
            }
        }

    }

