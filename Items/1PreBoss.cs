
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Alphabet : ModItem
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
                .AddIngredient(ItemID.AlphabetStatue0)
                .AddIngredient(ItemID.AlphabetStatue1)
                .AddIngredient(ItemID.AlphabetStatue2)
                .AddIngredient(ItemID.AlphabetStatue3)
                .AddIngredient(ItemID.AlphabetStatue4)
                .AddIngredient(ItemID.AlphabetStatue5)
                .AddIngredient(ItemID.AlphabetStatue6)
                .AddIngredient(ItemID.AlphabetStatue7)
                .AddIngredient(ItemID.AlphabetStatue8)
                .AddIngredient(ItemID.AlphabetStatue9)
                .AddIngredient(ItemID.AlphabetStatueA)
                .AddIngredient(ItemID.AlphabetStatueB)
                .AddIngredient(ItemID.AlphabetStatueC)
                .AddIngredient(ItemID.AlphabetStatueB)
                .AddIngredient(ItemID.AlphabetStatueC)
                .AddIngredient(ItemID.AlphabetStatueD)
                .AddIngredient(ItemID.AlphabetStatueE)
                .AddIngredient(ItemID.AlphabetStatueF)
                .AddIngredient(ItemID.AlphabetStatueG)
                .AddIngredient(ItemID.AlphabetStatueH)
                .AddIngredient(ItemID.AlphabetStatueI)
                .AddIngredient(ItemID.AlphabetStatueJ)
                .AddIngredient(ItemID.AlphabetStatueK)
                .AddIngredient(ItemID.AlphabetStatueL)
                .AddIngredient(ItemID.AlphabetStatueM)
                .AddIngredient(ItemID.AlphabetStatueN)
                .AddIngredient(ItemID.AlphabetStatueO)
                .AddIngredient(ItemID.AlphabetStatueP)
                .AddIngredient(ItemID.AlphabetStatueQ)
                .AddIngredient(ItemID.AlphabetStatueR)
                .AddIngredient(ItemID.AlphabetStatueS)
                .AddIngredient(ItemID.AlphabetStatueT)
                .AddIngredient(ItemID.AlphabetStatueU)
                .AddIngredient(ItemID.AlphabetStatueV)
                .AddIngredient(ItemID.AlphabetStatueW)
                .AddIngredient(ItemID.AlphabetStatueX)
                .AddIngredient(ItemID.AlphabetStatueY)
                .AddIngredient(ItemID.AlphabetStatueZ)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }
    }
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
    public class AshWood : ModItem
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
                .AddIngredient(ItemID.AshWood)
                .AddIngredient(ItemID.AshWoodBow)
                .AddIngredient(ItemID.AshWoodBreastplate)
                .AddIngredient(ItemID.AshWoodGreaves)
                .AddIngredient(ItemID.AshWoodHammer)
                .AddIngredient(ItemID.AshWoodHelmet)
                .AddIngredient(ItemID.AshWoodSword)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }
    public class AshWoodHouse : ModItem
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
                .AddIngredient(ItemID.AshWoodBathtub)
                .AddIngredient(ItemID.AshWoodBed)
                .AddIngredient(ItemID.AshWoodBookcase)
                .AddIngredient(ItemID.AshWoodCandelabra)
                .AddIngredient(ItemID.AshWoodCandle)
                .AddIngredient(ItemID.AshWoodChair)
                .AddIngredient(ItemID.AshWoodChandelier)
                .AddIngredient(ItemID.AshWoodChest)
                .AddIngredient(ItemID.AshWoodClock)
                .AddIngredient(ItemID.AshWoodDoor)
                .AddIngredient(ItemID.AshWoodDresser)
                .AddIngredient(ItemID.AshWoodFence)
                .AddIngredient(ItemID.AshWoodLamp)
                .AddIngredient(ItemID.AshWoodLantern)
                .AddIngredient(ItemID.AshWoodPiano)
                .AddIngredient(ItemID.AshWoodPlatform)
                .AddIngredient(ItemID.AshWoodSink)
                .AddIngredient(ItemID.AshWoodSofa)
                .AddIngredient(ItemID.AshWoodTable)
                .AddIngredient(ItemID.AshWoodToilet)
                .AddIngredient(ItemID.AshWoodWall)
                .AddIngredient(ItemID.AshWoodWorkbench)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }
    public class BalloonHouse : ModItem
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
                .AddIngredient(ItemID.BalloonBathtub)
                .AddIngredient(ItemID.BalloonBed)
                .AddIngredient(ItemID.BalloonBookcase)
                .AddIngredient(ItemID.BalloonCandelabra)
                .AddIngredient(ItemID.BalloonCandle)
                .AddIngredient(ItemID.BalloonChair)
                .AddIngredient(ItemID.BalloonChandelier)
                .AddIngredient(ItemID.BalloonChest)
                .AddIngredient(ItemID.BalloonClock)
                .AddIngredient(ItemID.BalloonDoor)
                .AddIngredient(ItemID.BalloonDresser)
                .AddIngredient(ItemID.BalloonLamp)
                .AddIngredient(ItemID.BalloonLantern)
                .AddIngredient(ItemID.BalloonPiano)
                .AddIngredient(ItemID.BalloonPlatform)
                .AddIngredient(ItemID.BalloonSink)
                .AddIngredient(ItemID.BalloonSofa)
                .AddIngredient(ItemID.BalloonTable)
                .AddIngredient(ItemID.BalloonToilet)
                .AddIngredient(ItemID.BalloonWorkbench)
                .AddIngredient(ItemID.SillyBalloonGreenWall)
                .AddIngredient(ItemID.SillyBalloonPinkWall)
                .AddIngredient(ItemID.SillyBalloonPurpleWall)
                .AddTile(TileID.SteampunkBoiler)
                .Register();
        }
    }
    public class BambooHouse : ModItem
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
                .AddIngredient(ItemID.BambooBathtub)
                .AddIngredient(ItemID.BambooBed)
                .AddIngredient(ItemID.BambooBlock)
                .AddIngredient(ItemID.BambooBlockWall)
                .AddIngredient(ItemID.BambooBookcase)
                .AddIngredient(ItemID.BambooCandelabra)
                .AddIngredient(ItemID.BambooCandle)
                .AddIngredient(ItemID.BambooChair)
                .AddIngredient(ItemID.BambooChandelier)
                .AddIngredient(ItemID.BambooChest)
                .AddIngredient(ItemID.BambooClock)
                .AddIngredient(ItemID.BambooDoor)
                .AddIngredient(ItemID.BambooDresser)
                .AddIngredient(ItemID.BambooFence)
                .AddIngredient(ItemID.BambooLamp)
                .AddIngredient(ItemID.BambooLantern)
                .AddIngredient(ItemID.BambooPiano)
                .AddIngredient(ItemID.BambooPlatform)
                .AddIngredient(ItemID.BambooSink)
                .AddIngredient(ItemID.BambooSofa)
                .AddIngredient(ItemID.BambooTable)
                .AddIngredient(ItemID.BambooToilet)
                .AddIngredient(ItemID.BambooWorkbench)
                .AddIngredient(ItemID.LargeBambooBlock)
                .AddIngredient(ItemID.LargeBambooBlockWall)
                .AddTile(TileID.WorkBenches)
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
    public class Boreal : ModItem
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
                .AddIngredient(ItemID.BorealWood)
                .AddIngredient(ItemID.BorealWoodSword)
                .AddIngredient(ItemID.BorealWoodBow)
                .AddIngredient(ItemID.BorealWoodHammer)
                .AddIngredient(ItemID.BorealWoodHelmet)
                .AddIngredient(ItemID.BorealWoodBreastplate)
                .AddIngredient(ItemID.BorealWoodGreaves)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class BorealHouse : ModItem
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
                .AddIngredient(ItemID.BorealWoodBathtub)
                .AddIngredient(ItemID.BorealWoodBed)
                .AddIngredient(ItemID.BorealWoodBookcase)
                .AddIngredient(ItemID.BorealWoodCandelabra)
                .AddIngredient(ItemID.BorealWoodCandle)
                .AddIngredient(ItemID.BorealWoodChair)
                .AddIngredient(ItemID.BorealWoodChandelier)
                .AddIngredient(ItemID.BorealWoodChest)
                .AddIngredient(ItemID.BorealWoodClock)
                .AddIngredient(ItemID.BorealWoodDoor)
                .AddIngredient(ItemID.BorealWoodDresser)
                .AddIngredient(ItemID.BorealWoodFence)
                .AddIngredient(ItemID.BorealWoodLamp)
                .AddIngredient(ItemID.BorealWoodLantern)
                .AddIngredient(ItemID.BorealWoodPiano)
                .AddIngredient(ItemID.BorealWoodPlatform)
                .AddIngredient(ItemID.BorealWoodSink)
                .AddIngredient(ItemID.BorealWoodSofa)
                .AddIngredient(ItemID.BorealWoodTable)
                .AddIngredient(ItemID.BorealWoodWall)
                .AddIngredient(ItemID.BorealWoodWorkBench)
                .AddIngredient(ItemID.ToiletBoreal)
                .AddTile(TileID.WorkBenches)
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
                .AddIngredient(ItemID.RollingCactus)
                .AddIngredient(ItemID.CactusBreastplate)
                .AddIngredient(ItemID.CactusHelmet)
                .AddIngredient(ItemID.CactusPickaxe)
                .AddIngredient(ItemID.CactusLeggings)
                .AddIngredient(ItemID.CactusSword)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class CactusHouse : ModItem
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
                .AddIngredient(ItemID.CactusBathtub)
                .AddIngredient(ItemID.CactusBed)
                .AddIngredient(ItemID.CactusBookcase)
                .AddIngredient(ItemID.CactusCandelabra)
                .AddIngredient(ItemID.CactusCandle)
                .AddIngredient(ItemID.CactusChair)
                .AddIngredient(ItemID.CactusChandelier)
                .AddIngredient(ItemID.CactusChest)
                .AddIngredient(ItemID.CactusClock)
                .AddIngredient(ItemID.CactusDoor)
                .AddIngredient(ItemID.CactusDresser)
                .AddIngredient(ItemID.CactusLamp)
                .AddIngredient(ItemID.CactusLantern)
                .AddIngredient(ItemID.CactusPiano)
                .AddIngredient(ItemID.CactusPlatform)
                .AddIngredient(ItemID.CactusSink)
                .AddIngredient(ItemID.CactusSofa)
                .AddIngredient(ItemID.CactusTable)
                .AddIngredient(ItemID.CactusWall)
                .AddIngredient(ItemID.CactusWorkBench)
                .AddIngredient(ItemID.ToiletCactus)
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
    public class Ebonwood : ModItem
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
                .AddIngredient(ItemID.Ebonwood)
                .AddIngredient(ItemID.EbonwoodSword)
                .AddIngredient(ItemID.EbonwoodBow)
                .AddIngredient(ItemID.EbonwoodHammer)
                .AddIngredient(ItemID.EbonwoodHelmet)
                .AddIngredient(ItemID.EbonwoodBreastplate)
                .AddIngredient(ItemID.EbonwoodGreaves)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class EbonwoodHouse : ModItem
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
                .AddIngredient(ItemID.EbonwoodBathtub)
                .AddIngredient(ItemID.EbonwoodBed)
                .AddIngredient(ItemID.EbonwoodBookcase)
                .AddIngredient(ItemID.EbonwoodCandelabra)
                .AddIngredient(ItemID.EbonwoodCandle)
                .AddIngredient(ItemID.EbonwoodChair)
                .AddIngredient(ItemID.EbonwoodChandelier)
                .AddIngredient(ItemID.EbonwoodChest)
                .AddIngredient(ItemID.EbonwoodClock)
                .AddIngredient(ItemID.EbonwoodDoor)
                .AddIngredient(ItemID.EbonwoodDresser)
                .AddIngredient(ItemID.EbonwoodFence)
                .AddIngredient(ItemID.EbonwoodLamp)
                .AddIngredient(ItemID.EbonwoodLantern)
                .AddIngredient(ItemID.EbonwoodPiano)
                .AddIngredient(ItemID.EbonwoodPlatform)
                .AddIngredient(ItemID.EbonwoodSofa)
                .AddIngredient(ItemID.EbonwoodTable)
                .AddIngredient(ItemID.EbonwoodWall)
                .AddIngredient(ItemID.EbonwoodWorkBench)
                .AddIngredient(ItemID.ToiletEbonyWood)
                .AddIngredient(ItemID.EbonwoodSink)
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
    public class DynastyWoodHouse : ModItem
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
                .AddIngredient(ItemID.BlueDynastyWall)
                .AddIngredient(ItemID.DynastyBathtub)
                .AddIngredient(ItemID.DynastyBed)
                .AddIngredient(ItemID.DynastyBookcase)
                .AddIngredient(ItemID.DynastyBowl)
                .AddIngredient(ItemID.DynastyCandelabra)
                .AddIngredient(ItemID.DynastyCandle)
                .AddIngredient(ItemID.DynastyChair)
                .AddIngredient(ItemID.DynastyChandelier)
                .AddIngredient(ItemID.DynastyChest)
                .AddIngredient(ItemID.DynastyClock)
                .AddIngredient(ItemID.DynastyCup)
                .AddIngredient(ItemID.DynastyDoor)
                .AddIngredient(ItemID.DynastyDresser)
                .AddIngredient(ItemID.DynastyLamp)
                .AddIngredient(ItemID.DynastyLantern)
                .AddIngredient(ItemID.DynastyPiano)
                .AddIngredient(ItemID.DynastyPlatform)
                .AddIngredient(ItemID.DynastySink)
                .AddIngredient(ItemID.DynastySofa)
                .AddIngredient(ItemID.DynastyTable)
                .AddIngredient(ItemID.DynastyWood)
                .AddIngredient(ItemID.DynastyWorkBench)
                .AddIngredient(ItemID.ToiletDynasty)
                .AddIngredient(ItemID.WhiteDynastyWall)
                .AddTile(TileID.WorkBenches)
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
    public class FrozenHouse : ModItem
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
                .AddIngredient(ItemID.FrozenBathtub)
                .AddIngredient(ItemID.FrozenBed)
                .AddIngredient(ItemID.FrozenBookcase)
                .AddIngredient(ItemID.FrozenCampfire)
                .AddIngredient(ItemID.FrozenCandelabra)
                .AddIngredient(ItemID.FrozenCandle)
                .AddIngredient(ItemID.FrozenChair)
                .AddIngredient(ItemID.FrozenChandelier)
                .AddIngredient(ItemID.FrozenChest)
                .AddIngredient(ItemID.FrozenClock)
                .AddIngredient(ItemID.FrozenDoor)
                .AddIngredient(ItemID.FrozenDresser)
                .AddIngredient(ItemID.FrozenLamp)
                .AddIngredient(ItemID.FrozenLantern)
                .AddIngredient(ItemID.FrozenPiano)
                .AddIngredient(ItemID.FrozenPlatform)
                .AddIngredient(ItemID.FrozenSink)
                .AddIngredient(ItemID.FrozenSofa)
                .AddIngredient(ItemID.FrozenTable)
                .AddIngredient(ItemID.FrozenWorkBench)
                .AddIngredient(ItemID.ToiletFrozen)
                .AddTile(TileID.IceMachine)
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
                .AddIngredient(ItemID.GlassSlipper)
                .AddIngredient(ItemID.GlassKiln)
                .AddIngredient(ItemID.Bottle)
                .AddTile(TileID.GlassKiln)
                .Register();
        }
    }
    public class GlassHouse : ModItem
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
                .AddIngredient(ItemID.GlassBathtub)
                .AddIngredient(ItemID.GlassBed)
                .AddIngredient(ItemID.GlassBookcase)
                .AddIngredient(ItemID.GlassCandelabra)
                .AddIngredient(ItemID.GlassCandle)
                .AddIngredient(ItemID.GlassChair)
                .AddIngredient(ItemID.GlassChandelier)
                .AddIngredient(ItemID.GlassChest)
                .AddIngredient(ItemID.GlassClock)
                .AddIngredient(ItemID.GlassDoor)
                .AddIngredient(ItemID.GlassDresser)
                .AddIngredient(ItemID.GlassLamp)
                .AddIngredient(ItemID.GlassLantern)
                .AddIngredient(ItemID.GlassPiano)
                .AddIngredient(ItemID.GlassPlatform)
                .AddIngredient(ItemID.GlassSink)
                .AddIngredient(ItemID.GlassSofa)
                .AddIngredient(ItemID.GlassTable)
                .AddIngredient(ItemID.GlassWall)
                .AddIngredient(ItemID.GlassWorkBench)
                .AddIngredient(ItemID.ToiletGlass)
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
                .AddIngredient(ItemID.MushroomDye)
                .AddIngredient(ItemID.MushroomVest)
                .AddIngredient(ItemID.MushroomPants)
                .AddIngredient(ItemID.MushroomTorch)
                .AddIngredient(ItemID.MushroomCampfire)
                .AddIngredient(ItemID.MushroomStatue)
                .AddIngredient(ItemID.GlowingSnail)
                .AddIngredient(ItemID.GlowingSnailCage)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class GlowingMushroomHouse : ModItem
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
                .AddIngredient(ItemID.MushroomBathtub)
                .AddIngredient(ItemID.MushroomBeam)
                .AddIngredient(ItemID.MushroomBed)
                .AddIngredient(ItemID.MushroomBench)
                .AddIngredient(ItemID.MushroomBookcase)
                .AddIngredient(ItemID.MushroomCandelabra)
                .AddIngredient(ItemID.MushroomCandle)
                .AddIngredient(ItemID.MushroomChair)
                .AddIngredient(ItemID.MushroomChandelier)
                .AddIngredient(ItemID.MushroomChest)
                .AddIngredient(ItemID.MushroomClock)
                .AddIngredient(ItemID.MushroomDoor)
                .AddIngredient(ItemID.MushroomDresser)
                .AddIngredient(ItemID.MushroomLamp)
                .AddIngredient(ItemID.MushroomLantern)
                .AddIngredient(ItemID.MushroomPiano)
                .AddIngredient(ItemID.MushroomPlatform)
                .AddIngredient(ItemID.MushroomSink)
                .AddIngredient(ItemID.MushroomSofa)
                .AddIngredient(ItemID.MushroomTable)
                .AddIngredient(ItemID.MushroomWall)
                .AddIngredient(ItemID.MushroomWorkBench)
                .AddIngredient(ItemID.ToiletMushroom)
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
    public class GraniteHouse : ModItem
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
                .AddIngredient(ItemID.GraniteBathtub)
                .AddIngredient(ItemID.GraniteBed)
                .AddIngredient(ItemID.GraniteBlock)
                .AddIngredient(ItemID.GraniteBlockWall)
                .AddIngredient(ItemID.GraniteBookcase)
                .AddIngredient(ItemID.GraniteCandelabra)
                .AddIngredient(ItemID.GraniteCandle)
                .AddIngredient(ItemID.GraniteChair)
                .AddIngredient(ItemID.GraniteChandelier)
                .AddIngredient(ItemID.GraniteChest)
                .AddIngredient(ItemID.GraniteClock)
                .AddIngredient(ItemID.GraniteColumn)
                .AddIngredient(ItemID.GraniteDoor)
                .AddIngredient(ItemID.GraniteDresser)
                .AddIngredient(ItemID.GraniteLamp)
                .AddIngredient(ItemID.GraniteLantern)
                .AddIngredient(ItemID.GranitePiano)
                .AddIngredient(ItemID.GranitePlatform)
                .AddIngredient(ItemID.GraniteSink)
                .AddIngredient(ItemID.GraniteSofa)
                .AddIngredient(ItemID.GraniteTable)
                .AddIngredient(ItemID.GraniteWorkBench)
                .AddIngredient(ItemID.ToiletGranite)
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
    public class Honey : ModItem
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
                .AddIngredient(ItemID.Abeemination)
                .AddIngredient(ItemID.CrispyHoneyBlock)
                .AddIngredient(ItemID.HoneyBucket)
                .AddTile(TileID.HoneyDispenser)
                .Register();
        }
    }
    public class HoneyHouse : ModItem
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
                .AddIngredient(ItemID.HoneyBlock)
                .AddIngredient(ItemID.HoneyChest)
                .AddIngredient(ItemID.HoneyChair)
                .AddIngredient(ItemID.HoneyTable)
                .AddIngredient(ItemID.HoneyWorkBench)
                .AddIngredient(ItemID.HoneyPlatform)
                .AddIngredient(ItemID.HoneyPiano)
                .AddIngredient(ItemID.HoneyBed)
                .AddIngredient(ItemID.HoneyDresser)
                .AddIngredient(ItemID.HoneyDoor)
                .AddIngredient(ItemID.HoneyBookcase)
                .AddIngredient(ItemID.HoneyLantern)
                .AddIngredient(ItemID.HoneyChandelier)
                .AddIngredient(ItemID.HoneyBathtub)
                .AddIngredient(ItemID.HoneyCandle)
                .AddIngredient(ItemID.HoneyCup)
                .AddIngredient(ItemID.HoneyLamp)
                .AddIngredient(ItemID.HoneyCandelabra)
                .AddIngredient(ItemID.HoneySofa)
                .AddIngredient(ItemID.HoneyClock)
                .AddIngredient(ItemID.ToiletHoney)
                .AddIngredient(ItemID.HoneySink)
                .AddTile(TileID.HoneyDispenser)
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
    public class LivingWoodHouse : ModItem
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
                .AddIngredient(ItemID.LivingWoodBathtub)
                .AddIngredient(ItemID.LivingWoodBed)
                .AddIngredient(ItemID.LivingWoodBookcase)
                .AddIngredient(ItemID.LivingWoodCandelabra)
                .AddIngredient(ItemID.LivingWoodCandle)
                .AddIngredient(ItemID.LivingWoodChair)
                .AddIngredient(ItemID.LivingWoodChandelier)
                .AddIngredient(ItemID.LivingWoodChest)
                .AddIngredient(ItemID.LivingWoodClock)
                .AddIngredient(ItemID.LivingWoodDoor)
                .AddIngredient(ItemID.LivingWoodDresser)
                .AddIngredient(ItemID.LivingWoodLamp)
                .AddIngredient(ItemID.LivingWoodLantern)
                .AddIngredient(ItemID.LivingWoodPiano)
                .AddIngredient(ItemID.LivingWoodPlatform)
                .AddIngredient(ItemID.LivingWoodSofa)
                .AddIngredient(ItemID.LivingWoodTable)
                .AddIngredient(ItemID.LivingWoodWorkBench)
                .AddIngredient(ItemID.ToiletLivingWood)
                .AddIngredient(ItemID.LivingWoodWall)
                .AddIngredient(ItemID.LivingLeafWall)
                .AddIngredient(ItemID.LivingWoodSink)
                .AddTile(TileID.IceMachine)
                .Register();
        }
    }
    public class PalmWood : ModItem
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
                .AddIngredient(ItemID.PalmWood)
                .AddIngredient(ItemID.PalmWoodHelmet)
                .AddIngredient(ItemID.PalmWoodBreastplate)
                .AddIngredient(ItemID.PalmWoodGreaves)
                .AddIngredient(ItemID.PalmWoodBow)
                .AddIngredient(ItemID.PalmWoodHammer)
                .AddIngredient(ItemID.PalmWoodSword)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class PalmWoodHouse : ModItem
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
                .AddIngredient(ItemID.PalmWoodBathtub)
                .AddIngredient(ItemID.PalmWoodBed)
                .AddIngredient(ItemID.PalmWoodBench)
                .AddIngredient(ItemID.PalmWoodBookcase)
                .AddIngredient(ItemID.PalmWoodCandelabra)
                .AddIngredient(ItemID.PalmWoodCandle)
                .AddIngredient(ItemID.PalmWoodChair)
                .AddIngredient(ItemID.PalmWoodChandelier)
                .AddIngredient(ItemID.PalmWoodChest)
                .AddIngredient(ItemID.PalmWoodClock)
                .AddIngredient(ItemID.PalmWoodDoor)
                .AddIngredient(ItemID.PalmWoodDresser)
                .AddIngredient(ItemID.PalmWoodFence)
                .AddIngredient(ItemID.PalmWoodLamp)
                .AddIngredient(ItemID.PalmWoodLantern)
                .AddIngredient(ItemID.PalmWoodPiano)
                .AddIngredient(ItemID.PalmWoodPlatform)
                .AddIngredient(ItemID.PalmWoodSink)
                .AddIngredient(ItemID.PalmWoodSofa)
                .AddIngredient(ItemID.PalmWoodTable)
                .AddIngredient(ItemID.PalmWoodWall)
                .AddIngredient(ItemID.PalmWoodWorkBench)
                .AddIngredient(ItemID.ToiletPalm)
                .AddTile(TileID.WorkBenches)
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
    public class PineTreeHouse : ModItem
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
                .AddIngredient(ItemID.PineTreeBlock)
                .AddIngredient(ItemID.PineChair)
                .AddIngredient(ItemID.PineTable)
                .AddIngredient(ItemID.PineDoor)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Mahogany : ModItem
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
                .AddIngredient(ItemID.RichMahogany)
                .AddIngredient(ItemID.RichMahoganySword)
                .AddIngredient(ItemID.RichMahoganyBow)
                .AddIngredient(ItemID.RichMahoganyHammer)
                .AddIngredient(ItemID.RichMahoganyHelmet)
                .AddIngredient(ItemID.RichMahoganyBreastplate)
                .AddIngredient(ItemID.RichMahoganyGreaves)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class MahoganyHouse : ModItem
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
                .AddIngredient(ItemID.RichMahoganyBathtub)
                .AddIngredient(ItemID.RichMahoganyBeam)
                .AddIngredient(ItemID.RichMahoganyBed)
                .AddIngredient(ItemID.RichMahoganyBookcase)
                .AddIngredient(ItemID.RichMahoganyCandelabra)
                .AddIngredient(ItemID.RichMahoganyCandle)
                .AddIngredient(ItemID.RichMahoganyChair)
                .AddIngredient(ItemID.RichMahoganyChandelier)
                .AddIngredient(ItemID.RichMahoganyChest)
                .AddIngredient(ItemID.RichMahoganyClock)
                .AddIngredient(ItemID.RichMahoganyDoor)
                .AddIngredient(ItemID.RichMahoganyDresser)
                .AddIngredient(ItemID.RichMahoganyFence)
                .AddIngredient(ItemID.RichMahoganyLamp)
                .AddIngredient(ItemID.RichMahoganyLantern)
                .AddIngredient(ItemID.RichMahoganyPiano)
                .AddIngredient(ItemID.RichMahoganyPlatform)
                .AddIngredient(ItemID.RichMahoganySink)
                .AddIngredient(ItemID.RichMahoganySofa)
                .AddIngredient(ItemID.RichMahoganyTable)
                .AddIngredient(ItemID.RichMahoganyWall)
                .AddIngredient(ItemID.RichMahoganyWorkBench)
                .AddIngredient(ItemID.ToiletRichMahogany)
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
    public class MarbleHouse : ModItem
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
                .AddIngredient(ItemID.MarbleBathtub)
                .AddIngredient(ItemID.MarbleBed)
                .AddIngredient(ItemID.MarbleBlock)
                .AddIngredient(ItemID.MarbleBlockWall)
                .AddIngredient(ItemID.MarbleBookcase)
                .AddIngredient(ItemID.MarbleCandelabra)
                .AddIngredient(ItemID.MarbleCandle)
                .AddIngredient(ItemID.MarbleChair)
                .AddIngredient(ItemID.MarbleChandelier)
                .AddIngredient(ItemID.MarbleChest)
                .AddIngredient(ItemID.MarbleClock)
                .AddIngredient(ItemID.MarbleColumn)
                .AddIngredient(ItemID.MarbleDoor)
                .AddIngredient(ItemID.MarbleDresser)
                .AddIngredient(ItemID.MarbleLamp)
                .AddIngredient(ItemID.MarbleLantern)
                .AddIngredient(ItemID.MarblePiano)
                .AddIngredient(ItemID.MarblePlatform)
                .AddIngredient(ItemID.MarbleSink)
                .AddIngredient(ItemID.MarbleSofa)
                .AddIngredient(ItemID.MarbleTable)
                .AddIngredient(ItemID.MarbleWorkBench)
                .AddIngredient(ItemID.ToiletMarble)
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
    public class MeteorHouse : ModItem
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
                .AddIngredient(ItemID.MeteoriteBathtub)
                .AddIngredient(ItemID.MeteoriteBed)
                .AddIngredient(ItemID.MeteoriteBookcase)
                .AddIngredient(ItemID.MeteoriteBrick)
                .AddIngredient(ItemID.MeteoriteBrickWall)
                .AddIngredient(ItemID.MeteoriteCandelabra)
                .AddIngredient(ItemID.MeteoriteCandle)
                .AddIngredient(ItemID.MeteoriteChair)
                .AddIngredient(ItemID.MeteoriteChandelier)
                .AddIngredient(ItemID.MeteoriteChest)
                .AddIngredient(ItemID.MeteoriteClock)
                .AddIngredient(ItemID.MeteoriteDoor)
                .AddIngredient(ItemID.MeteoriteDresser)
                .AddIngredient(ItemID.MeteoriteLamp)
                .AddIngredient(ItemID.MeteoriteLantern)
                .AddIngredient(ItemID.MeteoritePiano)
                .AddIngredient(ItemID.MeteoritePlatform)
                .AddIngredient(ItemID.MeteoriteSink)
                .AddIngredient(ItemID.MeteoriteSofa)
                .AddIngredient(ItemID.MeteoriteTable)
                .AddIngredient(ItemID.MeteoriteWorkBench)
                .AddIngredient(ItemID.ToiletMeteor)
                .AddTile(TileID.WorkBenches)
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
    public class ReefHouse : ModItem
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
                .AddIngredient(ItemID.CoralBathtub)
                .AddIngredient(ItemID.CoralBed)
                .AddIngredient(ItemID.CoralBookcase)
                .AddIngredient(ItemID.CoralCandelabra)
                .AddIngredient(ItemID.CoralCandle)
                .AddIngredient(ItemID.CoralChair)
                .AddIngredient(ItemID.CoralChandelier)
                .AddIngredient(ItemID.CoralChest)
                .AddIngredient(ItemID.CoralClock)
                .AddIngredient(ItemID.CoralDoor)
                .AddIngredient(ItemID.CoralDresser)
                .AddIngredient(ItemID.CoralLamp)
                .AddIngredient(ItemID.CoralLantern)
                .AddIngredient(ItemID.CoralPiano)
                .AddIngredient(ItemID.CoralPlatform)
                .AddIngredient(ItemID.CoralSink)
                .AddIngredient(ItemID.CoralSofa)
                .AddIngredient(ItemID.CoralTable)
                .AddIngredient(ItemID.CoralToilet)
                .AddIngredient(ItemID.CoralWorkbench)
                .AddIngredient(ItemID.ReefBlock)
                .AddIngredient(ItemID.ReefWall)
                .AddTile(TileID.WorkBenches)
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
    public class SandstoneHouse : ModItem
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
                .AddIngredient(ItemID.SandstoneBrick)
                .AddIngredient(ItemID.SandstoneBrickWall)
                .AddIngredient(ItemID.DesertChest) // Sandstone Chest
                .AddIngredient(ItemID.SandstoneChair)
                .AddIngredient(ItemID.SandstoneColumn)
                .AddIngredient(ItemID.SandstoneCandle)
                .AddIngredient(ItemID.SandstoneTable)
                .AddIngredient(ItemID.SandstoneWorkbench)
                .AddIngredient(ItemID.SandstonePlatform)
                .AddIngredient(ItemID.SandstonePiano)
                .AddIngredient(ItemID.SandstoneBed)
                .AddIngredient(ItemID.SandstoneDresser)
                .AddIngredient(ItemID.SandstoneDoor)
                .AddIngredient(ItemID.SandstoneBookcase)
                .AddIngredient(ItemID.SandstoneLantern)
                .AddIngredient(ItemID.SandstoneChandelier)
                .AddIngredient(ItemID.SandstoneBathtub)
                .AddIngredient(ItemID.SandstoneLamp)
                .AddIngredient(ItemID.SandstoneCandelabra)
                .AddIngredient(ItemID.SandstoneSofa)
                .AddIngredient(ItemID.SandstoneClock)
                .AddIngredient(ItemID.SandstoneToilet)
                .AddIngredient(ItemID.SandstoneSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class Shadewood : ModItem
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
                .AddIngredient(ItemID.Shadewood)
                .AddIngredient(ItemID.ShadewoodSword)
                .AddIngredient(ItemID.ShadewoodBow)
                .AddIngredient(ItemID.ShadewoodHammer)
                .AddIngredient(ItemID.ShadewoodHelmet)
                .AddIngredient(ItemID.ShadewoodBreastplate)
                .AddIngredient(ItemID.ShadewoodGreaves)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class ShadewoodHouse : ModItem
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
                .AddIngredient(ItemID.ShadewoodBathtub)
                .AddIngredient(ItemID.ShadewoodBed)
                .AddIngredient(ItemID.ShadewoodBookcase)
                .AddIngredient(ItemID.ShadewoodCandelabra)
                .AddIngredient(ItemID.ShadewoodCandle)
                .AddIngredient(ItemID.ShadewoodChair)
                .AddIngredient(ItemID.ShadewoodChandelier)
                .AddIngredient(ItemID.ShadewoodChest)
                .AddIngredient(ItemID.ShadewoodClock)
                .AddIngredient(ItemID.ShadewoodDoor)
                .AddIngredient(ItemID.ShadewoodDresser)
                .AddIngredient(ItemID.ShadewoodFence)
                .AddIngredient(ItemID.ShadewoodLamp)
                .AddIngredient(ItemID.ShadewoodLantern)
                .AddIngredient(ItemID.ShadewoodPiano)
                .AddIngredient(ItemID.ShadewoodPlatform)
                .AddIngredient(ItemID.ShadewoodSink)
                .AddIngredient(ItemID.ShadewoodSofa)
                .AddIngredient(ItemID.ShadewoodTable)
                .AddIngredient(ItemID.ShadewoodWall)
                .AddIngredient(ItemID.ShadewoodWorkBench)
                .AddIngredient(ItemID.ToiletShadewood)
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
    public class SkywareHouse : ModItem
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
                .AddIngredient(ItemID.DiscWall)
                .AddIngredient(ItemID.SkywareBathtub)
                .AddIngredient(ItemID.SkywareBed)
                .AddIngredient(ItemID.SkywareBookcase)
                .AddIngredient(ItemID.SkywareCandelabra)
                .AddIngredient(ItemID.SkywareCandle)
                .AddIngredient(ItemID.SkywareChair)
                .AddIngredient(ItemID.SkywareChandelier)
                .AddIngredient(ItemID.SkywareChest)
                .AddIngredient(ItemID.SkywareClock)
                .AddIngredient(ItemID.SkywareClock2)
                .AddIngredient(ItemID.SkywareDoor)
                .AddIngredient(ItemID.SkywareDresser)
                .AddIngredient(ItemID.SkywareLamp)
                .AddIngredient(ItemID.SkywareLantern)
                .AddIngredient(ItemID.SkywarePiano)
                .AddIngredient(ItemID.SkywarePlatform)
                .AddIngredient(ItemID.SkywareSink)
                .AddIngredient(ItemID.SkywareSofa)
                .AddIngredient(ItemID.SkywareTable)
                .AddIngredient(ItemID.SkywareWorkbench)
                .AddIngredient(ItemID.SunplateBlock)
                .AddIngredient(ItemID.ToiletSunplate)
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
                .AddIngredient(ItemID.WoodenSword)
                .AddIngredient(ItemID.WoodenHammer)
                .AddIngredient(ItemID.WoodenBow)
                .AddIngredient(ItemID.WoodenBoomerang)
                .AddIngredient(ItemID.WoodHelmet)
                .AddIngredient(ItemID.WoodBreastplate)
                .AddIngredient(ItemID.WoodenArrow)
                .AddIngredient(ItemID.WoodGreaves)
                .AddIngredient(ItemID.Acorn)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    public class WoodHouse : ModItem
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
                .AddIngredient(ItemID.WoodWall)
                .AddIngredient(ItemID.WoodPlatform)
                .AddIngredient(ItemID.WoodenTable)
                .AddIngredient(ItemID.Chest)
                .AddIngredient(ItemID.WoodenChair)
                .AddIngredient(ItemID.WoodenDoor)
                .AddIngredient(ItemID.WorkBench)
                .AddIngredient(ItemID.Bookcase)
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