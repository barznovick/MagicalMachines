using Terraria.ModLoader;

namespace TutorialMOD
{
	class TutorialMOD : Mod
	{
		public TutorialMOD()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
