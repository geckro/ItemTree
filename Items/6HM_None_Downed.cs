using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Angel : ModItem
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
                .AddIngredient(ItemID.AngelWings)
                .AddIngredient(ItemID.HarpyWings)
                .AddIngredient(ItemID.SoulofFlight)
                .AddIngredient(ItemID.MirageDye)
                .AddIngredient(ItemID.WyvernBanner)
                .AddIngredient(ItemID.KiteWyvern)
                .AddIngredient(ItemID.Wyverntail)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    
    public class Adamantite : ModItem
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
                .AddIngredient(ItemID.AdamantiteBar)
                .AddIngredient(ItemID.AdamantiteBeam)
                .AddIngredient(ItemID.AdamantiteBeamWall)
                .AddIngredient(ItemID.AdamantiteBreastplate)
                .AddIngredient(ItemID.AdamantiteChainsaw)
                .AddIngredient(ItemID.AdamantiteDrill)
                .AddIngredient(ItemID.AdamantiteForge)
                .AddIngredient(ItemID.AdamantiteGlaive)
                .AddIngredient(ItemID.AdamantiteHeadgear)
                .AddIngredient(ItemID.AdamantiteHelmet)
                .AddIngredient(ItemID.AdamantiteLeggings)
                .AddIngredient(ItemID.AdamantiteMask)
                .AddIngredient(ItemID.AdamantiteOre)
                .AddIngredient(ItemID.AdamantitePickaxe)
                .AddIngredient(ItemID.AdamantiteRepeater)
                .AddIngredient(ItemID.AdamantiteSword)
                .AddIngredient(ItemID.AdamantiteWaraxe)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class Cobalt : ModItem
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
                .AddIngredient(ItemID.CobaltOre)
                .AddIngredient(ItemID.CobaltBar)
                .AddIngredient(ItemID.CobaltBrick)
                .AddIngredient(ItemID.CobaltBrickWall)
                .AddIngredient(ItemID.CobaltHelmet)
                .AddIngredient(ItemID.CobaltBreastplate)
                .AddIngredient(ItemID.CobaltLeggings)
                .AddIngredient(ItemID.CobaltHat)
                .AddIngredient(ItemID.CobaltMask)
                .AddIngredient(ItemID.CobaltDrill)
                .AddIngredient(ItemID.CobaltPickaxe)
                .AddIngredient(ItemID.CobaltNaginata)
                .AddIngredient(ItemID.CobaltSword)
                .AddIngredient(ItemID.CobaltWaraxe)
                .AddIngredient(ItemID.CobaltRepeater)
                .AddIngredient(ItemID.CobaltChainsaw)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class CrystalHouse : ModItem
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
                .AddIngredient(ItemID.CrystalBlock)
                .AddIngredient(ItemID.CrystalBlockWall)
                .AddIngredient(ItemID.CrystalChest)
                .AddIngredient(ItemID.CrystalChair)
                .AddIngredient(ItemID.CrystalTable)
                .AddIngredient(ItemID.CrystalWorkbench)
                .AddIngredient(ItemID.CrystalPlatform)
                .AddIngredient(ItemID.CrystalPiano)
                .AddIngredient(ItemID.CrystalBed)
                .AddIngredient(ItemID.CrystalDresser)
                .AddIngredient(ItemID.CrystalDoor)
                .AddIngredient(ItemID.CrystalCandle)
                .AddIngredient(ItemID.CrystalBookCase)
                .AddIngredient(ItemID.CrystalLantern)
                .AddIngredient(ItemID.CrystalChandelier)
                .AddIngredient(ItemID.CrystalBathtub)
                .AddIngredient(ItemID.CrystalLamp)
                .AddIngredient(ItemID.CrystalCandelabra)
                .AddIngredient(ItemID
                    .CrystalSofaHowDoesThatEvenWork) // Crystal Sofa How does that even work???????? no fucking way
                .AddIngredient(ItemID.CrystalClock)
                .AddIngredient(ItemID.ToiletCrystal)
                .AddIngredient(ItemID.CrystalSink)
                .AddTile(TileID.SteampunkBoiler)
                .Register();
        }
    }

    public class FleshHouse : ModItem
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
                .AddIngredient(ItemID.FleshBlock)
                .AddIngredient(ItemID.FleshBlockWall)
                .AddIngredient(ItemID.FleshChest)
                .AddIngredient(ItemID.FleshChair)
                .AddIngredient(ItemID.FleshTable)
                .AddIngredient(ItemID.FleshWorkBench)
                .AddIngredient(ItemID.FleshPlatform)
                .AddIngredient(ItemID.FleshPiano)
                .AddIngredient(ItemID.FleshBed)
                .AddIngredient(ItemID.FleshDresser)
                .AddIngredient(ItemID.FleshDoor)
                .AddIngredient(ItemID.FleshBookcase)
                .AddIngredient(ItemID.FleshLantern)
                .AddIngredient(ItemID.FleshChandelier)
                .AddIngredient(ItemID.FleshBathtub)
                .AddIngredient(ItemID.FleshLamp)
                .AddIngredient(ItemID.FleshCandelabra)
                .AddIngredient(ItemID.FleshSofa)
                .AddIngredient(ItemID.FleshCandle)
                .AddIngredient(ItemID.FleshClock)
                .AddIngredient(ItemID.ToiletFlesh)
                .AddIngredient(ItemID.FleshSink)
                .AddTile(TileID.MeatGrinder)
                .Register();
        }
    }

    public class GoldenHouse : ModItem
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
                .AddIngredient(ItemID.GoldenChest)
                .AddIngredient(ItemID.GoldenChair)
                .AddIngredient(ItemID.GoldenCandle)
                .AddIngredient(ItemID.GoldenTable)
                .AddIngredient(ItemID.GoldenWorkbench)
                .AddIngredient(ItemID.GoldenPlatform)
                .AddIngredient(ItemID.GoldenPiano)
                .AddIngredient(ItemID.GoldenBed)
                .AddIngredient(ItemID.GoldenDresser)
                .AddIngredient(ItemID.GoldenDoor)
                .AddIngredient(ItemID.GoldenBookcase)
                .AddIngredient(ItemID.GoldenLantern)
                .AddIngredient(ItemID.GoldenChandelier)
                .AddIngredient(ItemID.GoldenBathtub)
                .AddIngredient(ItemID.GoldenLamp)
                .AddIngredient(ItemID.GoldenCandelabra)
                .AddIngredient(ItemID.GoldenSofa)
                .AddIngredient(ItemID.GoldenClock)
                .AddIngredient(ItemID.GoldenToilet)
                .AddIngredient(ItemID.GoldenSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class Icey : ModItem
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
                .AddIngredient(ItemID.FrostHelmet)
                .AddIngredient(ItemID.FrostBreastplate)
                .AddIngredient(ItemID.FrostLeggings)
                .AddIngredient(ItemID.FrostCore)
                .AddIngredient(ItemID.Frostbrand)
                .AddIngredient(ItemID.IceBow)
                .AddIngredient(ItemID.FlowerofFrost)
                .AddIngredient(ItemID.ToySled)
                .AddIngredient(ItemID.IceSickle)
                .AddIngredient(ItemID.FrostStaff)
                .AddIngredient(ItemID.FrozenTurtleShell)
                .AddIngredient(ItemID.Amarok)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class LesionHouse : ModItem
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
                .AddIngredient(ItemID.LesionBlock)
                .AddIngredient(ItemID.LesionBlockWall)
                .AddIngredient(ItemID.LesionChest)
                .AddIngredient(ItemID.LesionChair)
                .AddIngredient(ItemID.LesionTable)
                .AddIngredient(ItemID.LesionWorkbench)
                .AddIngredient(ItemID.LesionPlatform)
                .AddIngredient(ItemID.LesionPiano)
                .AddIngredient(ItemID.LesionBed)
                .AddIngredient(ItemID.LesionDresser)
                .AddIngredient(ItemID.LesionDoor)
                .AddIngredient(ItemID.LesionBookcase)
                .AddIngredient(ItemID.LesionCandle)
                .AddIngredient(ItemID.LesionLantern)
                .AddIngredient(ItemID.LesionChandelier)
                .AddIngredient(ItemID.LesionBathtub)
                .AddIngredient(ItemID.LesionLamp)
                .AddIngredient(ItemID.LesionCandelabra)
                .AddIngredient(ItemID.LesionSofa)
                .AddIngredient(ItemID.LesionClock)
                .AddIngredient(ItemID.ToiletLesion)
                .AddIngredient(ItemID.LesionSink)
                .AddTile(TileID.MeatGrinder)
                .Register();
        }
    }

    public class Orichalcum : ModItem
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
                .AddIngredient(ItemID.OrichalcumOre)
                .AddIngredient(ItemID.OrichalcumBar)
                .AddIngredient(ItemID.BubblegumBlock)
                .AddIngredient(ItemID.BubblegumBlockWall)
                .AddIngredient(ItemID.OrichalcumHelmet)
                .AddIngredient(ItemID.OrichalcumBreastplate)
                .AddIngredient(ItemID.OrichalcumLeggings)
                .AddIngredient(ItemID.OrichalcumHeadgear)
                .AddIngredient(ItemID.OrichalcumMask)
                .AddIngredient(ItemID.OrichalcumDrill)
                .AddIngredient(ItemID.OrichalcumPickaxe)
                .AddIngredient(ItemID.OrichalcumHalberd)
                .AddIngredient(ItemID.OrichalcumAnvil)
                .AddIngredient(ItemID.OrichalcumSword)
                .AddIngredient(ItemID.OrichalcumWaraxe)
                .AddIngredient(ItemID.OrichalcumRepeater)
                .AddIngredient(ItemID.OrichalcumChainsaw)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class Palladium : ModItem
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
                .AddIngredient(ItemID.PalladiumOre)
                .AddIngredient(ItemID.PalladiumBar)
                .AddIngredient(ItemID.PalladiumColumn)
                .AddIngredient(ItemID.PalladiumColumnWall)
                .AddIngredient(ItemID.PalladiumHelmet)
                .AddIngredient(ItemID.PalladiumBreastplate)
                .AddIngredient(ItemID.PalladiumLeggings)
                .AddIngredient(ItemID.PalladiumHeadgear)
                .AddIngredient(ItemID.PalladiumMask)
                .AddIngredient(ItemID.PalladiumDrill)
                .AddIngredient(ItemID.PalladiumPickaxe)
                .AddIngredient(ItemID.PalladiumPike)
                .AddIngredient(ItemID.PalladiumSword)
                .AddIngredient(ItemID.PalladiumWaraxe)
                .AddIngredient(ItemID.PalladiumRepeater)
                .AddIngredient(ItemID.PalladiumChainsaw)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class Pearlwood : ModItem
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
                .AddIngredient(ItemID.Pearlwood)
                .AddIngredient(ItemID.PearlwoodSword)
                .AddIngredient(ItemID.PearlwoodBow)
                .AddIngredient(ItemID.PearlwoodHammer)
                .AddIngredient(ItemID.PearlwoodHelmet)
                .AddIngredient(ItemID.PearlwoodBreastplate)
                .AddIngredient(ItemID.PearlwoodGreaves)
                .AddIngredient(ItemID.WoodenCrateHard) // Pearlwood Crate
                .AddIngredient(ItemID.Dragonfruit)
                .AddIngredient(ItemID.Starfruit)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    
    public class Pearlstone : ModItem
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
                .AddIngredient(ItemID.PearlstoneBlock)
                .AddIngredient(ItemID.PearlstoneBrick)
                .AddIngredient(ItemID.PearlstoneBrickWall)
                .AddIngredient(ItemID.PearlsandBlock)
                .AddIngredient(ItemID.PinkIceBlock)
                .AddIngredient(ItemID.PearlstoneEcho)
                .AddIngredient(ItemID.Hallow1Echo)
                .AddIngredient(ItemID.Hallow2Echo)
                .AddIngredient(ItemID.Hallow3Echo)
                .AddIngredient(ItemID.Hallow4Echo)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class PearlwoodHouse : ModItem
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
                .AddIngredient(ItemID.PearlwoodWall)
                .AddIngredient(ItemID.PearlwoodChest)
                .AddIngredient(ItemID.PearlwoodChair)
                .AddIngredient(ItemID.PearlwoodTable)
                .AddIngredient(ItemID.PearlwoodWorkBench)
                .AddIngredient(ItemID.PearlwoodPlatform)
                .AddIngredient(ItemID.PearlwoodPiano)
                .AddIngredient(ItemID.PearlwoodBed)
                .AddIngredient(ItemID.PearlwoodDresser)
                .AddIngredient(ItemID.PearlwoodDoor)
                .AddIngredient(ItemID.PearlwoodBookcase)
                .AddIngredient(ItemID.PearlwoodLantern)
                .AddIngredient(ItemID.PearlwoodCandle)
                .AddIngredient(ItemID.PearlwoodChandelier)
                .AddIngredient(ItemID.PearlwoodBathtub)
                .AddIngredient(ItemID.PearlwoodLamp)
                .AddIngredient(ItemID.PearlwoodCandelabra)
                .AddIngredient(ItemID.PearlwoodFence)
                .AddIngredient(ItemID.PearlwoodSofa)
                .AddIngredient(ItemID.PearlwoodClock)
                .AddIngredient(ItemID.ToiletPearlwood)
                .AddIngredient(ItemID.PearlwoodSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    
    public class QueenSlime : ModItem
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
                .AddIngredient(ItemID.QueenSlimeTrophy)
                .AddIngredient(ItemID.QueenSlimeMask)
                .AddIngredient(ItemID.QueenSlimeHook)
                .AddIngredient(ItemID.Smolstar)
                .AddIngredient(ItemID.CrystalNinjaHelmet)
                .AddIngredient(ItemID.CrystalNinjaChestplate)
                .AddIngredient(ItemID.CrystalNinjaLeggings)
                .AddIngredient(ItemID.QueenSlimeHook)
                .AddIngredient(ItemID.QueenSlimeMountSaddle)
                .AddIngredient(ItemID.QueenSlimeCrystal)
                .AddTile(TileID.Solidifier)
                .Register();
        }
    }

    public class Pirate : ModItem
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
                .AddIngredient(ItemID.PirateStaff)
                .AddIngredient(ItemID.Cutlass)
                .AddIngredient(ItemID.PirateCaptainBanner)
                .AddIngredient(ItemID.PirateHat)
                .AddIngredient(ItemID.PirateShirt)
                .AddIngredient(ItemID.PiratePants)
                .AddIngredient(ItemID.PirateCorsairBanner)
                .AddIngredient(ItemID.PirateCrossbowerBanner)
                .AddIngredient(ItemID.PirateDeadeyeBanner)
                .AddIngredient(ItemID.PirateBanner) // Pirate deckhand
                .AddIngredient(ItemID.FlyingDutchmanTrophy)
                .AddIngredient(ItemID.PirateMinecart) // The Dutchman
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    
    public class Pixie : ModItem
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
                .AddIngredient(ItemID.PixieDust)
                .AddIngredient(ItemID.PixieBanner)
                .AddIngredient(ItemID.FairyWings)
                .AddIngredient(ItemID.RainbowRod)
                .AddIngredient(ItemID.HolyArrow)
                .AddIngredient(ItemID.FairyBell)
                .AddIngredient(ItemID.HolyWater)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class Mythril : ModItem
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
                .AddIngredient(ItemID.MythrilOre)
                .AddIngredient(ItemID.MythrilBar)
                .AddIngredient(ItemID.MythrilBrick)
                .AddIngredient(ItemID.MythrilBrickWall)
                .AddIngredient(ItemID.AncientMythrilBrick)
                .AddIngredient(ItemID.AncientMythrilBrickWall)
                .AddIngredient(ItemID.MythrilHelmet)
                .AddIngredient(ItemID.MythrilChainmail)
                .AddIngredient(ItemID.MythrilGreaves)
                .AddIngredient(ItemID.MythrilHat)
                .AddIngredient(ItemID.MythrilHood)
                .AddIngredient(ItemID.MythrilDrill)
                .AddIngredient(ItemID.MythrilPickaxe)
                .AddIngredient(ItemID.MythrilHalberd)
                .AddIngredient(ItemID.MythrilAnvil)
                .AddIngredient(ItemID.MythrilSword)
                .AddIngredient(ItemID.MythrilWaraxe)
                .AddIngredient(ItemID.MythrilRepeater)
                .AddIngredient(ItemID.MythrilChainsaw)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class PreMech : ModItem
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
                .AddIngredient(ItemID.WallofFleshMasterTrophy)
                .AddIngredient(ItemID.QueenSlimeMasterTrophy)
                .AddIngredient(ItemID.FlyingDutchmanMasterTrophy)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class Santa : ModItem
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
                .AddIngredient(ItemID.SantaHat)
                .AddIngredient(ItemID.SantaShirt)
                .AddIngredient(ItemID.SantaPants)
                .AddIngredient(ItemID.ChristmasTree)
                .AddIngredient(ItemID.RedLight)
                .AddIngredient(ItemID.GreenLight)
                .AddIngredient(ItemID.BlueLight)
                .AddTile(TileID.IceMachine)
                .Register();
        }
    }

    public class Shadowflame : ModItem
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
                .AddIngredient(ItemID.GoblinSummonerBanner)
                .AddIngredient(ItemID.ShadowFlameHexDoll)
                .AddIngredient(ItemID.ShadowFlameBow)
                .AddIngredient(ItemID.ShadowFlameKnife)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    
    public class BlackSpider : ModItem
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
                .AddIngredient(ItemID.BlackRecluseBanner)
                .AddIngredient(ItemID.SpiderFang)
                .AddIngredient(ItemID.SpiderMask)
                .AddIngredient(ItemID.SpiderBreastplate)
                .AddIngredient(ItemID.SpiderGreaves)
                .AddIngredient(ItemID.QueenSpiderStaff)
                .AddIngredient(ItemID.SpiderStaff)
                .AddIngredient(ItemID.VenomDartTrap)
                .AddIngredient(ItemID.PoisonStaff)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class SpiderHouse : ModItem
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
                .AddIngredient(ItemID.SpiderBlock)
                .AddIngredient(ItemID.SpiderWall)
                .AddIngredient(ItemID.SpiderChest)
                .AddIngredient(ItemID.SpiderChair)
                .AddIngredient(ItemID.SpiderTable)
                .AddIngredient(ItemID.SpiderWorkbench)
                .AddIngredient(ItemID.SpiderPlatform)
                .AddIngredient(ItemID.SpiderPiano)
                .AddIngredient(ItemID.SpiderBed)
                .AddIngredient(ItemID.SpiderDresser)
                .AddIngredient(ItemID.SpiderDoor)
                .AddIngredient(ItemID.SpiderBookcase)
                .AddIngredient(ItemID.SpiderLantern)
                .AddIngredient(ItemID.SpiderChandelier)
                .AddIngredient(ItemID.SpiderBathtub)
                .AddIngredient(ItemID.SpiderLamp)
                .AddIngredient(ItemID.SpiderCandle)
                .AddIngredient(ItemID.SpiderCandelabra)
                .AddIngredient(ItemID.SpiderSofa)
                .AddIngredient(ItemID.SpiderClock)
                .AddIngredient(ItemID.ToiletSpider)
                .AddIngredient(ItemID.SpiderSinkSpiderSinkDoesWhateverASpiderSinkDoes)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class Terra : ModItem
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
                .AddIngredient(ItemID.TerraBlade)
                .AddIngredient(ItemID.TerraToilet)
                .AddIngredient(ItemID.TerraFartMinecart) // me when i taco spicy
                .AddIngredient(ItemID.BrokenHeroSword)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class Titanium : ModItem
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
                .AddIngredient(ItemID.TitaniumOre)
                .AddIngredient(ItemID.TitaniumBar)
                .AddIngredient(ItemID.TitanstoneBlockWall)
                .AddIngredient(ItemID.TitanstoneBlock)
                .AddIngredient(ItemID.TitaniumHelmet)
                .AddIngredient(ItemID.TitaniumBreastplate)
                .AddIngredient(ItemID.TitaniumLeggings)
                .AddIngredient(ItemID.TitaniumHeadgear)
                .AddIngredient(ItemID.TitaniumMask)
                .AddIngredient(ItemID.TitaniumDrill)
                .AddIngredient(ItemID.TitaniumPickaxe)
                .AddIngredient(ItemID.TitaniumTrident)
                .AddIngredient(ItemID.TitaniumForge)
                .AddIngredient(ItemID.TitaniumSword)
                .AddIngredient(ItemID.TitaniumWaraxe)
                .AddIngredient(ItemID.TitaniumRepeater)
                .AddIngredient(ItemID.TitaniumChainsaw)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    
    public class Unicorn : ModItem
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
                .AddIngredient(ItemID.UnicornBanner)
                .AddIngredient(ItemID.BlessedApple)
                .AddIngredient(ItemID.UnicornHorn)
                .AddIngredient(ItemID.UnicornonaStick)
                .AddIngredient(ItemID.KiteUnicorn)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}