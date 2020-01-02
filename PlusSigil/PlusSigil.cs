using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace PlusSigil
{
	public class PlusSigil : Mod
	{
		public PlusSigil()
		{
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.SetResult(ModContent.ItemType<Items.Consumables.HP100>());
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.SetResult(ModContent.ItemType<Items.Consumables.HP10>());
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.SetResult(ModContent.ItemType<Items.Consumables.ManaNull>());
			recipe.AddRecipe();
		}
	}
}