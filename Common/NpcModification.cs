﻿using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using VoidArsenal.Content.Items.Materials;

namespace VoidArsenal.Common
{
    public class NpcModification : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if(npc.type == NPCID.RedSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AdamantiteFragment>(), 10,1,3));
            }
        }
    }
}
