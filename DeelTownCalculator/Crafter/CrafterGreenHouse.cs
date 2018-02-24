using System.Collections.Generic;

namespace DeelTownCalculator.Crafter
{
    public class CrafterGreenHouse
    {
        public static List<Material> Tree(int amount = 1)
        {
            return CrafterRaw.Resource(MaterialType.Tree, 30 * 60, amount, CrafterRaw.CreateRawResource(MaterialType.TreeSeed),
                CrafterRaw.CreateRawResource(MaterialType.Water, 10));
        }

        public static List<Material> Liana(int amount = 1)
        {
            return CrafterRaw.Resource(MaterialType.Liana, 30 * 60, amount,
                CrafterRaw.CreateRawResource(MaterialType.LianaSeed),
                CrafterRaw.CreateRawResource(MaterialType.Water, 20));
        }

        public static List<Material> Grape(int amount = 1)
        {
            return CrafterRaw.Resource(MaterialType.Grape, 30 * 60, amount,
                CrafterRaw.CreateRawResource(MaterialType.GrapeSeed),
                CrafterRaw.CreateRawResource(MaterialType.Water, 15));
        }
    }
}