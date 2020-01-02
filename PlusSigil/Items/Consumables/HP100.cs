using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PlusSigil.Items.Consumables
{
    public class HP100 : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 1;
            item.rare = -12;
            item.useAnimation = 75;
            item.useTime = 75;
            item.useStyle = 4;
            item.UseSound = SoundID.Item4;
            item.consumable = false;
            item.value = 0;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("100 Health Sigil");
            //DisplayName.AddTranslation(GameCulture.Polish, "100 Health Sigil");
			Tooltip.SetDefault("Activating this item will cap your maximum life at 100.\nNo going back!\n\nRight click to switch to the 10 Health Sigil");
		}
		
		public override bool UseItem(Player player) 
		{
			player.statLifeMax = 100;
			if (Main.myPlayer == player.whoAmI) {
				// This spawns the green numbers showing the heal value and informs other clients as well.
				player.HealEffect(100, true);
			}
			return true;
		}
	
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(ModContent.ItemType<Items.Consumables.HP10>(), 1);
			//if(Main.rand.Next(6) == 0)
			//{
			//	player.QuickSpawnItem(ItemID.SlimeCrown);
			//}
		}
		
    }
}