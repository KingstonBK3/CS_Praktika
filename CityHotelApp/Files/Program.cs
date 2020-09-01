using System;
using System.Linq;

namespace CityHotelApp
{
    //Muntjan Andrei PTVR18
    class Program
    {
        public class Hotel
        {
            public string City { get; set; }
            public string HotelName { get; set; }
            public string Address { get; set; }
            public string Services { get; set; }

            public override string ToString()
            {
                return $"City:{City},Hotel: {HotelName},Address: {Address},Services: {Services}";
            
            }


        }

        static void Main(string[] args)
        {
            Hotel[] hotels =
            {
                new Hotel{City="Tallinn",HotelName="Inger Hotel",Address="Hotell sohtkohas Narva",Services="Wifi,Baar,Pool,Tasuta parkimine"},
                new Hotel{City="Tallinn",HotelName="Metropol Spa Hotel",Address="Roseni 9",Services="Wifi,Baar,Pool,Tasuta parkimine,Works around the clock"},
                new Hotel{City="Tallinn",HotelName="Art Hotell",Address="Lai 18",Services="Wifi,Baar,Pool,Tasuta parkimine,Restoraan,Peretoad"},
                new Hotel{City="Tartu",HotelName="Metropol Spa Hotel",Address="Roseni 9",Services="Wifi,Baar,Pool,Tasuta parkimine,Works around the clock"},
                new Hotel{City="Tartu",HotelName="Art Hotell",Address="Lai 18",Services="Wifi,Baar,Pool,Tasuta parkimine,Restoraan,Peretoad"},
                new Hotel{City="Parnu",HotelName="Metropol Spa Hotel",Address="Roseni 9",Services="Wifi,Baar,Pool,Tasuta parkimine,Works around the clock"},
                new Hotel{City="Parnu",HotelName="Art Hotell",Address="Lai 18",Services="Wifi,Baar,Pool,Tasuta parkimine,Restoraan,Peretoad"},
                new Hotel{City="Toila",HotelName="Metropol Spa Hotel",Address="Roseni 9",Services="Wifi,Baar,Pool,Tasuta parkimine,Works around the clock"},
            };
            //For
            Console.WriteLine("\nAll hotels:");
            int n = 0;
            foreach(Hotel hotel in hotels)
            {
                n++;
                Console.WriteLine($"{n}. {hotel}");
            }
            //LinQ
            Console.WriteLine("\nTallinn hotels:");
            var selectedHotel = from hotel in hotels
                                where hotel.City=="Tallinn"
                                select hotel;
            n = 0;
            foreach(Hotel hotel in selectedHotel)
            {
                n++;
                Console.WriteLine($"{n}. {hotel}");
            }

            //....................................................
            Console.Write("Press any key.......");
            Console.ReadKey();
        }
    }
}
