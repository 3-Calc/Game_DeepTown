using System.Collections.Generic;
using DeelTownCalculator;

namespace DeelTownCalculator
{

    public class Market
    {
        public static readonly Dictionary<MaterialType, int> SellingPrices = new Dictionary<MaterialType, int>
        {
            {MaterialType.Coal, 1},
            {MaterialType.Copper, 2},
            {MaterialType.Iron, 3},
            {MaterialType.Amber, 4},
            {MaterialType.Aluminium, 5},
            {MaterialType.Silver, 7},
            {MaterialType.Gold, 10},
            {MaterialType.Emerald, 12},
            {MaterialType.Platinum, 13},
            {MaterialType.Topaz, 14},
            {MaterialType.Ruby, 15},
            {MaterialType.Sapphire, 16},
            {MaterialType.Amethyst, 18},
            {MaterialType.Diamond, 18},
            {MaterialType.TitaniumOre, 19},
            {MaterialType.Alexandrite, 19},
            {MaterialType.Obsidian, 20},
            {MaterialType.Uranium, 22},
            {MaterialType.Helium3, 400},

            {MaterialType.CopperBar, 25},
            {MaterialType.IronBar, 40},
            {MaterialType.AluminiumBar, 50},
            {MaterialType.SteelBar, 180},
            {MaterialType.SilverBar, 200},
            {MaterialType.GoldBar, 250},
            {MaterialType.LabFlask, 800},
            {MaterialType.TitaniumBar, 3000},
            {MaterialType.DiamondCutter, 5000},
            {MaterialType.Motherboard, 17000},
            {MaterialType.CopperNail, 7},
            {MaterialType.OpticFiber, 10500},
            {MaterialType.AmberInsulation, 125},
            {MaterialType.DryIce, 140000},
            {MaterialType.SolarPanel, 69000},
            {MaterialType.Graphite, 15},
            {MaterialType.GreenLaser, 400},
            {MaterialType.Wire, 15},

            {MaterialType.InsulatedWire, 750},
            {MaterialType.AmaberCharger, 4},
            {MaterialType.ElecticalEngine, 74500},
            {MaterialType.AluminumBottle, 55},
            {MaterialType.Bomb, 55500},
            {MaterialType.Gear, 18500},
            {MaterialType.Battery, 200},
            {MaterialType.Lamp, 760},
            {MaterialType.Compressor, 44000},
            {MaterialType.Accumulator, 9000},
            {MaterialType.SolidPropellant, 27000},
            {MaterialType.Circuits, 2070},

            {MaterialType.PolishedAmber, 70},
            {MaterialType.PolishedEmerald, 160},
            {MaterialType.PolishedTopaz, 200},
            {MaterialType.PolishedSappire, 230},
            {MaterialType.PolishedRuby, 250},
            {MaterialType.PolishedAmethyst, 250},
            {MaterialType.PolishedAlexandrite, 270},
            {MaterialType.PolishedObsidian, 280},
            {MaterialType.AmberBracelet, 280},

            {MaterialType.PolishedDiamond, 300},
            {MaterialType.EmeraldRing, 450}, // update price
            {MaterialType.MayaCalendar, 6000}, // update price
            {MaterialType.Haircomb, 14000}, // update price
            {MaterialType.ObsidianKnife, 32000}, // update price

            {MaterialType.Water, 5},
            {MaterialType.Oil, 21},
            {MaterialType.Sulfur, 100},
            {MaterialType.Silicon, 100},
            {MaterialType.Sodium, 100},
            {MaterialType.Titanium, 260},
            {MaterialType.Nitrogen, 300},
            {MaterialType.Hydrogen, 400},
            {MaterialType.Glass, 450},

            {MaterialType.Oxygen, 900},
            {MaterialType.CleanWater, 1200},
            {MaterialType.GunPowder, 2500},
            {MaterialType.SulfuricAcid, 3500},
            {MaterialType.Rubber, 4000},
            {MaterialType.Ethanol, 4200},
            {MaterialType.LiquidNitrogen, 12500},
            {MaterialType.MagnetiteOre, 12500},
            {MaterialType.DiethylEther, 17000},

            {MaterialType.UraniumRod, 17000},
            {MaterialType.PlasticPlate, 40000},
            {MaterialType.TonixBomb, 77500},
            {MaterialType.EnhancedHelium3, 19000},

            {MaterialType.TreeSeed, 10},
            {MaterialType.Tree, 193},
            {MaterialType.LianaSeed, 1000},
            {MaterialType.GrapeSeed, 1200},
            {MaterialType.Grape, 1500},
            {MaterialType.Liana, 1700}
        };
    }
}