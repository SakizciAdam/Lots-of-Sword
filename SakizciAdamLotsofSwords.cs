using Terraria.ModLoader;
using System;
using Terraria;
using SakizciAdamLotsofSwords.Items;
using Terraria.ID;


namespace SakizciAdamLotsofSwords
{
	class SakizciAdamLotsofSwords : Mod
	{
		public SakizciAdamLotsofSwords()
		{
		}
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + "MixedSword", new int[]
            {
                ItemType("MixedSword"),
            });
            RecipeGroup.RegisterGroup("MixedSword", group);

            RecipeGroup grou = new RecipeGroup(() => Lang.misc[37] + "InfiniteBar", new int[]
            {
                ItemType("InfiniteBar"),
            });
            RecipeGroup.RegisterGroup("InfiniteBar", grou);
        }
        

    }
}
