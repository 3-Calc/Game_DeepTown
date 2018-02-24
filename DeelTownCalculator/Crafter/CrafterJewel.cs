using System.Collections.Generic;

namespace DeelTownCalculator.Crafter
{
    public class CrafterJewel
    {
        public static List<Material> EmeraldRing(int amount = 1)
        {
            return CrafterRaw.Resource(MaterialType.EmeraldRing, 5 * 60, amount, CrafterSmelting.GoldBar(),
                PolishedEmerald());
        }


        public static List<Material> AmberBracelet(int amount = 1)
        {
            return CrafterRaw.Resource(MaterialType.AmberBracelet, 2 * 60, amount, PolishedAmber(),
                CrafterSmelting.SilverBar());
        }

        #region Simple Item Single Source

        public static List<Material> PolishedAmber(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Amber, 5, 30, MaterialType.PolishedAmber, amount);
        }

        public static List<Material> PolishedEmerald(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Emerald, 5, 30, MaterialType.PolishedEmerald, amount);
        }

        public static List<Material> PolishedTopaz(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Topaz, 5, 60, MaterialType.PolishedTopaz, amount);
        }

        public static List<Material> PolishedRuby(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Ruby, 5, 60, MaterialType.PolishedRuby, amount);
        }

        public static List<Material> PolishedDiamond(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Diamond, 5, 60, MaterialType.PolishedDiamond, amount);
        }

        public static List<Material> PolishedSappire(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Sapphire, 5, 60, MaterialType.PolishedSappire, amount);
        }

        public static List<Material> PolishedAmethyst(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Amethyst, 5, 60, MaterialType.PolishedAmethyst, amount);
        }

        public static List<Material> PolishedAlexandrite(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Alexandrite, 5, 60, MaterialType.PolishedAlexandrite, amount);
        }

        public static List<Material> PolishedObsidian(int amount = 1)
        {
            return CrafterRaw.BaseResource(MaterialType.Obsidian, 5, 60, MaterialType.PolishedObsidian, amount);
        }

        #endregion
    }
}