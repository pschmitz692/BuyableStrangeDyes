using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuyableStrangeDyes.NPC
{
    internal class StrangeDyeTrader : GlobalNPC
    {
        static short[] strangeDyes = {
            ItemID.AcidDye,
            ItemID.BlueAcidDye,
            ItemID.RedAcidDye,
            ItemID.ChlorophyteDye,
            ItemID.GelDye,
            ItemID.MushroomDye,
            ItemID.GrimDye,
            ItemID.HadesDye,
            ItemID.BurningHadesDye,
            ItemID.ShadowflameHadesDye,
            ItemID.LivingOceanDye,
            ItemID.LivingFlameDye,
            ItemID.LivingRainbowDye,
            ItemID.MartianArmorDye,
            ItemID.MidnightRainbowDye,
            ItemID.MirageDye,
            ItemID.NegativeDye,
            ItemID.PixieDye,
            ItemID.PhaseDye,
            ItemID.PurpleOozeDye,
            ItemID.ReflectiveDye,
            ItemID.ReflectiveCopperDye,
            ItemID.ReflectiveGoldDye,
            ItemID.ReflectiveObsidianDye,
            ItemID.ReflectiveMetalDye,
            ItemID.ReflectiveSilverDye,
            ItemID.ShadowDye,
            ItemID.ShiftingSandsDye,
            ItemID.DevDye,
            ItemID.TwilightDye,
            ItemID.WispDye,
            ItemID.InfernalWispDye,
            ItemID.UnicornWispDye
                };

        public override void ModifyShop(NPCShop shop)
        {
            if(shop.NpcType == NPCID.DyeTrader) {
                foreach(short itemid in strangeDyes) { 
                    shop.Add(new Item(itemid) { shopCustomPrice = 1000000 }, Condition.Hardmode);
                }
            }
        }
    }
}
