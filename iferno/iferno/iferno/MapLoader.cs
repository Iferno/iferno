﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace iferno
{
    public class MapLoader
    {


        public MapLoader()
        {

        }

        public List<Block> Load(Map map,string path)
        {
            List<Block> newMap = new List<Block>();

            StreamReader reader = new StreamReader(path);
            string line;
            int y=0;
            while(!reader.EndOfStream){
                line=reader.ReadLine();

                for (int x = 0; x < line.Length; x++)
                {
                    if (line[x] == 'W')
                    {
                        newMap.Add(new BlockWasser(map, x, y));
                    }
                    if (line[x] == 'S')
                    {
                        newMap.Add(new BlockSand(map, x, y));
                    }
                    if (line[x] == 'F')
                    {
                        newMap.Add(new BlockFeuer(map, x, y));
                    }
                    if (line[x] == 'K')
                    {
                        newMap.Add(new BlockKiste(map, x, y));
                    }
                    if (line[x] == 'H')
                    {
                        newMap.Add(new BlockHolz(map, x, y));
                    }
                }
                y++;
            }

            return newMap;
        }
        
    }
}