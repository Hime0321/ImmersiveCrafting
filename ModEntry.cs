using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ImmersiveCrafting
{
    public class ModEntry : Mod, IAssetLoader
    {
        public override void Entry(IModHelper helper)
        {
        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals(@"Data\ObjectInformation");
        }
        
        public void Load<T>(IAssetInfo asset)
        {
            return (T)(object)new Dictionary<Int32, string> // (T)(object) is a trick to cast anything to T if we know it's compatible
            {
                ["800"] = "Wooden Plankes/2/69/Basic/Wooden Plankes/Used to build stuff."
            };
        }
    }
}