using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
    public class Beetle : ModItem
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
                .AddIngredient(ItemID.BeetleMinecart)
                .AddIngredient(ItemID.BeetleHelmet)
                .AddIngredient(ItemID.BeetleScaleMail)
                .AddIngredient(ItemID.BeetleShell)
                .AddIngredient(ItemID.BeetleLeggings)
                .AddIngredient(ItemID.BeetleWings)
                .AddIngredient(ItemID.BeetleHusk)
                .AddTile(TileID.LihzahrdFurnace)
                .Register();
        }
    }

    public class Fishron : ModItem
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
                .AddIngredient(ItemID.BubbleGun)
                .AddIngredient(ItemID.DukeFishronMask)
                .AddIngredient(ItemID.DukeFishronTrophy)
                .AddIngredient(ItemID.Flairon)
                .AddIngredient(ItemID.Fishron)
                .AddIngredient(ItemID.RazorbladeTyphoon)
                .AddIngredient(ItemID.Tsunami)
                .AddIngredient(ItemID.TempestStaff)
                .AddIngredient(ItemID.FishronWings)
                .AddTile(TileID.Autohammer)
                .Register();
        }
    }

    public class Golem : ModItem
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
                .AddIngredient(ItemID.Picksaw)
                .AddIngredient(ItemID.Stynger)
                .AddIngredient(ItemID.SunStone)
                .AddIngredient(ItemID.GolemFist)
                .AddIngredient(ItemID.StaffofEarth)
                .AddIngredient(ItemID.HeatRay)
                .AddIngredient(ItemID.EyeoftheGolem)
                .AddIngredient(ItemID.PossessedHatchet)
                .AddIngredient(ItemID.StyngerBolt)
                .AddIngredient(ItemID.GolemMask)
                .AddIngredient(ItemID.GolemTrophy)
                .AddTile(TileID.LihzahrdFurnace)
                .Register();
        }
    }

    public class Martian1 : ModItem
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
                .AddIngredient(ItemID.MartianConduitPlating)
                .AddIngredient(ItemID.MartianConduitWall)
                .AddIngredient(ItemID.LaserDrill)
                .AddIngredient(ItemID.ChargedBlasterCannon)
                .AddIngredient(ItemID.AntiGravityHook)
                .AddIngredient(ItemID.CosmicCarKey)
                .AddIngredient(ItemID.InfluxWaver)
                .AddIngredient(ItemID.MartianSaucerTrophy)
                .AddIngredient(ItemID.LaserMachinegun)
                .AddIngredient(ItemID.Xenopopper)
                .AddIngredient(ItemID.ElectrosphereLauncher)
                .AddIngredient(ItemID.BrainScrambler)
                .AddIngredient(ItemID.MartianCostumeMask)
                .AddIngredient(ItemID.MartianCostumeShirt)
                .AddIngredient(ItemID.MartianCostumePants)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class Martian2 : ModItem
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
                .AddIngredient(ItemID.MartianUniformHelmet)
                .AddIngredient(ItemID.MartianUniformTorso)
                .AddIngredient(ItemID.MartianUniformPants)
                .AddIngredient(ItemID.MartianGigazapperBanner)
                .AddIngredient(ItemID.MartianEngineerBanner)
                .AddIngredient(ItemID.MartianOfficerBanner)
                .AddIngredient(ItemID.MartianRaygunnerBanner)
                .AddIngredient(ItemID.MartianGreyGruntBanner)
                .AddIngredient(ItemID.MartianTeslaTurretBanner)
                .AddIngredient(ItemID.ScutlixBanner)
                .AddIngredient(ItemID.MartianWalkerBanner)
                .AddIngredient(ItemID.MartianDroneBanner)
                .AddIngredient(ItemID.MartianBrainscramblerBanner)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }

    public class MartianHouse : ModItem
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
                .AddIngredient(ItemID.MartianConduitPlating)
                .AddIngredient(ItemID.MartianConduitWall)
                .AddIngredient(ItemID.MartianChest)
                .AddIngredient(ItemID.MartianHoverChair)
                .AddIngredient(ItemID.MartianTable)
                .AddIngredient(ItemID.MartianWorkBench)
                .AddIngredient(ItemID.MartianPlatform)
                .AddIngredient(ItemID.MartianPiano)
                .AddIngredient(ItemID.MartianBed)
                .AddIngredient(ItemID.MartianDresser)
                .AddIngredient(ItemID.MartianDoor)
                .AddIngredient(ItemID.MartianHolobookcase)
                .AddIngredient(ItemID.MartianLantern)
                .AddIngredient(ItemID.MartianChandelier)
                .AddIngredient(ItemID.MartianBathtub)
                .AddIngredient(ItemID.MartianLamppost)
                .AddIngredient(ItemID.MartianHoverCandle)
                .AddIngredient(ItemID.MartianTableLamp)
                .AddIngredient(ItemID.MartianSofa)
                .AddIngredient(ItemID.MartianAstroClock)
                .AddIngredient(ItemID.ToiletMartian)
                .AddIngredient(ItemID.MartianSink)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }

    public class PreCultist : ModItem
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
                .AddIngredient(ItemID.GolemMasterTrophy)
                .AddIngredient(ItemID.DukeFishronMasterTrophy)
                .AddIngredient(ItemID.BetsyMasterTrophy)
                .AddIngredient(ItemID.UFOMasterTrophy)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}