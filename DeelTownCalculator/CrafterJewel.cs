using System.Collections.Generic;

namespace DeelTownCalculator
{
    public class CrafterJewel
    {

        #region Simple Item Single Source
        public static List<Material> PolishedAmber(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Amber, 5, 30, ItemType.PolishedAmber, amount);

        }

        public static List<Material> PolishedEmerald(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Emerald, 5, 30, ItemType.PolishedEmerald, amount);


        }

        public static List<Material> PolishedTopaz(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Topaz, 5, 60, ItemType.PolishedTopaz, amount);
        }

        public static List<Material> PolishedRuby(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Ruby, 5, 60, ItemType.PolishedRuby, amount);
        }

        public static List<Material> PolishedDiamond(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Diamond, 5, 60, ItemType.PolishedDiamond, amount);
        }

        public static List<Material> PolishedSappire(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Sapphire, 5, 60, ItemType.PolishedSappire, amount);
        }

        public static List<Material> PolishedAmethyst(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Amethyst, 5, 60, ItemType.PolishedAmethyst, amount);
        }

        public static List<Material> PolishedAlexandrite(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Alexandrite, 5, 60, ItemType.PolishedAlexandrite, amount);
        }

        public static List<Material> PolishedObsidian(int amount = 1)
        {
            return CrafterRaw.BaseResource(ItemType.Obsidian, 5, 60, ItemType.PolishedObsidian, amount);
        }


        #endregion
        public static List<Material> EmeraldRing(int amount = 1)
        {

            return CrafterRaw.Resource(ItemType.EmeraldRing, 5 * 60, amount, CrafterSmelting.GoldBar(), PolishedEmerald());

        }



        public static List<Material> AmberBracelet(int amount = 1)
        {
            return CrafterRaw.Resource(ItemType.AmberBracelet, 2 * 60, amount, PolishedAmber(), CrafterSmelting.SilverBar());
        }


    }
}