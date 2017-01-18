using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housePrice
{
    class housePrice
    {
        static void Main(string[] args)
        {
            double smallerRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricePerSqrtM = double.Parse(Console.ReadLine());

            double bathroom = smallerRoom / 2.00;
            double middleRoom = (smallerRoom / 10.00) + smallerRoom;
            double biggestRoom = (middleRoom / 10.00) + middleRoom;

            double house = (smallerRoom + kitchen + bathroom + middleRoom + biggestRoom);
            house = (house / 20.00) + house;
            double price = house * pricePerSqrtM;
            Console.WriteLine("{0:f2}", price);
        }
    }
}
