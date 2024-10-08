﻿using TritonsHydrants.Utils;
using Terraria;
using Terraria.ModLoader;

namespace TritonsHydrants.Content.Dusts
{
    public class WaterBubble : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.velocity *= 0.4f;
            dust.noGravity = true;
            dust.scale *= 1.5f;
        }
        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.15f;
            dust.scale *= 0.95f;

            Lighting.AddLight(dust.position, Water.GetWaterColor().R / 255, Water.GetWaterColor().G / 255, Water.GetWaterColor().B / 255);

            if (dust.scale <= 1f)
            {
                dust.alpha += 4;
            }

            if (dust.alpha >= 255)
            {
                dust.active = false;
            }

            dust.color = Water.GetWaterColor();

            return false;
        }
    }
}