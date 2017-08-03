using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMOD.Items
{
	public class CustomSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Admin Swsord");
			Tooltip.SetDefault("Cheat Weapon Only.");
		}
		public override void SetDefaults()
		{
			item.damage = 10000000;
			item.melee = true;
			item.width = 500;
			item.height = 1000;
			item.useTime = 3;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("YourProjectileName");
            item.shootSpeed = 100f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoonLordBossBag ,10000000 );
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
