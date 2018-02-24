using System.Collections.Generic;

namespace DeelTownCalculator.Crafter
{
    public class CrafterSmelting
    {
        #region Simple Item Single Source

        public static List<Material> CopperBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Copper, 5, 10, MaterialType.CopperBar, amount);
        }

        public static List<Material> IronBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Iron, 5, 15, MaterialType.IronBar, amount);
        }

        public static List<Material> Glass(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Silicon, 2, 60, MaterialType.Glass, amount);
        }


        public static List<Material> AluminiumBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Aluminium, 5, 15, MaterialType.AluminiumBar, amount);
        }

        public static List<Material> SilverBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Silver, 5, 60, MaterialType.SilverBar, amount);
        }


        public static List<Material> GoldBar(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Gold, 5, 60, MaterialType.GoldBar, amount);
        }

        #endregion
    }
}