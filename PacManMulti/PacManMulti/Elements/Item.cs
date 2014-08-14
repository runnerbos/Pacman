using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.Elements
{
    /// <summary>
    /// Element ment to represent items that can be collected in the game 
    /// </summary>
    public abstract class Item : Element
    {
        public int PointValue;//points that can be gained from collecting the item 
        public List<EffectsEnum> Effects { get; set; } //the list of effects that can be gained from interacting with the item 
    }
}
