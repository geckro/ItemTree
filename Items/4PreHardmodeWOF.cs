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
                .AddIngredient(ItemID.SkeletronMask)
                .AddIngredient(ItemID.SkeletronHand)
                .AddIngredient(ItemID.BookofSkulls)
                .AddIngredient(ItemID.SkeletronTrophy)
                .AddIngredient(ItemID.Bone)
                .AddIngredient(ItemID.BoneWand)
                .AddIngredient(ItemID.NecroHelmet)
                .AddIngredient(ItemID.NecroBreastplate)
                .AddIngredient(ItemID.NecroGreaves)
                .AddIngredient(ItemID.AncientNecroHelmet)
                .AddIngredient(ItemID.Handgun)
                .AddIngredient(ItemID.AngryBonesBanner)
                .AddIngredient(ItemID.CursedSkullBanner)
                .AddIngredient(ItemID.SkeletonMageBanner) // Dark Caster Banner
                .AddIngredient(ItemID.BoneWelder)
                .AddTile(TileID.BoneWelder)
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
                .AddIngredient(ItemID.WaterBolt)
                .AddIngredient(ItemID.DungeonSlimeBanner)
                .AddIngredient(ItemID.WaterCandle)
                .AddIngredient(ItemID.CobaltShield)
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
                .AddIngredient(ItemID.DemonScythe)
                .AddIngredient(ItemID.FamiliarWig)
                .AddIngredient(ItemID.FamiliarShirt)
                .AddIngredient(ItemID.FamiliarPants)
                .AddIngredient(ItemID.GuideVoodooDoll)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }

    public class PreHardmodeWOF : ModItem
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
                .AddIngredient(ItemID.SkeletronMasterTrophy)
                .AddIngredient(ItemID.DeerclopsMasterTrophy)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}