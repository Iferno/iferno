﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace iferno
{
    public class BlockFeuer:Block
    {
        public BlockFeuer(Map map,int x, int y):base(map,x,y,Color.White,Settings.Textures["block-feuer"])
        {
           
        }
    }
}