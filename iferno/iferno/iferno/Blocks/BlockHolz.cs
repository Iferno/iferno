﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace iferno
{
    public class BlockHolz:Block
    {
        private bool collided = false;

        public BlockHolz(Map map,int x, int y):base(map,x,y,Color.White,Settings.Textures["block-holz-baum"+Settings.Rnd.Next(0, 3)])
        {
           dmg = -10;
        }

        public override void OnCollisionWithPlayer(Player p)
        {
            if (!collided)
            {
                collided = true;
                Settings.SoundEffects["burn"].Play();
                markDestroy = true;
                burn = true;
            }
        }
    }
}
