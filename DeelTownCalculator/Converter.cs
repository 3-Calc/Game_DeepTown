using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using DeelTownCalculator.Defines;

namespace DeelTownCalculator
{
    public class Converter
    {
        public static CrafterType GetCrafterType(MaterialType type)
        {
            if (Progress.OreMines.ContainsKey(type))
                return CrafterType.OreMines;

            if (Progress.OilPipe.ContainsKey(type))
                return CrafterType.OilPipe;

            if (Progress.WaterCollector.ContainsKey(type))
                return CrafterType.WaterCollector;

            if (Progress.SeedMarket.ContainsKey(type))
                return CrafterType.SeedMarket;

            if (Progress.GreenHouseCrafter.ContainsKey(type))
                return CrafterType.GreenHouseCrafter;

            if (Progress.JewelCrafter.ContainsKey(type))
                return CrafterType.JewelCrafter;

            if (Progress.SmeltingCrafter.ContainsKey(type))
                return CrafterType.SmeltingCrafter;

            if (Progress.ChemistryCrafter.ContainsKey(type))
                return CrafterType.ChemistryCrafter;

            if (Progress.Crafting.ContainsKey(type))
                return CrafterType.CraftingCrafter;

            throw new NotImplementedException();
        }

        public static double GetCraftingTime(MaterialType type)
        {
            return Progress.AllCrafter[type];
        }

        /// <summary>
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Dictionary<MaterialType, int> GetRequiredItemPerCrafting(MaterialType type)
        {
            switch (type)
            {
                case MaterialType.Coal:
                    goto default;
                case MaterialType.Graphite:
                    return GetRequiredItemPerCrafting(5, MaterialType.Coal);
                case MaterialType.Copper:
                    goto default;
                case MaterialType.CopperBar:
                    return GetRequiredItemPerCrafting(5, MaterialType.Copper);
                case MaterialType.Iron:
                    goto default;
                case MaterialType.IronBar:
                    return GetRequiredItemPerCrafting(5, MaterialType.Iron);
                case MaterialType.SteelBar:
                    return GetRequiredItemPerCrafting(1, MaterialType.Graphite, 1, MaterialType.IronBar);
                case MaterialType.Aluminium:
                    goto default;
                case MaterialType.AluminiumBar:
                    return GetRequiredItemPerCrafting(5, MaterialType.Aluminium);
                case MaterialType.Silver:
                    goto default;
                case MaterialType.SilverBar:
                    return GetRequiredItemPerCrafting(5, MaterialType.Silver);
                case MaterialType.Gold:
                    goto default;
                case MaterialType.GoldBar:
                    return GetRequiredItemPerCrafting(5, MaterialType.Gold);
                case MaterialType.Titanium:
                    return GetRequiredItemPerCrafting(1, MaterialType.SulfuricAcid, 100, MaterialType.TitaniumOre);
                case MaterialType.TitaniumBar:
                    return GetRequiredItemPerCrafting(5, MaterialType.Titanium);
                case MaterialType.Platinum:
                    goto default;
                case MaterialType.SteelPlate:
                    return GetRequiredItemPerCrafting(5, MaterialType.SteelBar);
                case MaterialType.DiamondCutter:
                    return GetRequiredItemPerCrafting(1, MaterialType.SteelBar, 5, MaterialType.Diamond);
                case MaterialType.Motherboard:
                    return GetRequiredItemPerCrafting(1, MaterialType.GoldBar, 3, MaterialType.Circuits, 3, MaterialType.Silicon);
                case MaterialType.CopperNail:
                    return GetRequiredItemPerCrafting(1, MaterialType.CopperBar);
                case MaterialType.OpticFiber:
                    return GetRequiredItemPerCrafting(10, MaterialType.Silicon, 10, MaterialType.Oxygen, 1, MaterialType.PlasticPlate);
                case MaterialType.AmberInsulation:
                    return GetRequiredItemPerCrafting(10, MaterialType.Amber, 1, MaterialType.AluminumBottle);
                case MaterialType.DryIce:
                    return GetRequiredItemPerCrafting(1, MaterialType.Compressor, 10, MaterialType.GreenLaser, 1000, MaterialType.Graphite);
                case MaterialType.SolarPanel:
                    return GetRequiredItemPerCrafting(1, MaterialType.Rubber, 10, MaterialType.Silicon, 50, MaterialType.Glass);
                case MaterialType.GreenLaser:
                    return GetRequiredItemPerCrafting(1, MaterialType.PolishedEmerald, 1, MaterialType.InsulatedWire, 1, MaterialType.Lamp);
                case MaterialType.Wire:
                    return GetRequiredItemPerCrafting(1, MaterialType.CopperBar);
                case MaterialType.InsulatedWire:
                    return GetRequiredItemPerCrafting(1, MaterialType.Wire, 1, MaterialType.AmberInsulation);
                case MaterialType.ElecticalEngine:
                    return GetRequiredItemPerCrafting(50, MaterialType.InsulatedWire, 1, MaterialType.Magnet, 20, MaterialType.AluminiumBar);
                case MaterialType.AluminumBottle:
                    return GetRequiredItemPerCrafting(1, MaterialType.AluminiumBar);
                case MaterialType.Bomb:
                    return GetRequiredItemPerCrafting(5, MaterialType.SteelBar, 10, MaterialType.GunPowder);
                case MaterialType.Gear:
                    return GetRequiredItemPerCrafting(1, MaterialType.DiamondCutter, 1, MaterialType.TitaniumBar);
                case MaterialType.Battery:
                    return GetRequiredItemPerCrafting(1, MaterialType.Amber, 1, MaterialType.IronBar, 5, MaterialType.CopperBar);
                case MaterialType.Lamp:
                    return GetRequiredItemPerCrafting(5, MaterialType.CopperBar, 10, MaterialType.Wire, 20, MaterialType.Graphite);
                case MaterialType.Magnet:
                    return GetRequiredItemPerCrafting(1, MaterialType.MagnetBar);
                case MaterialType.MagnetBar:
                    return GetRequiredItemPerCrafting(5, MaterialType.MagnetiteOre);
                case MaterialType.Compressor:
                    return GetRequiredItemPerCrafting(2, MaterialType.RefinedOil, 1, MaterialType.Rubber, 5, MaterialType.IronBar);
                case MaterialType.Accumulator:
                    return GetRequiredItemPerCrafting(20, MaterialType.Sulfur, 20, MaterialType.Sodium);
                case MaterialType.SolidPropellant:
                    return GetRequiredItemPerCrafting(10, MaterialType.AluminiumBar, 3, MaterialType.Rubber);
                case MaterialType.Circuits:
                    return GetRequiredItemPerCrafting(10, MaterialType.IronBar, 50, MaterialType.Graphite, 20, MaterialType.CopperBar);
                case MaterialType.Uranium:
                    goto default;
                case MaterialType.TitaniumOre:
                    goto default;
                case MaterialType.Amber:
                    goto default;
                case MaterialType.AmberCharger:
                    return GetRequiredItemPerCrafting(1, MaterialType.Amber);
                case MaterialType.PolishedAmber:
                    return GetRequiredItemPerCrafting(5, MaterialType.Amber);
                case MaterialType.Emerald:
                    goto default;
                case MaterialType.PolishedEmerald:
                    return GetRequiredItemPerCrafting(5, MaterialType.Emerald);
                case MaterialType.Topaz:
                    goto default;
                case MaterialType.PolishedTopaz:
                    return GetRequiredItemPerCrafting(5, MaterialType.Topaz);
                case MaterialType.Ruby:
                    goto default;
                case MaterialType.PolishedRuby:
                    return GetRequiredItemPerCrafting(5, MaterialType.Ruby);
                case MaterialType.Sapphire:
                    goto default;
                case MaterialType.PolishedSapphire:
                    return GetRequiredItemPerCrafting(5, MaterialType.Sapphire);
                case MaterialType.Amethyst:
                    goto default;
                case MaterialType.PolishedAmethyst:
                    return GetRequiredItemPerCrafting(5, MaterialType.Amethyst);
                case MaterialType.Diamond:
                    goto default;
                case MaterialType.PolishedDiamond:
                    return GetRequiredItemPerCrafting(5, MaterialType.Diamond);
                case MaterialType.Alexandrite:
                    goto default;
                case MaterialType.PolishedAlexandrite:
                    return GetRequiredItemPerCrafting(5, MaterialType.Alexandrite);
                case MaterialType.Obsidian:
                    goto default;
                case MaterialType.PolishedObsidian:
                    return GetRequiredItemPerCrafting(5, MaterialType.Obsidian);
                case MaterialType.EmeraldRing:
                    return GetRequiredItemPerCrafting(1, MaterialType.GoldBar, 1, MaterialType.PolishedEmerald);
                case MaterialType.AmberBracelet:
                    return GetRequiredItemPerCrafting(1, MaterialType.SilverBar, 1, MaterialType.PolishedAmber);
                case MaterialType.MayaCalendar:
                    return GetRequiredItemPerCrafting(2, MaterialType.SilverBar, 10, MaterialType.GoldBar);
                case MaterialType.Haircomb:
                    return GetRequiredItemPerCrafting(1, MaterialType.Silver, 15, MaterialType.PolishedAmethyst, 10, MaterialType.PolishedAlexandrite);
                case MaterialType.ObsidianKnife:
                    return GetRequiredItemPerCrafting(1, MaterialType.SilverBar, 2, MaterialType.Tree, 50, MaterialType.PolishedObsidian);
                case MaterialType.TreeSeed:
                    goto default;
                case MaterialType.Tree:
                    return GetRequiredItemPerCrafting(1, MaterialType.TreeSeed, 10, MaterialType.Water);
                case MaterialType.LianaSeed:
                    goto default;
                case MaterialType.Liana:
                    return GetRequiredItemPerCrafting(1, MaterialType.LianaSeed, 20, MaterialType.Water);
                case MaterialType.Rubber:
                    return GetRequiredItemPerCrafting(1, MaterialType.Liana);
                case MaterialType.GrapeSeed:
                    goto default;
                case MaterialType.Grape:
                    return GetRequiredItemPerCrafting(1, MaterialType.GrapeSeed, 15, MaterialType.Water);
                case MaterialType.Ethanol:
                    return GetRequiredItemPerCrafting(1, MaterialType.AluminumBottle, 2, MaterialType.Grape);
                case MaterialType.Water:
                    goto default;
                case MaterialType.Oil:
                    goto default;
                case MaterialType.RefinedOil:
                    return GetRequiredItemPerCrafting(10, MaterialType.Oil, 10, MaterialType.Hydrogen, 1, MaterialType.LabFlask);
                case MaterialType.Sulfur:
                    goto default;
                case MaterialType.Sodium:
                    goto default;
                case MaterialType.Nitrogen:
                    goto default;
                case MaterialType.Helium3:
                    goto default;
                case MaterialType.Silicon:
                    goto default;
                case MaterialType.Glass:
                    return GetRequiredItemPerCrafting(2, MaterialType.Silicon);
                case MaterialType.LabFlask:
                    return GetRequiredItemPerCrafting(1, MaterialType.Glass);
                case MaterialType.CleanWater:
                    return GetRequiredItemPerCrafting(1, MaterialType.LabFlask, 1, MaterialType.Water);
                case MaterialType.Hydrogen:
                    return GetRequiredItemPerCrafting(1, MaterialType.CleanWater);
                case MaterialType.Oxygen:
                    return GetRequiredItemPerCrafting(1, MaterialType.CleanWater);
                case MaterialType.GunPowder:
                    return GetRequiredItemPerCrafting(1, MaterialType.DiethylEther, 2, MaterialType.SulfuricAcid, 2, MaterialType.Tree);
                case MaterialType.SulfuricAcid:
                    return GetRequiredItemPerCrafting(2, MaterialType.Sulfur, 1, MaterialType.CleanWater);
                case MaterialType.PlasticPlate:
                    return GetRequiredItemPerCrafting(1, MaterialType.SulfuricAcid, 50, MaterialType.Coal, 1, MaterialType.RefinedOil);
                case MaterialType.MagnetiteOre:
                    return GetRequiredItemPerCrafting(5, MaterialType.GreenLaser, 5, MaterialType.Oxygen, 10, MaterialType.IronBar);
                case MaterialType.DiethylEther:
                    return GetRequiredItemPerCrafting(1, MaterialType.SulfuricAcid, 1, MaterialType.Ethanol);
                case MaterialType.UraniumRod:
                    return GetRequiredItemPerCrafting(100, MaterialType.Uranium, 50, MaterialType.Sodium);
                case MaterialType.TonixBomb:
                    return GetRequiredItemPerCrafting(10, MaterialType.SulfuricAcid);
                case MaterialType.EnhancedHelium3:
                    return GetRequiredItemPerCrafting(1, MaterialType.AluminumBottle, 100, MaterialType.Helium3, 1, MaterialType.Compressor);
                case MaterialType.LiquidNitrogen:
                    return GetRequiredItemPerCrafting(1, MaterialType.AluminumBottle, 10, MaterialType.Nitrogen, 1, MaterialType.Compressor);
                default:
                    return new Dictionary<MaterialType, int>();

            }
        }

        private static Dictionary<MaterialType, int> GetRequiredItemPerCrafting(int amountItem1, MaterialType item1,
            int amountItem2 = 0, MaterialType item2 = MaterialType.TreeSeed,
            int amountItem3 = 0, MaterialType item3 = MaterialType.TreeSeed)
        {
            var result = new Dictionary<MaterialType, int>() { { item1, amountItem1 } };
            if (amountItem2 != 0)
                result.Add(item2, amountItem2);
            if (amountItem3 != 0)
                result.Add(item3, amountItem3);

            return result;
        }

        public static int GetOutputAmount(MaterialType type)
        {
            return !CraftingOutput.MultiOutputList.ContainsKey(type) ? 1 : CraftingOutput.MultiOutputList[type];

        }
    }
}