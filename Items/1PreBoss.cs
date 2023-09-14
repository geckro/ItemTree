
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Bomb : ModItem
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
                .AddIngredient(ItemID.Grenade)
                .AddIngredient(ItemID.Bomb)
                .AddIngredient(ItemID.BombStatue)
                .AddIngredient(ItemID.BombFish)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Dirt : ModItem
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
                .AddIngredient(ItemID.DirtBlock)
                .AddIngredient(ItemID.Dirtfish)
                .AddIngredient(ItemID.DirtiestBlock)
                .AddIngredient(ItemID.DirtWall)
                .AddIngredient(ItemID.DirtBomb)
                .AddIngredient(ItemID.CaveWall1Echo) // Cave Dirt
                .AddIngredient(ItemID.CaveWall2Echo) // Rough Dirt
                .AddIngredient(ItemID.Cave6Echo) // Rocky Dirt
                .AddIngredient(ItemID.Dirt1Echo) // Layered Dirt
                .AddIngredient(ItemID.Dirt2Echo) // Crumbling Dirt
                .AddIngredient(ItemID.Dirt3Echo) // Cracked Dirt
                .AddIngredient(ItemID.Dirt4Echo) // Wavy Dirt
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Dynamite : ModItem
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
                .AddIngredient(ItemID.Dynamite)
                .AddIngredient(ItemID.DynamiteFish)
                .AddIngredient(ItemID.Explosives)
                .AddIngredient(ItemID.TNTBarrel)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
    public class Enchanted : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.rare = ItemRarityID.Blue;
            Item.value = 9000; // 1g + 5g + 3g
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.EnchantedBoomerang)
                .AddIngredient(ItemID.Arkhalis)
                .AddIngredient(ItemID.EnchantedSword)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Goblin : ModItem
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
                .AddIngredient(ItemID.Harpoon)
                .AddIngredient(ItemID.SpikyBall)
                .AddIngredient(ItemID.GoblinScoutBanner)
                .AddIngredient(ItemID.TatteredCloth)
                .AddIngredient(ItemID.GoblinPeonBanner)
                .AddIngredient(ItemID.GoblinSorcererBanner)
                .AddIngredient(ItemID.GoblinThiefBanner)
                .AddIngredient(ItemID.GoblinWarriorBanner)
                .AddIngredient(ItemID.GoblinArcherBanner)
                .AddIngredient(ItemID.GoblinBattleStandard)
                .AddIngredient(ItemID.GoblinStatue)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
    public class Gold1 : ModItem
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
                .AddIngredient(ItemID.GoldOre)
                .AddIngredient(ItemID.GoldBar)
                .AddIngredient(ItemID.GoldPickaxe)
                .AddIngredient(ItemID.GoldAxe)
                .AddIngredient(ItemID.GoldHammer)
                .AddIngredient(ItemID.GoldBroadsword)
                .AddIngredient(ItemID.GoldShortsword)
                .AddIngredient(ItemID.GoldBow)
                .AddIngredient(ItemID.GoldHelmet)
                .AddIngredient(ItemID.GoldFrog)
                .AddIngredient(ItemID.GoldGoldfish)
                .AddIngredient(ItemID.GoldButterfly)
                .AddIngredient(ItemID.GoldDragonfly)
                .AddIngredient(ItemID.GoldChainmail)
                .AddIngredient(ItemID.GoldMouse)
                .AddIngredient(ItemID.GoldenDelight)
                .AddIngredient(ItemID.GoldGreaves)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Gold2 : ModItem
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
                .AddIngredient(ItemID.GoldBunny)
                .AddIngredient(ItemID.SquirrelGold) // Golden Squirrel
                .AddIngredient(ItemID.GoldBird)
                .AddIngredient(ItemID.GoldCrown)
                .AddIngredient(ItemID.GoldChandelier)
                .AddIngredient(ItemID.GoldBrick)
                .AddIngredient(ItemID.GoldLadyBug)
                .AddIngredient(ItemID.GoldBrickWall)
                .AddIngredient(ItemID.GoldSeahorse)
                .AddIngredient(ItemID.GoldGrasshopper)
                .AddIngredient(ItemID.GoldWatch)
                .AddIngredient(ItemID.GoldWaterStrider)
                .AddIngredient(ItemID.Candelabra)
                .AddIngredient(ItemID.Candle)
                .AddIngredient(ItemID.GoldWorm)
                .AddIngredient(ItemID.GoldCoin)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Iron : ModItem
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
                .AddIngredient(ItemID.IronOre)
                .AddIngredient(ItemID.IronBar)
                .AddIngredient(ItemID.IronPickaxe)
                .AddIngredient(ItemID.IronAxe)
                .AddIngredient(ItemID.IronHammer)
                .AddIngredient(ItemID.IronBroadsword)
                .AddIngredient(ItemID.IronShortsword)
                .AddIngredient(ItemID.IronBow)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Jellyfish : ModItem
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
                .AddIngredient(ItemID.BlueJellyfish)
                .AddIngredient(ItemID.PinkJellyfish)
                .AddIngredient(ItemID.KiteJellyfishBlue)
                .AddIngredient(ItemID.KiteJellyfishPink)
                .AddIngredient(ItemID.JellyfishBanner) // Blue Jellyfish banner
                .AddIngredient(ItemID.PinkJellyfishBanner)
                .AddIngredient(ItemID.JellyfishNecklace)
                .AddIngredient(ItemID.JellyfishStatue)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
    public class Shark : ModItem
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
                .AddIngredient(ItemID.Minishark)
                .AddIngredient(ItemID.SharkFin)
                .AddIngredient(ItemID.SharkStatue)
                .AddIngredient(ItemID.SharkBanner)
                .AddIngredient(ItemID.SharkBait)
                .AddIngredient(ItemID.ReaverShark)
                .AddIngredient(ItemID.SawtoothShark)
                .AddIngredient(ItemID.KiteShark)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Silver : ModItem
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
                .AddIngredient(ItemID.SilverOre)
                .AddIngredient(ItemID.SilverBar)
                .AddIngredient(ItemID.SilverPickaxe)
                .AddIngredient(ItemID.SilverAxe)
                .AddIngredient(ItemID.SilverHammer)
                .AddIngredient(ItemID.SilverBroadsword)
                .AddIngredient(ItemID.SilverShortsword)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}