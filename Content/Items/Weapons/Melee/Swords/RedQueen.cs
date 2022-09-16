﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using VoidArsenal.Content.Buffs;

namespace VoidArsenal.Content.Items.Weapons.Melee.Swords
{
    public class RedQueen : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("RedQueen");
        }
        public override void SetDefaults()
        {
            Item.width = 80;
            Item.height = 80;
            Item.DamageType = DamageClass.Melee;
            Item.crit = 10;
            Item.damage = 20;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            player.AddBuff(ModContent.BuffType<QueensBlessing>(), 180);
        }
    }
}
