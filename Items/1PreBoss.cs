
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Amber : ModItem
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
                .AddIngredient(ItemID.Amber)
                .AddIngredient(ItemID.GemTreeAmberSeed) // Amber Gemcorn
                .AddIngredient(ItemID.GemBunnyAmber) // Amber Bunny
                .AddIngredient(ItemID.GemSquirrelAmber) // Amber Squirrel
                .AddIngredient(ItemID.AmberHook)
                .AddIngredient(ItemID.AmberStoneWallEcho) // Amber Stone Wall
                .AddIngredient(ItemID.AmberRobe)
                .AddIngredient(ItemID.LargeAmber)
                .AddIngredient(ItemID.AmberStaff)
                .AddIngredient(ItemID.AmberMosquito)
                .AddIngredient(ItemID.AmberStoneBlock)
                .AddIngredient(ItemID.GemLockAmber) // Amber Gem Lock
                .AddIngredient(ItemID.AmberGemsparkBlock)
                .AddIngredient(ItemID.AmberGemsparkWall)
                .AddIngredient(ItemID.AmberGemsparkWallOff)
                .AddIngredient(ItemID.OrangePhaseblade)
                .AddIngredient(ItemID.AmberBunnyCage)
                .AddIngredient(ItemID.AmberSquirrelCage)
                .AddIngredient(ItemID.AmberMinecart)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Amethyst : ModItem
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
                .AddIngredient(ItemID.Amethyst)
                .AddIngredient(ItemID.GemTreeAmethystSeed) // Amethyst Gemcorn
                .AddIngredient(ItemID.GemBunnyAmethyst) // Amethyst Bunny
                .AddIngredient(ItemID.GemSquirrelAmethyst) // Amethyst Squirrel
                .AddIngredient(ItemID.AmethystHook)
                .AddIngredient(ItemID.AmethystEcho) // Amethyst Stone Wall
                .AddIngredient(ItemID.AmethystRobe)
                .AddIngredient(ItemID.LargeAmethyst)
                .AddIngredient(ItemID.AmethystStaff)
                .AddIngredient(ItemID.AmethystStoneBlock)
                .AddIngredient(ItemID.GemLockAmethyst) // Amethyst Gem Lock
                .AddIngredient(ItemID.AmethystGemsparkBlock)
                .AddIngredient(ItemID.AmethystGemsparkWall)
                .AddIngredient(ItemID.AmethystGemsparkWallOff)
                .AddIngredient(ItemID.PurplePhaseblade)
                .AddIngredient(ItemID.AmethystBunnyCage)
                .AddIngredient(ItemID.AmethystSquirrelCage)
                .AddIngredient(ItemID.AmethystMinecart)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Antlion : ModItem
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
                .AddIngredient(ItemID.AntlionMandible)
                .AddIngredient(ItemID.WalkingAntlionBanner) // Antlion Charger Banner
                .AddIngredient(ItemID.FlyingAntlionBanner) // Antlion Swarmer Banner
                .AddIngredient(ItemID.LarvaeAntlionBanner)
                .AddIngredient(ItemID.AntlionBanner)
                .AddIngredient(ItemID.AntlionEggs)
                .AddIngredient(ItemID.AntlionClaw) // Mandible Blade
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Bat : ModItem
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
                .AddIngredient(ItemID.DepthMeter)
                .AddIngredient(ItemID.BatBanner)
                .AddIngredient(ItemID.BatBat)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
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
    public class Cactus : ModItem
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
                .AddIngredient(ItemID.Cactus)
                .AddIngredient(ItemID.CactusWall)
                .AddIngredient(ItemID.CactusPlatform)
                .AddIngredient(ItemID.RollingCactus)
                .AddIngredient(ItemID.CactusWorkBench)
                .AddIngredient(ItemID.CactusChair)
                .AddIngredient(ItemID.CactusChandelier)
                .AddIngredient(ItemID.CactusSofa)
                .AddIngredient(ItemID.CactusClock)
                .AddIngredient(ItemID.CactusBathtub)
                .AddIngredient(ItemID.CactusBed)
                .AddIngredient(ItemID.CactusDresser)
                .AddIngredient(ItemID.CactusPiano)
                .AddIngredient(ItemID.ToiletCactus)
                .AddIngredient(ItemID.CactusBookcase)
                .AddIngredient(ItemID.CactusCandelabra)
                .AddIngredient(ItemID.CactusCandle)
                .AddIngredient(ItemID.CactusBreastplate)
                .AddIngredient(ItemID.CactusHelmet)
                .AddIngredient(ItemID.CactusPickaxe)
                .AddIngredient(ItemID.CactusLeggings)
                .AddIngredient(ItemID.CactusLamp)
                .AddIngredient(ItemID.CactusLantern)
                .AddIngredient(ItemID.CactusSink)
                .AddIngredient(ItemID.CactusDoor)
                .AddIngredient(ItemID.CactusSword)
                .AddIngredient(ItemID.CactusTable)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Copper : ModItem
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
                .AddIngredient(ItemID.CopperOre)
                .AddIngredient(ItemID.CopperBar)
                .AddIngredient(ItemID.CopperBrick)
                .AddIngredient(ItemID.CopperBrickWall)
                .AddIngredient(ItemID.AncientCopperBrick)
                .AddIngredient(ItemID.AncientCopperBrickWall)
                .AddIngredient(ItemID.CopperCoin)
                .AddIngredient(ItemID.CopperPlating)
                .AddIngredient(ItemID.CopperPlatingWall)
                .AddIngredient(ItemID.CopperAxe)
                .AddIngredient(ItemID.CopperBow)
                .AddIngredient(ItemID.CopperBroadsword)
                .AddIngredient(ItemID.CopperChandelier)
                .AddIngredient(ItemID.CopperChainmail)
                .AddIngredient(ItemID.CopperGreaves)
                .AddIngredient(ItemID.CopperHammer)
                .AddIngredient(ItemID.CopperPickaxe)
                .AddIngredient(ItemID.CopperHelmet)
                .AddIngredient(ItemID.CopperShortsword)
                .AddIngredient(ItemID.CopperBroadsword)
                .AddIngredient(ItemID.CopperWatch)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Cloud : ModItem
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
                .AddIngredient(ItemID.CloudinaBottle)
                .AddIngredient(ItemID.Cloud)
                .AddTile(TileID.SkyMill)
                .Register();
        }
    }
    public class Corrupt : ModItem
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
                .AddIngredient(ItemID.UnholyArrow)
                .AddIngredient(ItemID.WormTooth)
                .AddIngredient(ItemID.EaterofSoulsBanner)
                .AddIngredient(ItemID.DevourerBanner)
                .AddIngredient(ItemID.RottenChunk)
                .AddIngredient(ItemID.Vilethorn)
                .AddIngredient(ItemID.VileMushroom)
                .AddIngredient(ItemID.VilePowder)
                .AddIngredient(ItemID.ShadowOrb)
                .AddIngredient(ItemID.WormFood)
                .AddIngredient(ItemID.EbonstoneBlock)
                .AddIngredient(ItemID.CorruptSeeds)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
    public class Crimtane : ModItem
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
                .AddIngredient(ItemID.CrimtaneOre)
                .AddIngredient(ItemID.CrimtaneBar)
                .AddIngredient(ItemID.Fleshcatcher)
                .AddIngredient(ItemID.BloodLustCluster)
                .AddIngredient(ItemID.BloodButcherer)
                .AddIngredient(ItemID.CrimsonYoyo) // Artery
                .AddIngredient(ItemID.TendonBow)
                .AddIngredient(ItemID.CrimtaneBrick)
                .AddIngredient(ItemID.CrimtaneBrickWall)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
    public class Diamond : ModItem
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
                .AddIngredient(ItemID.Diamond)
                .AddIngredient(ItemID.GemTreeDiamondSeed) // Diamond Gemcorn
                .AddIngredient(ItemID.GemBunnyDiamond) // Diamond Bunny
                .AddIngredient(ItemID.GemSquirrelDiamond) // Diamond Squirrel
                .AddIngredient(ItemID.DiamondHook)
                .AddIngredient(ItemID.DiamondEcho) // Diamond Stone Wall
                .AddIngredient(ItemID.DiamondRobe)
                .AddIngredient(ItemID.LargeDiamond)
                .AddIngredient(ItemID.DiamondStaff)
                .AddIngredient(ItemID.DiamondStoneBlock)
                .AddIngredient(ItemID.GemLockDiamond) // Diamond Gem Lock
                .AddIngredient(ItemID.ToiletDiamond)
                .AddIngredient(ItemID.DiamondGemsparkBlock)
                .AddIngredient(ItemID.DiamondGemsparkWall)
                .AddIngredient(ItemID.DiamondGemsparkWallOff)
                .AddIngredient(ItemID.WhitePhaseblade)
                .AddIngredient(ItemID.DiamondBunnyCage)
                .AddIngredient(ItemID.DiamondRing)
                .AddIngredient(ItemID.DiamondSquirrelCage)
                .AddIngredient(ItemID.DiamondMinecart)
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
                .AddIngredient(ItemID.DirtRod)
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
    public class Eye : ModItem
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
                .AddIngredient(ItemID.Lens)
                .AddIngredient(ItemID.Goggles)
                .AddIngredient(ItemID.BlackLens)
                .AddIngredient(ItemID.DemonEyeBanner)
                .AddIngredient(ItemID.SuspiciousLookingEye)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Demonite : ModItem
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
                .AddIngredient(ItemID.DemoniteOre)
                .AddIngredient(ItemID.DemoniteBar)
                .AddIngredient(ItemID.DemonBow)
                .AddIngredient(ItemID.FisherofSouls)
                .AddIngredient(ItemID.LightsBane)
                .AddIngredient(ItemID.CorruptYoyo) // Malaise
                .AddIngredient(ItemID.WarAxeoftheNight)
                .AddIngredient(ItemID.DemoniteBrick)
                .AddIngredient(ItemID.DemoniteBrickWall)
                .AddTile(TileID.DemonAltar)
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
    public class Emerald : ModItem
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
                .AddIngredient(ItemID.Emerald)
                .AddIngredient(ItemID.GemTreeEmeraldSeed) // Emerald Gemcorn
                .AddIngredient(ItemID.GemBunnyEmerald) // Emerald Bunny
                .AddIngredient(ItemID.GemSquirrelEmerald) // Emerald Squirrel
                .AddIngredient(ItemID.EmeraldHook)
                .AddIngredient(ItemID.EmeraldEcho) // Emerald Stone Wall
                .AddIngredient(ItemID.EmeraldRobe)
                .AddIngredient(ItemID.LargeEmerald)
                .AddIngredient(ItemID.EmeraldStaff)
                .AddIngredient(ItemID.EmeraldStoneBlock)
                .AddIngredient(ItemID.GemLockEmerald) // Emerald Gem Lock
                .AddIngredient(ItemID.EmeraldGemsparkBlock)
                .AddIngredient(ItemID.EmeraldGemsparkWall)
                .AddIngredient(ItemID.EmeraldGemsparkWallOff)
                .AddIngredient(ItemID.GreenPhaseblade)
                .AddIngredient(ItemID.EmeraldBunnyCage)
                .AddIngredient(ItemID.EmeraldSquirrelCage)
                .AddIngredient(ItemID.EmeraldMinecart)
                .AddTile(TileID.Anvils)
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
    public class Flame : ModItem
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
                .AddIngredient(ItemID.FlamingArrow)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
    public class Glass : ModItem
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
                .AddIngredient(ItemID.Glass)
                .AddIngredient(ItemID.GlassBowl)
                .AddIngredient(ItemID.Bottle)
                .AddTile(TileID.GlassKiln)
                .Register();
        }
    }
    public class Glowing : ModItem
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
                .AddIngredient(ItemID.Shroomerang)
                .AddIngredient(ItemID.GlowingMushroom)
                .AddIngredient(ItemID.MushroomGrassSeeds)
                .AddIngredient(ItemID.SporeSkeletonBanner)
                .AddIngredient(ItemID.SporeBatBanner)
                .AddIngredient(ItemID.ShroomMinecart)
                .AddIngredient(ItemID.MushroomHat)
                .AddIngredient(ItemID.MushroomVest)
                .AddIngredient(ItemID.MushroomPants)
                .AddTile(TileID.WorkBenches)
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
    public class Golf : ModItem
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
                .AddIngredient(ItemID.GolfBall)
                .AddIngredient(ItemID.GolfTee)
                .AddIngredient(ItemID.GolfWhistle)
                .AddIngredient(ItemID.GolfCup)
                .AddIngredient(ItemID.GolfHat) // Country Club Cap
                .AddIngredient(ItemID.GolfShirt) // Country Club Vest
                .AddIngredient(ItemID.GolfPants) // Country Club Trousers
                .AddIngredient(ItemID.GolfVisor) // Country Club Visor
                .AddTile(TileID.WorkBenches)
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
                .AddIngredient(ItemID.AncientGoldBrick)
                .AddIngredient(ItemID.AncientGoldBrickWall)
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
    public class Green : ModItem
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
                .AddIngredient(ItemID.GreenBanner)
                .AddIngredient(ItemID.HermesBoots)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
    public class Gunslinger : ModItem
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
                .AddIngredient(ItemID.FlintlockPistol)
                .AddIngredient(ItemID.Musket)
                .AddIngredient(ItemID.MusketBall)
                .AddIngredient(ItemID.Boomstick)
                .AddTile(TileID.Bottles)
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
                .AddIngredient(ItemID.IronBrick)
                .AddIngredient(ItemID.IronBrickWall)
                .AddIngredient(ItemID.WroughtIronFence)
                .AddIngredient(ItemID.IronBar)
                .AddIngredient(ItemID.IronPickaxe)
                .AddIngredient(ItemID.IronAxe)
                .AddIngredient(ItemID.IronHammer)
                .AddIngredient(ItemID.IronBroadsword)
                .AddIngredient(ItemID.IronShortsword)
                .AddIngredient(ItemID.IronBow)
                .AddIngredient(ItemID.IronDoor)
                .AddIngredient(ItemID.IronFence)
                .AddIngredient(ItemID.IronHelmet)
                .AddIngredient(ItemID.IronAnvil)
                .AddIngredient(ItemID.IronChainmail)
                .AddIngredient(ItemID.IronGreaves)
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
    public class Lead : ModItem
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
                .AddIngredient(ItemID.LeadOre)
                .AddIngredient(ItemID.LeadBrick)
                .AddIngredient(ItemID.LeadBrickWall)
                .AddIngredient(ItemID.LeadBar)
                .AddIngredient(ItemID.LeadPickaxe)
                .AddIngredient(ItemID.LeadAxe)
                .AddIngredient(ItemID.LeadHammer)
                .AddIngredient(ItemID.LeadBroadsword)
                .AddIngredient(ItemID.LeadShortsword)
                .AddIngredient(ItemID.LeadBow)
                .AddIngredient(ItemID.LeadDoor)
                .AddIngredient(ItemID.LeadFence)
                .AddIngredient(ItemID.LeadHelmet)
                .AddIngredient(ItemID.LeadAnvil)
                .AddIngredient(ItemID.LeadChainmail)
                .AddIngredient(ItemID.LeadGreaves)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Life : ModItem
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
                .AddIngredient(ItemID.LifeCrystal)
                .AddIngredient(ItemID.LesserHealingPotion)
                .AddIngredient(ItemID.HealingPotion)
                .AddIngredient(ItemID.HeartLantern)
                .AddIngredient(ItemID.BandofRegeneration)
                .AddTile(TileID.Bottles)
                .Register();
        }
    }
    public class Pig : ModItem
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
                .AddIngredient(ItemID.PiggyBank)
                .AddIngredient(ItemID.MoneyTrough)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Mana : ModItem
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
                .AddIngredient(ItemID.ManaCrystal)
                .AddIngredient(ItemID.LesserManaPotion)
                .AddIngredient(ItemID.BandofStarpower)
                .AddIngredient(ItemID.ManaPotion)
                .AddIngredient(ItemID.NaturesGift)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Metal : ModItem
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
                .AddIngredient(ItemID.Chain)
                .AddIngredient(ItemID.Hook)
                .AddIngredient(ItemID.GrapplingHook)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Meteor : ModItem
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
                .AddIngredient(ItemID.Meteorite)
                .AddIngredient(ItemID.SpaceGun)
                .AddIngredient(ItemID.MeteorHamaxe)
                .AddIngredient(ItemID.MeteorHelmet)
                .AddIngredient(ItemID.MeteorSuit)
                .AddIngredient(ItemID.MeteorLeggings)
                .AddIngredient(ItemID.MeteoriteBrick)
                .AddIngredient(ItemID.MeteorShot)
                .AddIngredient(ItemID.MeteoriteBrickWall)
                .AddIngredient(ItemID.MeteoriteBar)
                .AddIngredient(ItemID.MeteorHeadBanner)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Mining : ModItem
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
                .AddIngredient(ItemID.MiningHelmet)
                .AddIngredient(ItemID.MiningShirt)
                .AddIngredient(ItemID.MiningPants)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Mushroom : ModItem
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
                .AddIngredient(ItemID.Mushroom)
                .AddTile(TileID.Bottles)
                .Register();
        }
    }
    public class Red : ModItem
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
                .AddIngredient(ItemID.RedBanner)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
    public class Blue : ModItem
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
                .AddIngredient(ItemID.BlueBanner)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
    public class Yellow : ModItem
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
                .AddIngredient(ItemID.YellowBanner)
                .AddTile(TileID.Loom)
                .Register();
        }
    }
    public class Sapphire : ModItem
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
                .AddIngredient(ItemID.Sapphire)
                .AddIngredient(ItemID.GemTreeSapphireSeed) // Sapphire Gemcorn
                .AddIngredient(ItemID.GemBunnySapphire) // Sapphire Bunny
                .AddIngredient(ItemID.GemSquirrelSapphire) // Sapphire Squirrel
                .AddIngredient(ItemID.SapphireHook)
                .AddIngredient(ItemID.SapphireEcho) // Sapphire Stone Wall
                .AddIngredient(ItemID.SapphireRobe)
                .AddIngredient(ItemID.LargeSapphire)
                .AddIngredient(ItemID.SapphireStaff)
                .AddIngredient(ItemID.SapphireStoneBlock)
                .AddIngredient(ItemID.GemLockSapphire) // Sapphire Gem Lock
                .AddIngredient(ItemID.SapphireGemsparkBlock)
                .AddIngredient(ItemID.SapphireGemsparkWall)
                .AddIngredient(ItemID.SapphireGemsparkWallOff)
                .AddIngredient(ItemID.BluePhaseblade)
                .AddIngredient(ItemID.SapphireBunnyCage)
                .AddIngredient(ItemID.SapphireSquirrelCage)
                .AddIngredient(ItemID.SapphireMinecart)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Sand : ModItem
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
                .AddIngredient(ItemID.SandBlock)
                .AddIngredient(ItemID.SandstoneBrick)
                .AddIngredient(ItemID.SandstoneBrickWall)
                .AddIngredient(ItemID.SandstoneSlab)
                .AddIngredient(ItemID.Sandgun)
                .AddIngredient(ItemID.HardenedSand)
                .AddIngredient(ItemID.HardenedSandWall)
                .AddIngredient(ItemID.Sandstone)
                .AddIngredient(ItemID.SandstoneWall)
                .AddIngredient(ItemID.PharaohsMask)
                .AddIngredient(ItemID.PharaohsRobe)
                .AddIngredient(ItemID.SandstorminaBottle)
                .AddIngredient(ItemID.FlyingCarpet)
                .AddTile(TileID.WorkBenches)
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
    public class Spider : ModItem
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
                .AddIngredient(ItemID.Cobweb)
                .AddIngredient(ItemID.WebSlinger)
                .AddIngredient(ItemID.WebRope)
                .AddIngredient(ItemID.WebRopeCoil)
                .AddIngredient(ItemID.SpiderBanner)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Stone : ModItem
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
                .AddIngredient(ItemID.StoneBlock)
                .AddIngredient(ItemID.StoneWall)
                .AddIngredient(ItemID.Furnace)
                .AddIngredient(ItemID.AngelStatue)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
    public class Platinum : ModItem
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
                .AddIngredient(ItemID.PlatinumOre)
                .AddIngredient(ItemID.PlatinumBrick)
                .AddIngredient(ItemID.PlatinumBrickWall)
                .AddIngredient(ItemID.PlatinumBar)
                .AddIngredient(ItemID.PlatinumChandelier)
                .AddIngredient(ItemID.PlatinumCrown)
                .AddIngredient(ItemID.PlatinumHelmet)
                .AddIngredient(ItemID.PlatinumChainmail)
                .AddIngredient(ItemID.PlatinumCoin)
                .AddIngredient(ItemID.PlatinumGreaves)
                .AddIngredient(ItemID.PlatinumBow)
                .AddIngredient(ItemID.PlatinumWatch)
                .AddIngredient(ItemID.PlatinumPickaxe)
                .AddIngredient(ItemID.PlatinumCandelabra)
                .AddIngredient(ItemID.PlatinumCandle)
                .AddIngredient(ItemID.PlatinumAxe)
                .AddIngredient(ItemID.PlatinumHammer)
                .AddIngredient(ItemID.PlatinumBroadsword)
                .AddIngredient(ItemID.PlatinumShortsword)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Recall : ModItem
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
                .AddIngredient(ItemID.RecallPotion)
                .AddIngredient(ItemID.MagicMirror)
                .AddTile(TileID.GlassKiln)
                .Register();
        }
    }
    public class Ruby : ModItem
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
                .AddIngredient(ItemID.Ruby)
                .AddIngredient(ItemID.GemTreeRubySeed) // Ruby Gemcorn
                .AddIngredient(ItemID.GemBunnyRuby) // Ruby Bunny
                .AddIngredient(ItemID.GemSquirrelRuby) // Ruby Squirrel
                .AddIngredient(ItemID.RubyHook)
                .AddIngredient(ItemID.RubyEcho) // Ruby Stone Wall
                .AddIngredient(ItemID.RubyRobe)
                .AddIngredient(ItemID.LargeRuby)
                .AddIngredient(ItemID.RubyStaff)
                .AddIngredient(ItemID.RubyStoneBlock)
                .AddIngredient(ItemID.GemLockRuby) // Ruby Gem Lock
                .AddIngredient(ItemID.RubyGemsparkBlock)
                .AddIngredient(ItemID.RubyGemsparkWall)
                .AddIngredient(ItemID.RubyGemsparkWallOff)
                .AddIngredient(ItemID.RedPhaseblade)
                .AddIngredient(ItemID.RubyBunnyCage)
                .AddIngredient(ItemID.RubySquirrelCage)
                .AddIngredient(ItemID.RubyMinecart)
                .AddTile(TileID.Anvils)
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
                .AddIngredient(ItemID.SilverBrick)
                .AddIngredient(ItemID.SilverBrickWall)
                .AddIngredient(ItemID.AncientSilverBrick)
                .AddIngredient(ItemID.AncientSilverBrickWall)
                .AddIngredient(ItemID.SilverBar)
                .AddIngredient(ItemID.SilverBullet)
                .AddIngredient(ItemID.SilverChandelier)
                .AddIngredient(ItemID.SilverHelmet)
                .AddIngredient(ItemID.SilverChainmail)
                .AddIngredient(ItemID.SilverGreaves)
                .AddIngredient(ItemID.SilverCoin)
                .AddIngredient(ItemID.SilverBow)
                .AddIngredient(ItemID.SilverWatch)
                .AddIngredient(ItemID.SilverPickaxe)
                .AddIngredient(ItemID.SilverAxe)
                .AddIngredient(ItemID.SilverHammer)
                .AddIngredient(ItemID.SilverBroadsword)
                .AddIngredient(ItemID.SilverShortsword)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Slime : ModItem
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
                .AddIngredient(ItemID.Gel)
                .AddIngredient(ItemID.SlimeBanner)
                .AddIngredient(ItemID.GreenSlimeBanner)
                .AddIngredient(ItemID.SlimeStaff)
                .AddIngredient(ItemID.PurpleSlimeBanner)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Star : ModItem
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
                .AddIngredient(ItemID.FallenStar)
                .AddIngredient(ItemID.JestersArrow)
                .AddIngredient(ItemID.StarCannon)
                .AddIngredient(ItemID.Starfury)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Tin : ModItem
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
                .AddIngredient(ItemID.TinOre)
                .AddIngredient(ItemID.TinBar)
                .AddIngredient(ItemID.TinBrick)
                .AddIngredient(ItemID.TinBrickWall)
                .AddIngredient(ItemID.TinPlating)
                .AddIngredient(ItemID.TinPlatingWall)
                .AddIngredient(ItemID.TinAxe)
                .AddIngredient(ItemID.TinBow)
                .AddIngredient(ItemID.TinBroadsword)
                .AddIngredient(ItemID.TinChandelier)
                .AddIngredient(ItemID.TinChainmail)
                .AddIngredient(ItemID.TinGreaves)
                .AddIngredient(ItemID.TinHammer)
                .AddIngredient(ItemID.TinPickaxe)
                .AddIngredient(ItemID.TinHelmet)
                .AddIngredient(ItemID.TinShortsword)
                .AddIngredient(ItemID.TinBroadsword)
                .AddIngredient(ItemID.TinWatch)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Torch : ModItem
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
                .AddIngredient(ItemID.Torch)
                .AddIngredient(ItemID.Campfire)
                .AddTile(TileID.Campfire)
                .Register();
        }
    }
    public class Topaz : ModItem
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
                .AddIngredient(ItemID.Topaz)
                .AddIngredient(ItemID.GemTreeTopazSeed) // Topaz Gemcorn
                .AddIngredient(ItemID.GemBunnyTopaz) // Topaz Bunny
                .AddIngredient(ItemID.GemSquirrelTopaz) // Topaz Squirrel
                .AddIngredient(ItemID.TopazHook)
                .AddIngredient(ItemID.TopazEcho) // Topaz Stone Wall
                .AddIngredient(ItemID.TopazRobe)
                .AddIngredient(ItemID.LargeTopaz)
                .AddIngredient(ItemID.TopazStaff)
                .AddIngredient(ItemID.TopazStoneBlock)
                .AddIngredient(ItemID.GemLockTopaz) // Topaz Gem Lock
                .AddIngredient(ItemID.TopazGemsparkBlock)
                .AddIngredient(ItemID.TopazGemsparkWall)
                .AddIngredient(ItemID.TopazGemsparkWallOff)
                .AddIngredient(ItemID.YellowPhaseblade)
                .AddIngredient(ItemID.TopazBunnyCage)
                .AddIngredient(ItemID.TopazSquirrelCage)
                .AddIngredient(ItemID.TopazMinecart)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Tungsten : ModItem
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
                .AddIngredient(ItemID.TungstenOre)
                .AddIngredient(ItemID.TungstenBrick)
                .AddIngredient(ItemID.TungstenBrickWall)
                .AddIngredient(ItemID.TungstenBar)
                .AddIngredient(ItemID.TungstenBullet)
                .AddIngredient(ItemID.TungstenChandelier)
                .AddIngredient(ItemID.TungstenHelmet)
                .AddIngredient(ItemID.TungstenChainmail)
                .AddIngredient(ItemID.TungstenGreaves)
                .AddIngredient(ItemID.TungstenBow)
                .AddIngredient(ItemID.TungstenWatch)
                .AddIngredient(ItemID.TungstenPickaxe)
                .AddIngredient(ItemID.TungstenAxe)
                .AddIngredient(ItemID.TungstenHammer)
                .AddIngredient(ItemID.TungstenBroadsword)
                .AddIngredient(ItemID.TungstenShortsword)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
    public class Wood : ModItem
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
                .AddIngredient(ItemID.Wood)
                .AddIngredient(ItemID.WoodWall)
                .AddIngredient(ItemID.WoodPlatform)
                .AddIngredient(ItemID.WoodenSword)
                .AddIngredient(ItemID.WoodenHammer)
                .AddIngredient(ItemID.WoodenBow)
                .AddIngredient(ItemID.WoodenBoomerang)
                .AddIngredient(ItemID.WoodHelmet)
                .AddIngredient(ItemID.WoodBreastplate)
                .AddIngredient(ItemID.WoodenArrow)
                .AddIngredient(ItemID.WoodGreaves)
                .AddIngredient(ItemID.WoodenTable)
                .AddIngredient(ItemID.Chest)
                .AddIngredient(ItemID.WoodenChair)
                .AddIngredient(ItemID.WoodenDoor)
                .AddIngredient(ItemID.WorkBench)
                .AddIngredient(ItemID.Acorn)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Zombie : ModItem
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
                .AddIngredient(ItemID.ZombieArm)
                .AddIngredient(ItemID.ZombieArmStatue)
                .AddIngredient(ItemID.ZombieBanner)
                .AddIngredient(ItemID.Shackle)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}