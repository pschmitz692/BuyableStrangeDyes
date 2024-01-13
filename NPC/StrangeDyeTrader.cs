using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BuyableStrangeDyes.NPC
{
    internal class StrangeDyeTrader : GlobalNPC
    {
        static ModConfiguration modConfig = ModContent.GetInstance<ModConfiguration>();

        static int[,] strangeDyes = {
            { ItemID.AcidDye, modConfig.AcidDyePrice},
            { ItemID.BlueAcidDye, modConfig.BlueAcidDyePrice},
            { ItemID.RedAcidDye, modConfig.RedAcidDyePrice},
            { ItemID.ChlorophyteDye, modConfig.ChlorophyteDyePrice},
            { ItemID.GelDye, modConfig.GelDyePrice},
            { ItemID.MushroomDye, modConfig.MushroomDyePrice},
            { ItemID.GrimDye, modConfig.GrimDyePrice},
            { ItemID.HadesDye, modConfig.HadesDyePrice},
            { ItemID.BurningHadesDye, modConfig.BurningHadesDyePrice},
            { ItemID.ShadowflameHadesDye, modConfig.ShadowflameHadesDyePrice},
            { ItemID.LivingOceanDye, modConfig.LivingOceanDyePrice},
            { ItemID.LivingFlameDye, modConfig.LivingFlameDyePrice},
            { ItemID.LivingRainbowDye, modConfig.LivingRainbowDyePrice},
            { ItemID.MartianArmorDye, modConfig.MartianArmorDyePrice},
            { ItemID.MidnightRainbowDye, modConfig.MidnightRainbowDyePrice},
            { ItemID.MirageDye, modConfig.MirageDyePrice},
            { ItemID.NegativeDye, modConfig.NegativeDyePrice},
            { ItemID.PixieDye, modConfig.PixieDyePrice},
            { ItemID.PhaseDye, modConfig.PhaseDyePrice},
            { ItemID.PurpleOozeDye, modConfig.PurpleOozeDyePrice},
            { ItemID.ReflectiveDye, modConfig.ReflectiveDyePrice},
            { ItemID.ReflectiveCopperDye, modConfig.ReflectiveCopperDyePrice},
            { ItemID.ReflectiveGoldDye, modConfig.ReflectiveGoldDyePrice},
            { ItemID.ReflectiveObsidianDye, modConfig.ReflectiveObsidianDyePrice},
            { ItemID.ReflectiveMetalDye, modConfig.ReflectiveMetalDyePrice},
            { ItemID.ReflectiveSilverDye, modConfig.ReflectiveSilverDyePrice},
            { ItemID.ShadowDye, modConfig.ShadowDyePrice},
            { ItemID.ShiftingSandsDye, modConfig.ShiftingSandsDyePrice},
            { ItemID.DevDye, modConfig.DevDyePrice},
            { ItemID.TwilightDye, modConfig.TwilightDyePrice},
            { ItemID.WispDye, modConfig.WispDyePrice},
            { ItemID.InfernalWispDye, modConfig.InfernalWispDyePrice},
            { ItemID.UnicornWispDye, modConfig.UnicornWispDyePrice}
                };

        public override void ModifyShop(NPCShop shop)
        {
            //Retrieve price from config
            var useGlobalPrice = modConfig.useGlobalPrice;
            var DyePrice = modConfig.globalDyePrice;
            var enablePreHardmode = modConfig.enablePreHardmode;

            if(shop.NpcType == NPCID.DyeTrader) {
                if(useGlobalPrice) {
                    for (int i = 0; i < strangeDyes.GetLength(0); i++) {
                        int itemid = strangeDyes[i, 0];
                        shop.Add(new Item(itemid) { shopCustomPrice = DyePrice }, enablePreHardmode ? Condition.NpcIsPresent(NPCID.DyeTrader) : Condition.Hardmode);    //Needed another condition to always be true if prehardmode enabled
                    }
                } else {
                    for (int i = 0; i < strangeDyes.GetLength(0); i++) {
                        int itemid = strangeDyes[i, 0];
                        shop.Add(new Item(itemid) { shopCustomPrice = strangeDyes[i, 1] }, enablePreHardmode ? Condition.NpcIsPresent(NPCID.DyeTrader) : Condition.Hardmode);
                    }
                }
            }
        }
    }
}
