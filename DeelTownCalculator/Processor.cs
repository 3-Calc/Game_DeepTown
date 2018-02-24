using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace DeelTownCalculator
{
    public class Processor
    {
        public static readonly Dictionary<MaterialType, int> MultiOutputList = new Dictionary<MaterialType, int>
        {
            {MaterialType.Coal, 50},
            {MaterialType.Titanium, 50},
            {MaterialType.GunPowder, 20},
            {MaterialType.OpticFiber, 10},
            {MaterialType.CopperNail, 10},
            {MaterialType.Tree, 10},
            {MaterialType.TonixBomb, 10},
            {MaterialType.GreenLaser, 5},
            {MaterialType.Wire, 5},
            {MaterialType.LiquidNitrogen, 4},
            {MaterialType.Grape, 2},
            {MaterialType.Oxygen, 2},
            {MaterialType.Hydrogen, 2},
            {MaterialType.Rubber, 2}
        };

        public static readonly Dictionary<MaterialType, int> SeedMarket = new Dictionary<MaterialType, int>
        {
            {MaterialType.GrapeSeed, 0},
            {MaterialType.LianaSeed, 0},
            {MaterialType.TreeSeed, 0}
        };

        public static readonly Dictionary<MaterialType, int> WaterCollector = new Dictionary<MaterialType, int>
        {
            {MaterialType.Water, 0}
        };

        public static readonly Dictionary<MaterialType, int> OilPipe = new Dictionary<MaterialType, int>
        {
            {MaterialType.Oil, 0}
        };

        public static readonly Dictionary<MaterialType, int> TreeHouse = new Dictionary<MaterialType, int>
        {
            {MaterialType.Tree, 30 * 60},
            {MaterialType.Liana, 30 * 60},
            {MaterialType.Grape, 30 * 60}
        };

        public static readonly Dictionary<MaterialType, int> JewelCrafter = new Dictionary<MaterialType, int>
        {
            {MaterialType.PolishedAmber, 1 * 60},
            {MaterialType.EmeraldRing, 5 * 60},
            {MaterialType.AmberBracelet, 2 * 60},
            {MaterialType.MayaCalendar, 2 * 60},
            {MaterialType.Haircomb, 2 * 60},
            {MaterialType.ObsidianKnife, 2 * 60},
            {MaterialType.PolishedEmerald, 30},
            {MaterialType.PolishedTopaz, 60},
            {MaterialType.PolishedSappire, 60},
            {MaterialType.PolishedAmethyst, 60},
            {MaterialType.PolishedAlexandrite, 60},
            {MaterialType.PolishedObsidian, 60}
        };

        public static readonly Dictionary<MaterialType, int> ChemistryCrafter = new Dictionary<MaterialType, int>
        {
            {MaterialType.CleanWater, 10 * 60},
            {MaterialType.Hydrogen, 15 * 60},
            {MaterialType.Oxygen, 15 * 60},
            {MaterialType.Rubber, 30 * 60},
            {MaterialType.SulfuricAcid, 30 * 60},
            {MaterialType.Ethanol, 30 * 60},
            {MaterialType.RefinedOil, 30 * 60},
            {MaterialType.PlasicPlate, 10 * 60},
            {MaterialType.Titanium, 20},
            {MaterialType.DiethylEther, 60},
            {MaterialType.GunPowder, 2 * 60},
            {MaterialType.LiquidNitrogen, 2 * 60},
            {MaterialType.MagnetiteOre, 6 * 60},
            {MaterialType.EnhancedHelium3, 30 * 60},
            {MaterialType.TonixBomb, 2 * 60}
        };

        public static readonly Dictionary<MaterialType, int> SmeltingCrafter = new Dictionary<MaterialType, int>
        {
            {MaterialType.CopperBar, 10},
            {MaterialType.IronBar, 15},
            {MaterialType.Glass, 60},
            {MaterialType.AluminiumBar, 15},
            {MaterialType.SteelBar, 45},
            {MaterialType.SilverBar, 1 * 60},
            {MaterialType.GoldBar, 60},
            {MaterialType.SteelPlate, 2 * 60},
            {MaterialType.TitaniumBar, 60},
            {MaterialType.MagnetBar, 60}
        };

        public static readonly Dictionary<MaterialType, int> Crafting = new Dictionary<MaterialType, int>
        {
            {MaterialType.Graphite, 5},
            {MaterialType.CopperNail, 20},
            {MaterialType.Wire, 30},
            {MaterialType.Battery, 2 * 60},
            {MaterialType.Circuits, 3 * 60},
            {MaterialType.Lamp, 1 * 60},
            {MaterialType.LabFlask, 1 * 60},
            {MaterialType.AmberCharger, 5},
            {MaterialType.AluminumBottle, 30},
            {MaterialType.AmberInsulation, 20},
            {MaterialType.InsulatedWire, 3 * 60},
            {MaterialType.GreenLaser, 20},
            {MaterialType.DiamondCutter, 30},
            {MaterialType.Motherboard, 30 * 60},
            {MaterialType.SolidPropellant, 20 * 60},
            {MaterialType.Accumulator, 3 * 60},
            {MaterialType.SolarPanel, 60},
            {MaterialType.Gear, 60},
            {MaterialType.Bomb, 3 * 60},
            {MaterialType.Compressor, 3 * 60},
            {MaterialType.OpticFiber, 2 * 60},
            {MaterialType.DryIce, 2 * 60},
            {MaterialType.Magnet, 2 * 60},
            {MaterialType.ElecticalEngine, 5 * 60}
        };

        private static Dictionary<MaterialType, int> CrafterInstance;
        private static Dictionary<MaterialType, int> AllCrafter;

        public static void ImportData(Dictionary<MaterialType, int> target, Dictionary<MaterialType, int> importSource)
        {
            try
            {
                foreach (var i in importSource)
                {
                    target.Add(i.Key, i.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public static Dictionary<MaterialType, int> Crafter
        {
            get
            {
                if (CrafterInstance != null) return CrafterInstance;

                CrafterInstance = new Dictionary<MaterialType, int>();

                AllCrafter = new Dictionary<MaterialType, int>();

                ImportData(AllCrafter, WaterCollector);
                ImportData(AllCrafter, SeedMarket);
                ImportData(AllCrafter, OilPipe);
                ImportData(AllCrafter, JewelCrafter);
                ImportData(AllCrafter, ChemistryCrafter);
                ImportData(AllCrafter, SmeltingCrafter);
                ImportData(AllCrafter, Crafting);


                foreach (MaterialType type in Enum.GetValues(typeof(MaterialType)))
                {
                    if (!AllCrafter.ContainsKey(type))
                        CrafterInstance.Add(type, 0);
                }
                ImportData(AllCrafter, CrafterInstance);

                return CrafterInstance;
            }
        }

        public static int GetCraftingType(MaterialType type)
        {
            return AllCrafter[type];
        }

    }
}