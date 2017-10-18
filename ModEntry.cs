using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ImmersiveCrafting
{
    public class ModEntry : Mod
    {
        public bool CanEdit<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals(@"Data\Crops");
        }

        /// <summary>Edit a matched asset.</summary>
        /// <param name="asset">A helper which encapsulates metadata about an asset and enables changes to it.</param>
        public void Edit<T>(IAssetData asset)
        {
            // add crop data
            if (asset.AssetNameEquals(@"Data\ObjectInformation"));
            {
                asset
                    .AsDictionary<int, string>()
                    .Set(1000, "Weeds/0/-1/Basic/Weeds/A bunch of obnoxious weeds.");
            }
        }
    }
}