﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace iferno
{
    public class BlockWind:Block
    {
        public BlockWind(Map map, int x, int y,Texture2D t)
            : base(map, x, y, Color.White,t)
        {
            animate = true;
            frames = 4;
            delay = 0.1f;
            dmg = -5;
            collideWithPlayer = false;
        }

        public BlockWind(Map map,int x, int y):base(map,x,y,Color.White,Settings.Textures["block-windlinks"])
        {
            animate = true;
            frames = 4;
            delay = 0.1f;
            dmg = -5;
            collideWithPlayer = false;
        }

        public override Rectangle Collision()
        {
            Rectangle collision = base.Collision();
            collision.Y = collision.Y + (collision.Height*2/3);
            collision.Height = collision.Height * 1 / 3; 
            return collision;
        }
        public override void OnCollisionWithPlayer(Player p)
        {
            p.changeHP(dmg);
        }
    }
}
