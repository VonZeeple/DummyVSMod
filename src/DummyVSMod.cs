
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo("dummyvsmod",
    "dummyvsmod",
    Description = "A simple VS mod for demonstration purposes.",
    Website = "",
    Version = ModVersion.Value,
    Authors = new[] { "PFev" })]

namespace dummyvsmod.src
{
    public class DummyVSMod : ModSystem
    {
        static string MODID = "dummyvsmod";
        public override void Start(ICoreAPI api)
        {
        }

    }
}
