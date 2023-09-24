using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class BeeQueen : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            // TOOD: Some of this stuff is post skele fix this shit
            CreateRecipe()
                .AddIngredient(ItemID.BeeGun)
                .AddIngredient(ItemID.BeeKeeper)
                .AddIngredient(ItemID.BeesKnees)
                .AddIngredient(ItemID.HiveWand)
                .AddIngredient(ItemID.BeeHat)
                .AddIngredient(ItemID.SweetheartNecklace)
                .AddIngredient(ItemID.BeeShirt)
                .AddIngredient(ItemID.BeePants)
                .AddIngredient(ItemID.QueenBeePetItem)
                .AddIngredient(ItemID.QueenBeeTrophy)
                .AddIngredient(ItemID.BeeMask)
                .AddIngredient(ItemID.HoneyedGoggles)
                .AddIngredient(ItemID.QueenBeeMasterTrophy)
                .AddIngredient(ItemID.QueenBeeBossBag)
                .AddIngredient(ItemID.HiveBackpack) // Hive Pack
                .AddTile(TileID.HoneyDispenser)
                .Register();
        }
    }

    public class Honeybee : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
        }

        public override void AddRecipes()
        {
            // TOOD: Some of this stuff is post skele fix this shit
            CreateRecipe()
                .AddIngredient(ItemID.HoneyComb)
                .AddIngredient(ItemID.BeeWax)
                .AddIngredient(ItemID.BeeHeadgear)
                .AddIngredient(ItemID.BeeBreastplate)
                .AddIngredient(ItemID.BeeGreaves)
                .AddIngredient(ItemID.Beenade)
                .AddIngredient(ItemID.StingerNecklace)
                .AddIngredient(ItemID.HiveFive)
                .AddIngredient(ItemID.HornetStaff)
                .AddIngredient(ItemID.HoneyBalloon)
                .AddIngredient(ItemID.BalloonHorseshoeHoney)
                .AddIngredient(ItemID.Nectar)
                .AddTile(TileID.HoneyDispenser)
                .Register();
        }
    }

    public class WitchDoctor : ModItem
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
                .AddIngredient(ItemID.ImbuingStation)
                .AddIngredient(ItemID.Blowgun)
                .AddIngredient(ItemID.PygmyNecklace)
                .AddIngredient(ItemID.FlaskofFire)
                .AddIngredient(ItemID.FlaskofParty)
                .AddIngredient(ItemID.FlaskofPoison)
                .AddTile(TileID.ImbuingStation)
                .Register();
        }

        public class Fountains : ModItem
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
                    .AddIngredient(ItemID.PureWaterFountain)
                    .AddIngredient(ItemID.DesertWaterFountain)
                    .AddIngredient(ItemID.JungleWaterFountain)
                    .AddIngredient(ItemID.IcyWaterFountain)
                    .AddIngredient(ItemID.CorruptWaterFountain)
                    .AddIngredient(ItemID.CrimsonWaterFountain)
                    .AddIngredient(ItemID.HallowedWaterFountain)
                    .AddIngredient(ItemID.BloodWaterFountain)
                    .AddIngredient(ItemID.CavernFountain)
                    .AddIngredient(ItemID.OasisFountain)
                    .AddTile(TileID.ImbuingStation)
                    .Register();
            }
        }
    }
}