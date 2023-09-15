using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items.CraftingStations
{
	public class RainbowAnvil : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.RainbowAnvil>());
			Item.width = 28; // The item texture's width
			Item.height = 14; // The item texture's height
			Item.value = 1;
		}

		public override void AddRecipes() {
			CreateRecipe()
			.AddIngredient(ItemID.WorkBench)
	        .AddIngredient(ItemID.Furnace)
	        .AddIngredient(ItemID.Bookcase)
	        .AddIngredient(ItemID.Loom)
	        .AddIngredient(ItemID.Keg)
	        .AddIngredient(ItemID.AlchemyTable)
	        .AddIngredient(ItemID.TinkerersWorkshop)
	        .AddIngredient(ItemID.Bottle)
	        .AddIngredient(ItemID.BlendOMatic)
	        .AddIngredient(ItemID.MeatGrinder)
	        .AddIngredient(ItemID.AdamantiteForge)
	        .AddIngredient(ItemID.CookingPot)
	        .AddIngredient(ItemID.ImbuingStation)
	        .AddIngredient(ItemID.TitaniumForge)
	        .AddIngredient(ItemID.HeavyWorkBench)
	        .AddIngredient(ItemID.Sawmill)
	        .AddIngredient(ItemID.IronAnvil)
	        .AddIngredient(ItemID.Hellforge)
	        .AddIngredient(ItemID.Autohammer)
	        .AddIngredient(ItemID.LeadAnvil)
	        .AddIngredient(ItemID.MythrilAnvil)
	        .AddIngredient(ItemID.OrichalcumAnvil)
	        .AddIngredient(ItemID.LunarCraftingStation)
	        .AddCondition(Condition.NearWater)
	        .AddCondition(Condition.NearLava)
	        .AddCondition(Condition.NearHoney)
	        .AddCondition(Condition.NearShimmer)
			.Register();
		}
	}
}
