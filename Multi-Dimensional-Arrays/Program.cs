using System;
using System.Text;

namespace Multi_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] results = new int[10, 10];

            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    results[i,j] = (i + 1) * (j + 1);
                    Console.Write("{0,4}", results[i, j]);
                }
                Console.WriteLine();
            //output
                1   2   3   4   5   6   7   8   9  10
                2   4   6   8  10  12  14  16  18  20
                3   6   9  12  15  18  21  24  27  30
                4   8  12  16  20  24  28  32  36  40
                5  10  15  20  25  30  35  40  45  50
                6  12  18  24  30  36  42  48  54  60
                7  14  21  28  35  42  49  56  63  70
                8  16  24  32  40  48  56  64  72  80
                9  18  27  36  45  54  63  72  81  90
                0  20  30  40  50  60  70  80  90 100
            }
            */

            TerrianEnum[,] map =
            {
                {TerrianEnum.SAND, TerrianEnum.SAND, TerrianEnum.SAND,
                TerrianEnum.SAND, TerrianEnum.SAND, TerrianEnum.SAND,
                TerrianEnum.SAND, TerrianEnum.SAND, TerrianEnum.SAND,
                TerrianEnum.GRASS, TerrianEnum.GRASS, TerrianEnum.GRASS,
                TerrianEnum.GRASS, TerrianEnum.GRASS, TerrianEnum.GRASS},
                {TerrianEnum.GRASS, TerrianEnum.GRASS, TerrianEnum.GRASS,
                TerrianEnum.GRASS, TerrianEnum.GRASS, TerrianEnum.GRASS,
                TerrianEnum.WALL, TerrianEnum.WALL, TerrianEnum.WALL,
                TerrianEnum.WATER, TerrianEnum.WATER, TerrianEnum.WATER,
                TerrianEnum.WATER, TerrianEnum.WATER, TerrianEnum.WATER}
            };

            Console.OutputEncoding = UTF8Encoding.UTF8;

            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int column = 0; column < map.GetLength(0); column++)
                {
                    Console.ForegroundColor = map[row, column].GetColor();
                    Console.Write(map[row, column].GetChar() + " ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }
}
