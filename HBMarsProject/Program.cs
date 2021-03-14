using HBMarsProject.Enum;
using HBMarsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBMarsProject
{
    public class Program
    {
        static int CoordinateX, CoordinateY;

        static void Main(string[] args)
        {

            Console.Write("Plato X Y Boyutu: ");
            string getCoordinate = Console.ReadLine();
            CoordinateX = Convert.ToInt32(getCoordinate.Split(' ')[0]);
            CoordinateY = Convert.ToInt32(getCoordinate.Split(' ')[1]);

            int[,] setMatrix = new int[CoordinateX, CoordinateY]; //5x5 Matris Oluştu


            for (int k = 1; k <= 2; k++)
            {
                Console.Write($"{k}. Gezici pozisyonu giriniz: ");
                var getPosition = Console.ReadLine();

                Position p = new Position();
                p.X = Convert.ToInt32(getPosition.Split(' ')[0]);
                p.Y = Convert.ToInt32(getPosition.Split(' ')[1]);
                p.Direction = ConvertEnum(Convert.ToChar(getPosition.Split(' ')[2]));
                Rover rover = new Rover();
                rover.setRoverPosition(p); //1 2 N olarak setlendi.

                Console.Write($"{k}. Kesif talimatlarini giriniz: ");
                var discovery = Console.ReadLine(); //LMLMLMLMM girişi yapıldı.

                rover.MoveDiscovery(rover, discovery, CoordinateX, CoordinateY);
                
                Console.WriteLine($"{k}. Kesif Aracinin Konumu: {rover.PositionX} {rover.PositionY} {rover.direction}");
            }

            Console.Write("Çıkmak için bir tuşa basınız");
            Console.ReadKey();
        }

        public static DirectionEnum ConvertEnum(char c)
        {
            switch (c)
            {
                case 'N':
                    return DirectionEnum.N;
                case 'S':
                    return DirectionEnum.S;
                case 'E':
                    return DirectionEnum.E;
                case 'W':
                    return DirectionEnum.W;
                default:
                    return DirectionEnum.W;
            }

        }

    }
}
