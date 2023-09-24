using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Clentaminator2 : ModItem
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
                .AddIngredient(ItemID.Clentaminator2)
                .AddIngredient(ItemID.SandSolution)
                .AddIngredient(ItemID.SnowSolution)
                .AddIngredient(ItemID.DirtSolution)
                .AddTile(TileID.CrystalBall)
                .Register();
        }
    }
    
    public class Luminite : ModItem
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
                .AddIngredient(ItemID.LunarOre)
                .AddIngredient(ItemID.LunarBar)
                .AddIngredient(ItemID.MoonlordArrow) // Luminite Arrow
                .AddIngredient(ItemID.MoonlordBullet) // Luminite Bullet
                .AddIngredient(ItemID.LunarFlareBook) // Lunar Flare
                .AddIngredient(ItemID.MoonlordTurretStaff) // Lunar Portal Staff
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class Solar : ModItem
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
                .AddIngredient(ItemID.FragmentSolar)
                .AddIngredient(ItemID.SolarFlarePickaxe)
                .AddIngredient(ItemID.LunarHamaxeSolar)
                .AddIngredient(ItemID.SolarEruption)
                .AddIngredient(ItemID.SolarFlareDrill)
                .AddIngredient(ItemID.SolarFlareHelmet)
                .AddIngredient(ItemID.SolarDye)
                .AddIngredient(ItemID.SolarCrawltipedeBanner)
                .AddIngredient(ItemID.SolarDrakomireBanner)
                .AddIngredient(ItemID.SolarDrakomireRiderBanner)
                .AddIngredient(ItemID.SolarSrollerBanner)
                .AddIngredient(ItemID.SolarSolenianBanner)
                .AddIngredient(ItemID.SolarMonolith)
                .AddIngredient(ItemID.SolarFlareBreastplate)
                .AddIngredient(ItemID.SolarFlareLeggings)
                .AddIngredient(ItemID.WingsSolar)
                .AddIngredient(ItemID.DayBreak)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class SolarHouse : ModItem
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
                .AddIngredient(ItemID.SolarBrick)
                .AddIngredient(ItemID.SolarBrickWall)
                .AddIngredient(ItemID.SolarChest)
                .AddIngredient(ItemID.SolarChair)
                .AddIngredient(ItemID.SolarTable)
                .AddIngredient(ItemID.SolarWorkbench)
                .AddIngredient(ItemID.SolarPlatform)
                .AddIngredient(ItemID.SolarPiano)
                .AddIngredient(ItemID.SolarBed)
                .AddIngredient(ItemID.SolarDresser)
                .AddIngredient(ItemID.SolarDoor)
                .AddIngredient(ItemID.SolarBookcase)
                .AddIngredient(ItemID.SolarLantern)
                .AddIngredient(ItemID.SolarCandle)
                .AddIngredient(ItemID.SolarChandelier)
                .AddIngredient(ItemID.SolarBathtub)
                .AddIngredient(ItemID.SolarLamp)
                .AddIngredient(ItemID.SolarCandelabra)
                .AddIngredient(ItemID.SolarSofa)
                .AddIngredient(ItemID.SolarClock)
                .AddIngredient(ItemID.SolarToilet)
                .AddIngredient(ItemID.SolarSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class Stardust : ModItem
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
                .AddIngredient(ItemID.FragmentStardust)
                .AddIngredient(ItemID.StardustPickaxe)
                .AddIngredient(ItemID.LunarHamaxeStardust)
                .AddIngredient(ItemID.StardustDragonStaff)
                .AddIngredient(ItemID.StardustDrill)
                .AddIngredient(ItemID.StardustSmallCellBanner)
                .AddIngredient(ItemID.StardustLargeCellBanner)
                .AddIngredient(ItemID.StardustJellyfishBanner)
                .AddIngredient(ItemID.StardustSoldierBanner)
                .AddIngredient(ItemID.StardustSpiderBanner)
                .AddIngredient(ItemID.StardustHelmet)
                .AddIngredient(ItemID.StardustBreastplate)
                .AddIngredient(ItemID.StardustLeggings)
                .AddIngredient(ItemID.StardustDye)
                .AddIngredient(ItemID.WingsStardust)
                .AddIngredient(ItemID.StardustMonolith)
                .AddIngredient(ItemID.StardustWormBanner)
                .AddIngredient(ItemID.StardustCellStaff)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class StardustHouse : ModItem
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
                .AddIngredient(ItemID.StardustBathtub)
                .AddIngredient(ItemID.StardustBed)
                .AddIngredient(ItemID.StardustBookcase)
                .AddIngredient(ItemID.StardustBrick)
                .AddIngredient(ItemID.StardustBrickWall)
                .AddIngredient(ItemID.StardustCandelabra)
                .AddIngredient(ItemID.StardustCandle)
                .AddIngredient(ItemID.StardustChair)
                .AddIngredient(ItemID.StardustChandelier)
                .AddIngredient(ItemID.StardustChest)
                .AddIngredient(ItemID.StardustClock)
                .AddIngredient(ItemID.StardustDoor)
                .AddIngredient(ItemID.StardustDresser)
                .AddIngredient(ItemID.StardustLamp)
                .AddIngredient(ItemID.StardustLantern)
                .AddIngredient(ItemID.StardustPiano)
                .AddIngredient(ItemID.StardustPlatform)
                .AddIngredient(ItemID.StardustSink)
                .AddIngredient(ItemID.StardustSofa)
                .AddIngredient(ItemID.StardustTable)
                .AddIngredient(ItemID.StardustToilet)
                .AddIngredient(ItemID.StardustWorkbench)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class Vortex : ModItem
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
                .AddIngredient(ItemID.FragmentVortex)
                .AddIngredient(ItemID.VortexPickaxe)
                .AddIngredient(ItemID.LunarHamaxeVortex)
                .AddIngredient(ItemID.VortexBeater)
                .AddIngredient(ItemID.VortexDrill)
                .AddIngredient(ItemID.VortexDye)
                .AddIngredient(ItemID.VortexMonolith)
                .AddIngredient(ItemID.VortexHornetBanner)
                .AddIngredient(ItemID.VortexHornetQueenBanner)
                .AddIngredient(ItemID.VortexLarvaBanner)
                .AddIngredient(ItemID.VortexSoldierBanner)
                .AddIngredient(ItemID.VortexRiflemanBanner)
                .AddIngredient(ItemID.VortexHelmet)
                .AddIngredient(ItemID.VortexBreastplate)
                .AddIngredient(ItemID.VortexLeggings)
                .AddIngredient(ItemID.WingsVortex)
                .AddIngredient(ItemID.Phantasm)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class VortexHouse : ModItem
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
                .AddIngredient(ItemID.VortexBrick)
                .AddIngredient(ItemID.VortexBrickWall)
                .AddIngredient(ItemID.VortexChest)
                .AddIngredient(ItemID.VortexChair)
                .AddIngredient(ItemID.VortexTable)
                .AddIngredient(ItemID.VortexWorkbench)
                .AddIngredient(ItemID.VortexPlatform)
                .AddIngredient(ItemID.VortexPiano)
                .AddIngredient(ItemID.VortexBed)
                .AddIngredient(ItemID.VortexDresser)
                .AddIngredient(ItemID.VortexDoor)
                .AddIngredient(ItemID.VortexBookcase)
                .AddIngredient(ItemID.VortexLantern)
                .AddIngredient(ItemID.VortexCandle)
                .AddIngredient(ItemID.VortexChandelier)
                .AddIngredient(ItemID.VortexBathtub)
                .AddIngredient(ItemID.VortexLamp)
                .AddIngredient(ItemID.VortexCandelabra)
                .AddIngredient(ItemID.VortexSofa)
                .AddIngredient(ItemID.VortexClock)
                .AddIngredient(ItemID.VortexToilet)
                .AddIngredient(ItemID.VortexSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class Nebula : ModItem
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
                .AddIngredient(ItemID.FragmentNebula)
                .AddIngredient(ItemID.NebulaPickaxe)
                .AddIngredient(ItemID.LunarHamaxeNebula)
                .AddIngredient(ItemID.NebulaArcanum)
                .AddIngredient(ItemID.NebulaDrill)
                .AddIngredient(ItemID.NebulaBeastBanner)
                .AddIngredient(ItemID.NebulaHeadcrabBanner)
                .AddIngredient(ItemID.NebulaSoldierBanner)
                .AddIngredient(ItemID.NebulaMonolith)
                .AddIngredient(ItemID.NebulaBrainBanner)
                .AddIngredient(ItemID.NebulaDye)
                .AddIngredient(ItemID.NebulaHelmet)
                .AddIngredient(ItemID.NebulaBreastplate)
                .AddIngredient(ItemID.NebulaLeggings)
                .AddIngredient(ItemID.WingsNebula)
                .AddIngredient(ItemID.NebulaBlaze)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class NebulaHouse : ModItem
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
                .AddIngredient(ItemID.NebulaBrick)
                .AddIngredient(ItemID.NebulaBrickWall)
                .AddIngredient(ItemID.NebulaChest)
                .AddIngredient(ItemID.NebulaChair)
                .AddIngredient(ItemID.NebulaTable)
                .AddIngredient(ItemID.NebulaWorkbench)
                .AddIngredient(ItemID.NebulaPlatform)
                .AddIngredient(ItemID.NebulaPiano)
                .AddIngredient(ItemID.NebulaBed)
                .AddIngredient(ItemID.NebulaDresser)
                .AddIngredient(ItemID.NebulaDoor)
                .AddIngredient(ItemID.NebulaBookcase)
                .AddIngredient(ItemID.NebulaLantern)
                .AddIngredient(ItemID.NebulaCandle)
                .AddIngredient(ItemID.NebulaChandelier)
                .AddIngredient(ItemID.NebulaBathtub)
                .AddIngredient(ItemID.NebulaLamp)
                .AddIngredient(ItemID.NebulaCandelabra)
                .AddIngredient(ItemID.NebulaSofa)
                .AddIngredient(ItemID.NebulaClock)
                .AddIngredient(ItemID.NebulaToilet)
                .AddIngredient(ItemID.NebulaSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class Void : ModItem
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
                .AddIngredient(ItemID.Zenith)
                .AddIngredient(ItemID.BoneKey)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class PostML : ModItem
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
                .AddIngredient(ItemID.LunaticCultistMasterTrophy)
                .AddIngredient(ItemID.MoonLordMasterTrophy)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class MusicBox : ModItem
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
                .AddIngredient(ItemID.MusicBox)
                .AddIngredient(ItemID.MusicBoxAltOverworldDay)
                .AddIngredient(ItemID.MusicBoxAltUnderground)
                .AddIngredient(ItemID.MusicBoxBoss1)
                .AddIngredient(ItemID.MusicBoxBoss2)
                .AddIngredient(ItemID.MusicBoxBoss3)
                .AddIngredient(ItemID.MusicBoxBoss4)
                .AddIngredient(ItemID.MusicBoxBoss5)
                .AddIngredient(ItemID.MusicBoxConsoleTitle)
                .AddIngredient(ItemID.MusicBoxCorruption)
                .AddIngredient(ItemID.MusicBoxCredits)
                .AddIngredient(ItemID.MusicBoxCrimson)
                .AddIngredient(ItemID.MusicBoxDayRemix)
                .AddIngredient(ItemID.MusicBoxDD2)
                .AddIngredient(ItemID.MusicBoxDeerclops)
                .AddIngredient(ItemID.MusicBoxDesert)
                .AddIngredient(ItemID.MusicBoxDukeFishron)
                .AddIngredient(ItemID.MusicBoxDungeon)
                .AddIngredient(ItemID.MusicBoxEclipse)
                .AddIngredient(ItemID.MusicBoxEerie)
                .AddIngredient(ItemID.MusicBoxEmpressOfLight)
                .AddIngredient(ItemID.MusicBoxFrostMoon)
                .AddIngredient(ItemID.MusicBoxGoblins)
                .AddIngredient(ItemID.MusicBoxGraveyard)
                .AddIngredient(ItemID.MusicBoxHell)
                .AddIngredient(ItemID.MusicBoxIce)
                .AddIngredient(ItemID.MusicBoxJungle)
                .AddIngredient(ItemID.MusicBoxJungleNight)
                .AddIngredient(ItemID.MusicBoxLunarBoss)
                .AddIngredient(ItemID.MusicBoxMartians)
                .AddIngredient(ItemID.MusicBoxMorningRain)
                .AddIngredient(ItemID.MusicBoxMushrooms)
                .AddIngredient(ItemID.MusicBoxNight)
                .AddIngredient(ItemID.MusicBoxOcean)
                .AddIngredient(ItemID.MusicBoxOceanAlt)
                .AddIngredient(ItemID.MusicBoxOverworldDay)
                .AddIngredient(ItemID.MusicBoxOWBloodMoon)
                .AddIngredient(ItemID.MusicBoxOWBoss1)
                .AddIngredient(ItemID.MusicBoxOWBoss2)
                .AddIngredient(ItemID.MusicBoxOWCorruption)
                .AddIngredient(ItemID.MusicBoxOWCrimson)
                .AddIngredient(ItemID.MusicBoxOWDay)
                .AddIngredient(ItemID.MusicBoxOWDesert)
                .AddIngredient(ItemID.MusicBoxOWDungeon)
                .AddIngredient(ItemID.MusicBoxOWHallow)
                .AddIngredient(ItemID.MusicBoxOWInvasion)
                .AddIngredient(ItemID.MusicBoxOWJungle)
                .AddIngredient(ItemID.MusicBoxOWMoonLord)
                .AddIngredient(ItemID.MusicBoxOWMushroom)
                .AddIngredient(ItemID.MusicBoxOWNight)
                .AddIngredient(ItemID.MusicBoxOWOcean)
                .AddIngredient(ItemID.MusicBoxOWPlantera)
                .AddIngredient(ItemID.MusicBoxOWRain)
                .AddIngredient(ItemID.MusicBoxOWSnow)
                .AddIngredient(ItemID.MusicBoxOWSpace)
                .AddIngredient(ItemID.MusicBoxOWTowers)
                .AddIngredient(ItemID.MusicBoxOWUnderground)
                .AddIngredient(ItemID.MusicBoxOWUndergroundCorruption)
                .AddIngredient(ItemID.MusicBoxOWUndergroundCrimson)
                .AddIngredient(ItemID.MusicBoxOWUndergroundHallow)
                .AddIngredient(ItemID.MusicBoxOWUndergroundSnow)
                .AddIngredient(ItemID.MusicBoxOWUnderworld)
                .AddIngredient(ItemID.MusicBoxOWWallOfFlesh)
                .AddIngredient(ItemID.MusicBoxPirates)
                .AddIngredient(ItemID.MusicBoxPlantera)
                .AddIngredient(ItemID.MusicBoxPumpkinMoon)
                .AddIngredient(ItemID.MusicBoxQueenSlime)
                .AddIngredient(ItemID.MusicBoxRain)
                .AddIngredient(ItemID.MusicBoxSandstorm)
                .AddIngredient(ItemID.MusicBoxShimmer)
                .AddIngredient(ItemID.MusicBoxSlimeRain)
                .AddIngredient(ItemID.MusicBoxSnow)
                .AddIngredient(ItemID.MusicBoxSpace)
                .AddIngredient(ItemID.MusicBoxSpaceAlt)
                .AddIngredient(ItemID.MusicBoxStorm)
                .AddIngredient(ItemID.MusicBoxTemple)
                .AddIngredient(ItemID.MusicBoxTheHallow)
                .AddIngredient(ItemID.MusicBoxTitle)
                .AddIngredient(ItemID.MusicBoxTitleAlt)
                .AddIngredient(ItemID.MusicBoxTowers)
                .AddIngredient(ItemID.MusicBoxTownDay)
                .AddIngredient(ItemID.MusicBoxTownNight)
                .AddIngredient(ItemID.MusicBoxUnderground)
                .AddIngredient(ItemID.MusicBoxUndergroundCorruption)
                .AddIngredient(ItemID.MusicBoxUndergroundCrimson)
                .AddIngredient(ItemID.MusicBoxUndergroundDesert)
                .AddIngredient(ItemID.MusicBoxUndergroundHallow)
                .AddIngredient(ItemID.MusicBoxUndergroundJungle)
                .AddIngredient(ItemID.MusicBoxWindyDay)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }

    public class Unobtainable : ModItem
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
                .AddIngredient(ItemID.SolarFlareHammer)
                .AddIngredient(ItemID.SolarFlareChainsaw)
                .AddIngredient(ItemID.SolarFlareAxe)
                .AddIngredient(ItemID.NebulaHammer)
                .AddIngredient(ItemID.NebulaChainsaw)
                .AddIngredient(ItemID.NebulaAxe)
                .AddIngredient(ItemID.StardustHammer)
                .AddIngredient(ItemID.StardustChainsaw)
                .AddIngredient(ItemID.StardustAxe)
                .AddIngredient(ItemID.VortexHammer)
                .AddIngredient(ItemID.VortexChainsaw)
                .AddIngredient(ItemID.VortexAxe)
                .AddIngredient(ItemID.FirstFractal)
                .AddIngredient(ItemID.SkeletonBow)
                .AddIngredient(ItemID.BlueCultistArcherBanner)
                .AddIngredient(ItemID.BlueCultistFighterBanner)
                .AddIngredient(ItemID.BlueCultistCasterBanner)
                .AddIngredient(ItemID.WhiteCultistArcherBanner)
                .AddIngredient(ItemID.WhiteCultistFighterBanner)
                .AddIngredient(ItemID.WhiteCultistCasterBanner)
                .AddIngredient(ItemID.SeveredHandBanner)
                .AddIngredient(ItemID.PoisonousSporeBanner)
                .AddIngredient(ItemID.YellowPresent)
                .AddIngredient(ItemID.GreenPresent)
                .AddIngredient(ItemID.ColorOnlyDye)
                .AddIngredient(ItemID.BluePresent)
                .AddIngredient(ItemID.SleepingIcon)
                .AddIngredient(ItemID.CultistBossBag)
                .AddIngredient(ItemID.LesserRestorationPotion)
                .AddIngredient(ItemID.BossBagOgre)
                .AddIngredient(ItemID.BossBagDarkMage)
                .AddIngredient(ItemID.EtherianJavelin)
                .AddIngredient(ItemID.KoboldDynamiteBackpack)
                .AddIngredient(ItemID.GoblinBomberCap)
                .AddIngredient(ItemID.ApplePieSlice)
                .AddIngredient(ItemID.PhasicWarpEjector)
                .AddIngredient(ItemID.BoringBow)
                .AddIngredient(ItemID.OgreMask)
                .AddIngredient(ItemID.GoblinMask)
                .AddIngredient(ItemID.CorruptionKeyMold)
                .AddIngredient(ItemID.CrimsonKeyMold)
                .AddIngredient(ItemID.FrozenKeyMold)
                .AddIngredient(ItemID.HallowedKeyMold)
                .AddIngredient(ItemID.JungleKeyMold)
                .AddIngredient(ItemID.Fake_newchest1)
                .AddIngredient(ItemID.Fake_newchest2)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}