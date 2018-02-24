using System.Collections.Generic;

namespace DeelTownCalculator
{
    public class CrafterSmelting
    {
        #region Simple Item Single Source

        public static List<Material> CopperBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Copper, 5, 10, ItemType.CopperBar, amount);
        }

        public static List<Material> IronBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Iron, 5, 15, ItemType.IronBar, amount);
        }

        public static List<Material> Glass(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Silicon, 2, 60, ItemType.Glass, amount);
        }


        public static List<Material> AluminiumBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Aluminium, 5, 15, ItemType.AluminiumBar, amount);
        }

        public static List<Material> SilverBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Silver, 5, 60, ItemType.SilverBar, amount);
        }


        public static List<Material> GoldBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Gold, 5, 60, ItemType.GoldBar, amount);
        }

        #endregion
    }
}