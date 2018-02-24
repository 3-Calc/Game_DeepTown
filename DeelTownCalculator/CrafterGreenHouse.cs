using System.Collections.Generic;

namespace DeelTownCalculator
{
    public class CrafterGreenHouse
    {
        public static List<Material> Tree(int amount = 1)
        {
            return CrafterRaw.Resource(ItemType.Tree, 30 * 60, amount, CrafterRaw.CreateRawResource(ItemType.TreeSeed),
                CrafterRaw.CreateRawResource(ItemType.Water, 10));


            
        }

        public static List<Material> Liana(int amount = 1)
        {
            return CrafterRaw.Resource(ItemType.Liana, 30 * 60, amount,
                CrafterRaw.CreateRawResource(ItemType.LianaSeed),
                CrafterRaw.CreateRawResource(ItemType.Water, 20));
        }

        public static List<Material> Grape(int amount = 1)
        {
            return CrafterRaw.Resource(ItemType.Grape, 30 * 60, amount,
                CrafterRaw.CreateRawResource(ItemType.GrapeSeed),
                CrafterRaw.CreateRawResource(ItemType.Water, 15));
        }
    }
}