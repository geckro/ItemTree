using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Eye2 : ModItem
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
                .AddIngredient(ItemID.EyeOfCthulhuPetItem)
                .AddIngredient(ItemID.EoCShield)
                .AddIngredient(ItemID.EyeofCthulhuTrophy)
                .AddIngredient(ItemID.EyeOfCthulhuBossBag)
                .AddIngredient(ItemID.EyeofCthulhuMasterTrophy)
                .AddIngredient(ItemID.EyeMask)
                .AddIngredient(ItemID.Binoculars)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
    
    public class Dryad : ModItem
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
                .AddIngredient(ItemID.PurificationPowder)
                .AddIngredient(ItemID.GrassSeeds)
                .AddIngredient(ItemID.CorruptSeeds)
                .AddIngredient(ItemID.CrimsonSeeds)
                .AddIngredient(ItemID.AshGrassSeeds)
                .AddIngredient(ItemID.DirtRod)
                .AddIngredient(ItemID.PumpkinSeed)
                .AddIngredient(ItemID.GrassWall)
                .AddIngredient(ItemID.CorruptGrassEcho)
                .AddIngredient(ItemID.CrimsonGrassEcho)
                .AddIngredient(ItemID.FlowerWall)
                .AddIngredient(ItemID.DayBloomPlanterBox)
                .AddIngredient(ItemID.BlinkrootPlanterBox)
                .AddIngredient(ItemID.DontHurtNatureBook)
                .AddIngredient(ItemID.FlowerPacketBlue)
                .AddIngredient(ItemID.FlowerPacketMagenta)
                .AddIngredient(ItemID.FlowerPacketRed)
                .AddIngredient(ItemID.FlowerPacketPink)
                .AddIngredient(ItemID.FlowerPacketViolet)
                .AddIngredient(ItemID.FlowerPacketWhite)
                .AddIngredient(ItemID.FlowerPacketWild)
                .AddIngredient(ItemID.FlowerPacketTallGrass)
                .AddIngredient(ItemID.FlowerPacketYellow)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
    
    public class PumpkinHouse : ModItem
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
                .AddIngredient(ItemID.PumpkinBathtub)
                .AddIngredient(ItemID.PumpkinBed)
                .AddIngredient(ItemID.PumpkinCandelabra)
                .AddIngredient(ItemID.PumpkinCandle)
                .AddIngredient(ItemID.PumpkinChair)
                .AddIngredient(ItemID.PumpkinChandelier)
                .AddIngredient(ItemID.PumpkinChest)
                .AddIngredient(ItemID.PumpkinClock)
                .AddIngredient(ItemID.PumpkinDoor)
                .AddIngredient(ItemID.PumpkinDresser)
                .AddIngredient(ItemID.PumpkinLamp)
                .AddIngredient(ItemID.PumpkinLantern)
                .AddIngredient(ItemID.PumpkinPlatform)
                .AddIngredient(ItemID.PumpkinSink)
                .AddIngredient(ItemID.PumpkinSofa)
                .AddIngredient(ItemID.PumpkinTable)
                .AddIngredient(ItemID.PumpkinWall)
                .AddIngredient(ItemID.PumpkinWorkBench)
                .AddIngredient(ItemID.ToiletPumpkin)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}