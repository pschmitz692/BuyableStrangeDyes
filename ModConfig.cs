//using System;
//using System.Collections.Generic;
using System.ComponentModel;
//using Terraria;
//using Terraria.ModLoader;
using Terraria.ModLoader.Config;
//using Terraria.ModLoader.Config.UI;


namespace BuyableStrangeDyes
{
    internal class ModConfiguration : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Tooltip("The cost of Strange Dyes in copper coins")]
        [Range(1, 100000000)]
        [DefaultValue(1000000)]
        [ReloadRequired]
        public int DyePrice;

    }
}
