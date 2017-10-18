using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ImmersiveCrafting
{
    public class ModEntry : Mod, IAssetEditor
    {
        public bool CanEdit<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals(@"Data\Crops");
        }

        
        public void Edit<T>(IAssetData asset)
        {
            asset
                .AsDictionary<int, string>()
                .Set((id, data) =>
                {
                    string[] fields = data.Split('/');
                    fields[1] = "spring summer fall winter";
                    return string.Join("/", fields);
                });
        }
    
    public override void Entry(IModHelper helper)
        {
            ControlEvents.KeyPressed += this.ControlEvents_KeyPress;
        }

        private void ControlEvents_KeyPress(object sender, EventArgsKeyPressed e)
        {
            if (Context.IsWorldReady)
            {
                this.Monitor.Log($"{Game1.player.name} pressed {e.KeyPressed}.");
            }
        }
    }
}