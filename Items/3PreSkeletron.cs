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
                .AddIngredient(ItemID.HiveBackpack) // Hive Pack
                .AddTile(TileID.HoneyDispenser)
                .Register();
        }
    }

    public class CrimtanePreSkele : ModItem
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
                .AddIngredient(ItemID.CrimsonHelmet)
                .AddIngredient(ItemID.CrimsonScalemail)
                .AddIngredient(ItemID.CrimsonGreaves)
                .AddIngredient(ItemID.DeathbringerPickaxe)
                .AddIngredient(ItemID.FleshGrinder)
                .AddIngredient(ItemID.TheMeatball)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }

    public class DemonitePreSkele : ModItem
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
                .AddIngredient(ItemID.ShadowHelmet)
                .AddIngredient(ItemID.ShadowScalemail)
                .AddIngredient(ItemID.ShadowGreaves)
                .AddIngredient(ItemID.NightmarePickaxe)
                .AddIngredient(ItemID.TheBreaker)
                .AddIngredient(ItemID.ShadowScale)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }

    public class Hellstone : ModItem
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
                .AddIngredient(ItemID.AshBlock)
                .AddIngredient(ItemID.Hellstone)
                .AddIngredient(ItemID.HellstoneBar)
                .AddIngredient(ItemID.Hellforge)
                .AddIngredient(ItemID.HellstoneBrick)
                .AddIngredient(ItemID.HellstoneBrickWall)
                .AddIngredient(ItemID.AncientHellstoneBrick)
                .AddIngredient(ItemID.AncientHellstoneBrickWall)
                .AddIngredient(ItemID.Cascade)
                .AddIngredient(ItemID.FieryGreatsword) // Volcano
                .AddIngredient(ItemID.MoltenPickaxe)
                .AddIngredient(ItemID.MoltenHamaxe)
                .AddIngredient(ItemID.PhoenixBlaster)
                .AddIngredient(ItemID.Sunfury)
                .AddIngredient(ItemID.Flamarang)
                .AddIngredient(ItemID.MoltenFury)
                .AddIngredient(ItemID.FlowerofFire)
                .AddIngredient(ItemID.Flamelash)
                .AddIngredient(ItemID.MoltenHelmet)
                .AddIngredient(ItemID.MoltenBreastplate)
                .AddIngredient(ItemID.MoltenGreaves)
                .AddTile(TileID.Furnaces)
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
                .AddIngredient(ItemID.BeeCloak)
                .AddIngredient(ItemID.StingerNecklace)
                .AddIngredient(ItemID.HiveFive)
                .AddIngredient(ItemID.HornetStaff)
                .AddIngredient(ItemID.Nectar)
                .AddTile(TileID.HoneyDispenser)
                .Register();
        }
    }

    public class ObsidianHouse : ModItem
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
                .AddIngredient(ItemID.ObsidianBathtub)
                .AddIngredient(ItemID.ObsidianBed)
                .AddIngredient(ItemID.ObsidianBookcase)
                .AddIngredient(ItemID.ObsidianBrick)
                .AddIngredient(ItemID.ObsidianBrickWall)
                .AddIngredient(ItemID.ObsidianCandelabra)
                .AddIngredient(ItemID.ObsidianCandle)
                .AddIngredient(ItemID.ObsidianChair)
                .AddIngredient(ItemID.ObsidianChandelier)
                .AddIngredient(ItemID.ObsidianChest)
                .AddIngredient(ItemID.ObsidianClock)
                .AddIngredient(ItemID.ObsidianDoor)
                .AddIngredient(ItemID.ObsidianDresser)
                .AddIngredient(ItemID.ObsidianLamp)
                .AddIngredient(ItemID.ObsidianLantern)
                .AddIngredient(ItemID.ObsidianPiano)
                .AddIngredient(ItemID.ObsidianPlatform)
                .AddIngredient(ItemID.ObsidianSink)
                .AddIngredient(ItemID.ObsidianSofa)
                .AddIngredient(ItemID.ObsidianTable)
                .AddIngredient(ItemID.ObsidianVase)
                .AddIngredient(ItemID.ObsidianWorkBench)
                .AddIngredient(ItemID.ToiletObsidian)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }

    public class PreSkeletron : ModItem
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
                .AddIngredient(ItemID.EaterofWorldsMasterTrophy)
                .AddIngredient(ItemID.BrainofCthulhuMasterTrophy)
                .AddIngredient(ItemID.QueenBeeMasterTrophy)
                .AddIngredient(ItemID.DarkMageMasterTrophy)
                .AddTile(TileID.DemonAltar)
                .Register();
        }
    }
}