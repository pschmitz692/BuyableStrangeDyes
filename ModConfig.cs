using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace BuyableStrangeDyes
{
    internal class ModConfiguration : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("GlobalOptionsHeader")]

        [DefaultValue(true)]
        [ReloadRequired]
        public bool useGlobalPrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int globalDyePrice;

        [DefaultValue(false)]
        [ReloadRequired]
        public bool enablePreHardmode;

        [Header("PerDyePrices")]

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int AcidDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int BlueAcidDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int RedAcidDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ChlorophyteDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int GelDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int MushroomDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int GrimDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int HadesDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int BurningHadesDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ShadowflameHadesDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int LivingOceanDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int LivingFlameDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int LivingRainbowDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int MartianArmorDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int MidnightRainbowDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int MirageDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int NegativeDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int PixieDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int PhaseDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int PurpleOozeDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ReflectiveDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ReflectiveCopperDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ReflectiveGoldDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ReflectiveObsidianDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ReflectiveMetalDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ReflectiveSilverDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ShadowDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int ShiftingSandsDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int DevDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int TwilightDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int WispDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int InfernalWispDyePrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int UnicornWispDyePrice;

        //TODO: Implement configurable prices per dye
        //TODO: Implement ability to enable dyes pre-Hardmode
    }
}
