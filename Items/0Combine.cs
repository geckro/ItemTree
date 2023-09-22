using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class OreTrophy : ModItem
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
                .AddIngredient<Copper>()
                .AddIngredient<Tin>()
                .AddIngredient<Iron>()
                .AddIngredient<Lead>()
                .AddIngredient<Silver>()
                .AddIngredient<Tungsten>()
                .AddIngredient<Gold1>()
                .AddIngredient<Gold2>()
                .AddIngredient<Platinum>()
                .AddIngredient<DemonitePreSkele>()
                .AddIngredient<CrimtanePreSkele>()
                .AddIngredient<Hellstone>()
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }

    public class GemTrophy : ModItem
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
                .AddIngredient<Amethyst>()
                .AddIngredient<Topaz>()
                .AddIngredient<Sapphire>()
                .AddIngredient<Emerald>()
                .AddIngredient<Ruby>()
                .AddIngredient<Diamond>()
                .AddIngredient<Amber>()
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }

    public class HardmodeOreTrophy : ModItem
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
                .AddIngredient<Cobalt>()
                .AddIngredient<Palladium>()
                .AddIngredient<Mythril>()
                .AddIngredient<Orichalcum>()
                .AddIngredient<Adamantite>()
                .AddIngredient<Titanium>()
                .AddTile(TileID.Autohammer)
                .Register();
        }
    }

    public class WoodenMansion : ModItem
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
                .AddIngredient<WoodHouse>()
                .AddIngredient<EbonwoodHouse>()
                .AddIngredient<PalmWoodHouse>()
                .AddIngredient<ShadewoodHouse>()
                .AddIngredient<AshWoodHouse>()
                .AddIngredient<PearlwoodHouse>()
                .AddIngredient<CactusHouse>()
                .AddIngredient<MahoganyHouse>()
                .AddIngredient<BorealHouse>()
                .AddIngredient<GlowingMushroomHouse>()
                .AddIngredient<DynastyWoodHouse>()
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class MonsterMansion : ModItem
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
                .AddIngredient<SpiderHouse>()
                .AddIngredient<LesionHouse>()
                .AddIngredient<FleshHouse>()
                .AddIngredient<SlimeHouse>()
                .AddIngredient<BoneHouse>()
                .AddIngredient<LihzahrdHouse>()
                .AddIngredient<SpookyHouse>()
                .AddIngredient<BlueDungeonHouse>()
                .AddIngredient<PinkDungeonHouse>()
                .AddIngredient<GreenDungeonHouse>()
                .AddTile(TileID.MeatGrinder)
                .Register();
        }
    }

    public class OtherwordlyMansion : ModItem
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
                .AddIngredient<SolarHouse>()
                .AddIngredient<VortexHouse>()
                .AddIngredient<NebulaHouse>()
                .AddIngredient<MartianHouse>()
                .AddIngredient<StardustHouse>()
                .AddIngredient<MeteorHouse>()
                .AddIngredient<SkywareHouse>()
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class BlockMansion : ModItem
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
                .AddIngredient<SandstoneHouse>()
                .AddIngredient<SteampunkHouse>()
                .AddIngredient<HoneyHouse>()
                .AddIngredient<GoldenHouse>()
                .AddIngredient<BambooHouse>()
                .AddIngredient<BalloonHouse>()
                .AddIngredient<ReefHouse>()
                .AddIngredient<MarbleHouse>()
                .AddIngredient<GraniteHouse>()
                .AddIngredient<LivingWoodHouse>()
                .AddIngredient<GlassHouse>()
                .AddIngredient<CrystalHouse>()
                .AddIngredient<FrozenHouse>()
                .AddIngredient<GothicHouse>()
                .AddIngredient<PineTreeHouse>()
                .AddIngredient<ObsidianHouse>()
                .AddIngredient<PumpkinHouse>()
                .AddIngredient<NebulaHouse>()
                .AddIngredient<StardustHouse>()
                .AddIngredient<MeteorHouse>()
                .AddIngredient<SkywareHouse>()
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class HouseInAHouseInAHouse : ModItem
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
                .AddIngredient<BlockMansion>()
                .AddIngredient<OtherwordlyMansion>()
                .AddIngredient<WoodenMansion>()
                .AddIngredient<MonsterMansion>()
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}