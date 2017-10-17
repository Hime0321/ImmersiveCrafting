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
        public override void Entry(IModHelper helper)
        {
            ControlEvents.KeyPressed += this.ControlEvents_KeyPress;
            ///Tyler look here:  8=====D
        }
    }
}
