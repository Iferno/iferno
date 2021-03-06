﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace iferno
{
    public class BlockPlatform:Block
    {
        public int timer=0;
        public bool direction = false;
        public int speed = 300;
       
        public BlockPlatform(Map map, int x, int y)
            : base(map, x, y, Color.White, Settings.Textures["block-platform"])
        {
            dmg = 100;
        }

        public override void Update(float dt)
        {
            
            
                float newX = X();
                Rectangle collsionMesh = Collision();
                
                if (direction)
                {
                    newX+=speed *dt;   
                }
                else
                {
                    newX-=speed*dt;
                }
                collsionMesh.X = (int)newX;
                foreach (Block b in map.blocks)
                {
                    if (!(b is BlockPlatform) && b.CheckCollisionWith(collsionMesh))
                    {
                        newX = X();
                        direction = !direction; //umdrehen
                    }
                }
                this.position.X = newX;
            }
        
    }
}
