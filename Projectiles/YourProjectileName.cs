using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YourModName.Projectiles
{

    public class YourProjectileName : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "YourProjectileName";  //projectile name
            projectile.width = 20;       //projectile width
            projectile.height = 28;  //projectile height
            projectile.friendly = true;      //make that the projectile will not damage you
            projectile.melee = true;         // 
            projectile.tileCollide = true;   //make that the projectile will be destroed if it hits the terrain
            projectile.penetrate = 100;      //how many npc will penetrate
            projectile.timeLeft = 2000;   //how many time this projectile has before disepire
            projectile.light = 1f;    // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;   
        }
        public override void AI()           //this make that the projectile will face the corect way
        {                                                           // |
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;  
        }
    }
}