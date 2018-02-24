using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeelTownCalculator
{
    public class CraftingWatcher
    {
        public static readonly Dictionary<ItemType, int> TreeHouseWatcher = new Dictionary<ItemType, int>()
        {
            {ItemType.GrapeSeed,0},
            {ItemType.LianaSeed,0},
            {ItemType.TreeSeed,0},

            {ItemType.Tree,30 * 60},
            {ItemType.Liana,30 * 60},
            {ItemType.Grape,30 * 60},
        };


    }
}
