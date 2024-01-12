using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace BuyableStrangeDyes
{
    internal class ModConfiguration : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(true)]
        public bool useGlobalPrice;

        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int DyePrice;

        //TODO: Implement configurable prices per dye
        //TODO: Implement ability to enable dyes pre-Hardmode
    }
}
