using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PlusSigil.Items.Consumables
{
    public class ManaNull : ModItem
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
            DisplayName.SetDefault("Mana Nullifier Sigil");
            //DisplayName.AddTranslation(GameCulture.Polish, "100 Health Sigil");
			Tooltip.SetDefault("Activating this will completely remove your mana.");
		}
		
		public override bool UseItem(Player player) 
		{
			player.statManaMax = 0;
			if (Main.myPlayer == player.whoAmI) {
				// This spawns the green numbers showing the heal value and informs other clients as well.
				player.HealEffect(player.statManaMax, true);
			}
			return true;
		}
    }
}