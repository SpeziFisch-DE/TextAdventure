﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure.Maps
{
    class Map
    {
        public string title;
        public string advDescription;
        public int[] size;
        public int[] startPos;
        public int playercount;
        public int[] playerturns;
        public Tile[,] tiles;

        public Map(string title, string advDescription, int[] size, int[] startPos)
        {
            this.title = title;
            this.advDescription = advDescription;
            this.size = size;
            this.startPos = startPos;
            tiles = new Tile[size[0], size[1]];
        }

        public string[] getMapSymbols()
        {
            string[] returnArray = new string[this.size[0]];

            for (int i = 0; i < this.size[0]; i++)
            {
                for (int j = 0; j < this.size[1]; j++)
                {
                    returnArray[i] += this.tiles[i,j].mapsymbol;
                }
                
            }

            return returnArray;
        }

        public static Map getTestMap()
        {
            Map testmap = new Map("Testmap", "A map for testing purposes",new int[]{16,18}, new int[] {0,0});
            for (int i = 0; i < testmap.size[0]; i++)
            {
                for (int j = 0; j < testmap.size[1]; j++)
                {
                    testmap.tiles[i, j] = new Tile("a desciption for i: " + i + " j: " + j, 'X', "I interacted at x: " + i + " y: " + j);
                }

            }
            testmap.playercount = 0;
            testmap.playerturns = new int[] { 53, 44, 123, 456, 331, 69, 420 };
            return testmap;
        }

        public string[] getStatistics()
        {
            string[] returnString = new string[2];
            returnString[0] = playercount.ToString();
            returnString[1] = playerturns.Average().ToString();

            return returnString;
        }

    }
}
