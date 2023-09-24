using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Ninja : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Shuriken)
                .AddIngredient(ItemID.NinjaHood)
                .AddIngredient(ItemID.NinjaShirt)
                .AddIngredient(ItemID.NinjaPants)
                .AddTile(TileID.Solidifier)
                .Register();
        }
    }
    public class Slimy : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SlimeHook)
                .AddIngredient(ItemID.KingSlimeMask)
                .AddIngredient(ItemID.KingSlimeTrophy)
                .AddIngredient(ItemID.SlimeGun)
                .AddIngredient(ItemID.Solidifier)
                .AddIngredient(ItemID.SlimySaddle)
                .AddIngredient(ItemID.RoyalGel)
                .AddIngredient(ItemID.KingSlimePetItem)
                .AddIngredient(ItemID.SlimeBlockWall)
                .AddTile(TileID.Solidifier)
                .Register();
        }
    }

    public class SlimeHouse : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SlimeBlock)
                .AddIngredient(ItemID.SlimeBlockWall)
                .AddIngredient(ItemID.SlimeChest)
                .AddIngredient(ItemID.SlimeChair)
                .AddIngredient(ItemID.SlimeTable)
                .AddIngredient(ItemID.SlimeWorkBench)
                .AddIngredient(ItemID.SlimePlatform)
                .AddIngredient(ItemID.SlimeBed)
                .AddIngredient(ItemID.SlimeDresser)
                .AddIngredient(ItemID.SlimeDoor)
                .AddIngredient(ItemID.SlimeLantern)
                .AddIngredient(ItemID.SlimeChandelier)
                .AddIngredient(ItemID.SlimeBathtub)
                .AddIngredient(ItemID.SlimeCandle)
                .AddIngredient(ItemID.SlimeLamp)
                .AddIngredient(ItemID.SlimeCandelabra)
                .AddIngredient(ItemID.SlimeSofa)
                .AddIngredient(ItemID.SlimeClock)
                .AddIngredient(ItemID.ToiletSlime)
                .AddIngredient(ItemID.SlimeSink)
                .AddTile(TileID.Solidifier)
                .Register();
        }
    }
}