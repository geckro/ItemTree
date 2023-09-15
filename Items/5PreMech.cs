using Terraria.ID;
using Terraria.ModLoader;

namespace ItemTree.Items
{
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
                .AddIngredient(ItemID.AdamantiteOre)
                .AddIngredient(ItemID.AdamantiteBar)
                .AddIngredient(ItemID.AdamantiteBeam)
                .AddIngredient(ItemID.AdamantiteBeamWall)
                .AddIngredient(ItemID.AdamantiteHelmet)
                .AddIngredient(ItemID.AdamantiteBreastplate)
                .AddIngredient(ItemID.AdamantiteLeggings)
                .AddIngredient(ItemID.AdamantiteHeadgear)
                .AddIngredient(ItemID.AdamantiteMask)
                .AddIngredient(ItemID.AdamantiteDrill)
                .AddIngredient(ItemID.AdamantitePickaxe)
                .AddIngredient(ItemID.AdamantiteGlaive)
                .AddIngredient(ItemID.AdamantiteForge)
                .AddIngredient(ItemID.AdamantiteSword)
                .AddIngredient(ItemID.AdamantiteWaraxe)
                .AddIngredient(ItemID.AdamantiteRepeater)
                .AddIngredient(ItemID.AdamantiteChainsaw)
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
                .AddIngredient(ItemID.Frostbrand)
                .AddIngredient(ItemID.IceBow)
                .AddIngredient(ItemID.FlowerofFrost)
                .AddIngredient(ItemID.ToySled)
                .AddIngredient(ItemID.IceSickle)
                .AddIngredient(ItemID.FrostStaff)
                .AddIngredient(ItemID.FrozenTurtleShell)
                .AddTile(TileID.MythrilAnvil)
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
}