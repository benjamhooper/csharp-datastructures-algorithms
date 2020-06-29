using System;

namespace Multi_Dimensional_Arrays
{
   public enum TerrianEnum 
    {
        GRASS,
        SAND,
        WATER,
        WALL
    } 
    public static class TerrainEnumExtenensions
        {
            public static ConsoleColor GetColor(this TerrianEnum terrian)
            {
                switch (terrian)
                {
                    case TerrianEnum.GRASS: return ConsoleColor.Green;
                    case TerrianEnum.SAND: return ConsoleColor.Yellow;
                    case TerrianEnum.WATER: return ConsoleColor.Blue;
                    default: return ConsoleColor.DarkGray;
                }
            }
            public static char GetChar(this TerrianEnum terrian)
            {
                switch (terrian)
                {
                    case TerrianEnum.GRASS: return '\u201c';
                    case TerrianEnum.SAND: return '\u25cb';
                    case TerrianEnum.WATER: return '\u2248';
                    default: return '\u25cf';
                }
            }
        }
}
