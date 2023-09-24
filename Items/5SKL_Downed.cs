using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class BlueDungeonHouse : ModItem
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
                .AddIngredient(ItemID.BlueBrick)
                .AddIngredient(ItemID.BlueBrickWall)
                .AddIngredient(ItemID.BlueDungeonChest)
                .AddIngredient(ItemID.BlueDungeonChair)
                .AddIngredient(ItemID.BlueDungeonTable)
                .AddIngredient(ItemID.BlueDungeonWorkBench)
                .AddIngredient(ItemID.BlueBrickPlatform)
                .AddIngredient(ItemID.BlueDungeonPiano)
                .AddIngredient(ItemID.BlueDungeonBed)
                .AddIngredient(ItemID.BlueDungeonDresser)
                .AddIngredient(ItemID.BlueDungeonDoor)
                .AddIngredient(ItemID.BlueDungeonBookcase)
                .AddIngredient(ItemID.BlueDungeonChandelier)
                .AddIngredient(ItemID.BlueDungeonBathtub)
                .AddIngredient(ItemID.BlueDungeonLamp)
                .AddIngredient(ItemID.BlueDungeonCandelabra)
                .AddIngredient(ItemID.BlueDungeonCandle)
                .AddIngredient(ItemID.BlueDungeonVase)
                .AddIngredient(ItemID.BlueDungeonSofa)
                .AddIngredient(ItemID.DungeonClockBlue)
                .AddIngredient(ItemID.ToiletDungeonBlue)
                .AddIngredient(ItemID.BlueDungeonSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    
    public class Reference : ModItem
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
                .AddIngredient(ItemID.SummerHat)
                .AddIngredient(ItemID.PlumbersHat)
                .AddIngredient(ItemID.PlumbersShirt)
                .AddIngredient(ItemID.PlumbersPants)
                .AddTile(TileID.MushroomPlants)
                .Register();
        }
    }
    
    public class BoneHouse : ModItem
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
                .AddIngredient(ItemID.BoneBlockWall)
                .AddIngredient(ItemID.BoneChest)
                .AddIngredient(ItemID.BoneChair)
                .AddIngredient(ItemID.BoneTable)
                .AddIngredient(ItemID.BoneWorkBench)
                .AddIngredient(ItemID.BonePlatform)
                .AddIngredient(ItemID.BonePiano)
                .AddIngredient(ItemID.BoneBed)
                .AddIngredient(ItemID.BoneDresser)
                .AddIngredient(ItemID.BoneDoor)
                .AddIngredient(ItemID.BoneBookcase)
                .AddIngredient(ItemID.BoneLantern)
                .AddIngredient(ItemID.BoneChandelier)
                .AddIngredient(ItemID.BoneBathtub)
                .AddIngredient(ItemID.BoneLamp)
                .AddIngredient(ItemID.BoneCandelabra)
                .AddIngredient(ItemID.BoneSofa)
                .AddIngredient(ItemID.BoneClock)
                .AddIngredient(ItemID.ToiletBone)
                .AddIngredient(ItemID.BoneSink)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }
    
    public class Clothier : ModItem
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
                .AddIngredient(ItemID.ClothierVoodooDoll)
                .AddIngredient(ItemID.BlackThread)
                .AddIngredient(ItemID.PinkThread)
                .AddIngredient(ItemID.PlacePainting)
                .AddIngredient(ItemID.SummerHat)
                .AddIngredient(ItemID.PlumbersShirt)
                .AddIngredient(ItemID.PlumbersPants)
                .AddIngredient(ItemID.WhiteTuxedoPants)
                .AddIngredient(ItemID.WhiteTuxedoShirt)
                .AddIngredient(ItemID.TheDoctorsPants)
                .AddIngredient(ItemID.TheDoctorsShirt)
                .AddIngredient(ItemID.FamiliarWig)
                .AddIngredient(ItemID.FamiliarShirt)
                .AddIngredient(ItemID.FamiliarPants)
                .AddIngredient(ItemID.MimeMask)
                .AddIngredient(ItemID.FallenTuxedoPants)
                .AddIngredient(ItemID.FallenTuxedoShirt)
                .AddIngredient(ItemID.FuneralHat)
                .AddIngredient(ItemID.FuneralCoat)
                .AddIngredient(ItemID.FuneralPants)
                .AddIngredient(ItemID.UndertakerHat)
                .AddIngredient(ItemID.UndertakerCoat)
                .AddIngredient(ItemID.TragicUmbrella)
                .AddIngredient(ItemID.VictorianGothHat)
                .AddIngredient(ItemID.VictorianGothDress)
                .AddIngredient(ItemID.Beanie)
                .AddIngredient(ItemID.GuyFawkesMask)
                .AddIngredient(ItemID.ClothierJacket)
                .AddIngredient(ItemID.ClothierPants)
                .AddIngredient(ItemID.PartyBundleOfBalloonsAccessory)
                .AddIngredient(ItemID.PartyBalloonAnimal)
                .AddIngredient(ItemID.FlowerBoyHat)
                .AddIngredient(ItemID.FlowerBoyShirt)
                .AddIngredient(ItemID.FlowerBoyPants)
                .AddIngredient(ItemID.HunterCloak)
                .AddIngredient(ItemID.RedHat)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }

    public class GothicHouse : ModItem
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
                .AddIngredient(ItemID.TerrarianGothic)
                .AddIngredient(ItemID.GothicChair)
                .AddIngredient(ItemID.GothicTable)
                .AddIngredient(ItemID.GothicBookcase)
                .AddIngredient(ItemID.DungeonDoor)
                .AddIngredient(ItemID.DungeonShelf)
                .AddIngredient(ItemID.MetalShelf)
                .AddIngredient(ItemID.BrassShelf)
                .AddIngredient(ItemID.WoodShelf)
                .AddIngredient(ItemID.Catacomb)
                .AddIngredient(ItemID.HangingSkeleton)
                .AddIngredient(ItemID.WallSkeleton)
                .AddIngredient(ItemID.BrassLantern)
                .AddIngredient(ItemID.CagedLantern)
                .AddIngredient(ItemID.CarriageLantern)
                .AddIngredient(ItemID.AlchemyLantern)
                .AddIngredient(ItemID.DiablostLamp)
                .AddIngredient(ItemID.OilRagSconse)
                .AddIngredient(ItemID.MarchingBonesBanner)
                .AddIngredient(ItemID.NecromanticSign)
                .AddIngredient(ItemID.RustedCompanyStandard)
                .AddIngredient(ItemID.RaggedBrotherhoodSigil)
                .AddIngredient(ItemID.MoltenLegionFlag)
                .AddIngredient(ItemID.DiabolicSigil)
                .AddIngredient(ItemID.Spike)
                .AddIngredient(ItemID.ChainLantern)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class GreenDungeonHouse : ModItem
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
                .AddIngredient(ItemID.GreenBrick)
                .AddIngredient(ItemID.GreenBrickWall)
                .AddIngredient(ItemID.GreenDungeonChest)
                .AddIngredient(ItemID.GreenDungeonChair)
                .AddIngredient(ItemID.GreenDungeonTable)
                .AddIngredient(ItemID.GreenDungeonWorkBench)
                .AddIngredient(ItemID.GreenBrickPlatform)
                .AddIngredient(ItemID.GreenDungeonPiano)
                .AddIngredient(ItemID.GreenDungeonBed)
                .AddIngredient(ItemID.GreenDungeonDresser)
                .AddIngredient(ItemID.GreenDungeonDoor)
                .AddIngredient(ItemID.GreenDungeonBookcase)
                .AddIngredient(ItemID.GreenDungeonChandelier)
                .AddIngredient(ItemID.GreenDungeonCandle)
                .AddIngredient(ItemID.GreenDungeonVase)
                .AddIngredient(ItemID.GreenDungeonBathtub)
                .AddIngredient(ItemID.GreenDungeonLamp)
                .AddIngredient(ItemID.GreenDungeonCandelabra)
                .AddIngredient(ItemID.GreenDungeonSofa)
                .AddIngredient(ItemID.DungeonClockGreen)
                .AddIngredient(ItemID.ToiletDungeonGreen)
                .AddIngredient(ItemID.GreenDungeonSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class PinkDungeonHouse : ModItem
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
                .AddIngredient(ItemID.PinkBrick)
                .AddIngredient(ItemID.PinkBrickWall)
                .AddIngredient(ItemID.PinkDungeonChest)
                .AddIngredient(ItemID.PinkDungeonChair)
                .AddIngredient(ItemID.PinkDungeonTable)
                .AddIngredient(ItemID.PinkDungeonWorkBench)
                .AddIngredient(ItemID.PinkBrickPlatform)
                .AddIngredient(ItemID.PinkDungeonCandle)
                .AddIngredient(ItemID.PinkDungeonVase)
                .AddIngredient(ItemID.PinkDungeonPiano)
                .AddIngredient(ItemID.PinkDungeonBed)
                .AddIngredient(ItemID.PinkDungeonDresser)
                .AddIngredient(ItemID.PinkDungeonDoor)
                .AddIngredient(ItemID.PinkDungeonBookcase)
                .AddIngredient(ItemID.PinkDungeonChandelier)
                .AddIngredient(ItemID.PinkDungeonBathtub)
                .AddIngredient(ItemID.PinkDungeonLamp)
                .AddIngredient(ItemID.PinkDungeonCandelabra)
                .AddIngredient(ItemID.PinkDungeonSofa)
                .AddIngredient(ItemID.DungeonClockPink)
                .AddIngredient(ItemID.ToiletDungeonPink)
                .AddIngredient(ItemID.PinkDungeonSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class Skeletron : ModItem
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
                .AddIngredient(ItemID.ChippysCouch)
                .AddIngredient(ItemID.SkeletronBossBag)
                .AddIngredient(ItemID.SkeletronMask)
                .AddIngredient(ItemID.BoneGlove)
                .AddIngredient(ItemID.SkeletronHand)
                .AddIngredient(ItemID.BookofSkulls)
                .AddIngredient(ItemID.SkeletronTrophy)
                .AddIngredient(ItemID.SkeletronMasterTrophy)
                .AddIngredient(ItemID.SkeletronPetItem)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }

    public class DungeonSkeleton : ModItem
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
                .AddIngredient(ItemID.ShadowKey)
                .AddIngredient(ItemID.GoldenKey)
                .AddIngredient(ItemID.Bone)
                .AddIngredient(ItemID.BoneWand)
                .AddIngredient(ItemID.AncientNecroHelmet)
                .AddIngredient(ItemID.NecroHelmet)
                .AddIngredient(ItemID.NecroBreastplate)
                .AddIngredient(ItemID.Fertilizer)
                .AddIngredient(ItemID.TitanPotion)
                .AddIngredient(ItemID.NecroBreastplate)
                .AddIngredient(ItemID.NecroGreaves)
                .AddIngredient(ItemID.AlchemyTable)
                .AddIngredient(ItemID.BewitchingTable)
                .AddIngredient(ItemID.TallyCounter)
                .AddIngredient(ItemID.Handgun)
                .AddIngredient(ItemID.ClosedVoidBag)
                .AddIngredient(ItemID.VoidVault)
                .AddIngredient(ItemID.TeaKettle)
                .AddIngredient(ItemID.REK)
                .AddIngredient(ItemID.MechanicsRod)
                .AddIngredient(ItemID.PDA)
                .AddIngredient(ItemID.CellPhone)
                .AddIngredient(ItemID.Shellphone)
                .AddIngredient(ItemID.ChestLock)
                .AddIngredient(ItemID.PlaguebringerHelmet)
                .AddIngredient(ItemID.TimelessTravelerHood)
                .AddIngredient(ItemID.AngryBonesBanner)
                .AddIngredient(ItemID.BoneWhip)
                .AddIngredient(ItemID.SkullLantern)
                .AddIngredient(ItemID.CreamSoda)
                .AddIngredient(ItemID.CursedSkullBanner)
                .AddIngredient(ItemID.SkeletonMageBanner) // Dark Caster Banner
                .AddIngredient(ItemID.BoneWelder)
                .Register();
        }
    }
    
    public class DungeonPaintings : ModItem
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
                .AddIngredient(ItemID.BloodMoonRising)
                .AddIngredient(ItemID.BoneWarp)
                .AddIngredient(ItemID.TheCreationoftheGuide)
                .AddIngredient(ItemID.TheCursedMan)
                .AddIngredient(ItemID.TheDestroyer)
                .AddIngredient(ItemID.Dryadisque)
                .AddIngredient(ItemID.TheEyeSeestheEnd)
                .AddIngredient(ItemID.FacingtheCerebralMastermind)
                .AddIngredient(ItemID.GloryoftheFire)
                .AddIngredient(ItemID.GoblinsPlayingPoker)
                .AddIngredient(ItemID.GreatWave)
                .AddIngredient(ItemID.TheGuardiansGaze)
                .AddIngredient(ItemID.TheHangedMan)
                .AddIngredient(ItemID.Impact)
                .AddIngredient(ItemID.ThePersistencyofEyes)
                .AddIngredient(ItemID.PoweredbyBirds)
                .AddIngredient(ItemID.TheScreamer)
                .AddIngredient(ItemID.SkellingtonJSkellingsworth)
                .AddIngredient(ItemID.SparkyPainting)
                .AddIngredient(ItemID.SomethingEvilisWatchingYou)
                .AddIngredient(ItemID.StarryNight)
                .AddIngredient(ItemID.TrioSuperHeroes)
                .AddIngredient(ItemID.TheTwinsHaveAwoken)
                .AddIngredient(ItemID.UnicornCrossingtheHallows)
                .AddTile(TileID.AlchemyTable)
                .Register();
        }
    }
    
    public class Wires : ModItem
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
                .AddIngredient(ItemID.CombatWrench)
                .AddIngredient(ItemID.Wire)
                .AddIngredient(ItemID.Wrench)
                .AddIngredient(ItemID.GreenWrench)
                .AddIngredient(ItemID.BlueWrench)
                .AddIngredient(ItemID.YellowWrench)
                .AddIngredient(ItemID.MulticolorWrench)
                .AddIngredient(ItemID.WireCutter)
                .AddIngredient(ItemID.ActuationRod)
                .AddIngredient(ItemID.WireKite)
                .AddIngredient(ItemID.Timer1Second)
                .AddIngredient(ItemID.Timer3Second)
                .AddIngredient(ItemID.Timer5Second)
                .AddIngredient(ItemID.TimerOneHalfSecond)
                .AddIngredient(ItemID.TimerOneFourthSecond)
                .AddIngredient(ItemID.Actuator)
                .AddIngredient(ItemID.LaserRuler)
                .AddIngredient(ItemID.MechanicalLens)
                .AddIngredient(ItemID.WireBulb)
                .AddIngredient(ItemID.Lever)
                .AddIngredient(ItemID.Switch)
                .AddIngredient(ItemID.PixelBox)
                .AddIngredient(ItemID.EngineeringHelmet)
                .AddIngredient(ItemID.WirePipe)
                .AddIngredient(ItemID.Teleporter)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
    
    public class PressurePlate : ModItem
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
                .AddIngredient(ItemID.RedPressurePlate)
                .AddIngredient(ItemID.GreenPressurePlate)
                .AddIngredient(ItemID.GrayPressurePlate)
                .AddIngredient(ItemID.BrownPressurePlate)
                .AddIngredient(ItemID.BluePressurePlate)
                .AddIngredient(ItemID.YellowPressurePlate)
                .AddIngredient(ItemID.OrangePressurePlate)
                .AddIngredient(ItemID.ProjectilePressurePad)
                .AddIngredient(ItemID.WeightedPressurePlateCyan)
                .AddIngredient(ItemID.WeightedPressurePlateOrange)
                .AddIngredient(ItemID.WeightedPressurePlatePink)
                .AddIngredient(ItemID.WeightedPressurePlatePurple)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class DungeonWater : ModItem
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
                .AddIngredient(ItemID.Muramasa)
                .AddIngredient(ItemID.BlueMoon)
                .AddIngredient(ItemID.AquaScepter)
                .AddIngredient(ItemID.MagicMissile)
                .AddIngredient(ItemID.Nazar)
                .AddIngredient(ItemID.Valor)
                .AddIngredient(ItemID.WaterBolt)
                .AddIngredient(ItemID.DungeonSlimeBanner)
                .AddIngredient(ItemID.WaterCandle)
                .AddIngredient(ItemID.CobaltShield)
                .AddIngredient(ItemID.DungeonFishingCrate)
                .AddIngredient(ItemID.LockBox)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }

    public class Evil : ModItem
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
                .AddIngredient(ItemID.NightsEdge)
                .AddIngredient(ItemID.DarkLance)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
    
    public class Pianos : ModItem
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
                .AddIngredient(ItemID.Piano)
                .AddIngredient(ItemID.AshWoodPiano)
                .AddIngredient(ItemID.BalloonPiano)
                .AddIngredient(ItemID.BambooPiano)
                .AddIngredient(ItemID.BorealWoodPiano)
                .AddIngredient(ItemID.CactusPiano)
                .AddIngredient(ItemID.EbonwoodPiano)
                .AddIngredient(ItemID.DynastyPiano)
                .AddIngredient(ItemID.FrozenPiano)
                .AddIngredient(ItemID.GlassPiano)
                .AddIngredient(ItemID.MushroomPiano)
                .AddIngredient(ItemID.GranitePiano)
                .AddIngredient(ItemID.HoneyPiano)
                .AddIngredient(ItemID.LivingWoodPiano)
                .AddIngredient(ItemID.PalmWoodPiano)
                .AddIngredient(ItemID.RichMahoganyPiano)
                .AddIngredient(ItemID.MarblePiano)
                .AddIngredient(ItemID.MeteoritePiano)
                .AddIngredient(ItemID.CoralPiano)
                .AddIngredient(ItemID.SandstonePiano)
                .AddIngredient(ItemID.ShadewoodPiano)
                .AddIngredient(ItemID.SkywarePiano)
                .AddIngredient(ItemID.PumpkinPiano)
                .AddIngredient(ItemID.SlimePiano)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }
    
    public class Bookcases : ModItem
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
                .AddIngredient(ItemID.Bookcase)
                .AddIngredient(ItemID.AshWoodBookcase)
                .AddIngredient(ItemID.BalloonBookcase)
                .AddIngredient(ItemID.BambooBookcase)
                .AddIngredient(ItemID.BorealWoodBookcase)
                .AddIngredient(ItemID.CactusBookcase)
                .AddIngredient(ItemID.EbonwoodBookcase)
                .AddIngredient(ItemID.DynastyBookcase)
                .AddIngredient(ItemID.FrozenBookcase)
                .AddIngredient(ItemID.GlassBookcase)
                .AddIngredient(ItemID.MushroomBookcase)
                .AddIngredient(ItemID.GraniteBookcase)
                .AddIngredient(ItemID.HoneyBookcase)
                .AddIngredient(ItemID.LivingWoodBookcase)
                .AddIngredient(ItemID.PalmWoodBookcase)
                .AddIngredient(ItemID.RichMahoganyBookcase)
                .AddIngredient(ItemID.MarbleBookcase)
                .AddIngredient(ItemID.MeteoriteBookcase)
                .AddIngredient(ItemID.CoralBookcase)
                .AddIngredient(ItemID.SandstoneBookcase)
                .AddIngredient(ItemID.ShadewoodBookcase)
                .AddIngredient(ItemID.SkywareBookcase)
                .AddIngredient(ItemID.PumpkinBookcase)
                .AddIngredient(ItemID.SlimeBookcase)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }
}