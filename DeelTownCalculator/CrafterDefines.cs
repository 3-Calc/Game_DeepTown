using System;
using System.Collections.Generic;

namespace DeelTownCalculator
{
    public enum CrafterType
    {
        Ore,
        Jewel
    }

    public class CrafterDefines
    {
        public static readonly Dictionary<ItemType, int> CraftingOutputCounter = new Dictionary<ItemType, int>
        {
            {ItemType.Coal, 50},
            {ItemType.Titanium, 50},
            {ItemType.GunPowder, 20},
            {ItemType.OpticFiber, 10},
            {ItemType.CopperNail, 10},
            {ItemType.Tree, 10},
            {ItemType.TonixBomb, 10},
            {ItemType.GreenLaser, 5},
            {ItemType.Wire, 5},
            {ItemType.LiquidNitrogen, 4},
            {ItemType.Grape, 2},
            {ItemType.Oxygen, 2},
            {ItemType.Hydrogen, 2},
            {ItemType.Rubber, 2}
        };


        public static CrafterType GetItemType(ItemType type)
        {
            switch (type)
            {
                case ItemType.Coal:
                    return CrafterType.Ore;
                case ItemType.Graphite:
                    throw new NotImplementedException();
                case ItemType.Copper:
                    throw new NotImplementedException();
                case ItemType.CopperBar:
                    throw new NotImplementedException();
                case ItemType.Iron:
                    throw new NotImplementedException();
                case ItemType.IronBar:
                    throw new NotImplementedException();
                case ItemType.SteelBar:
                    throw new NotImplementedException();
                case ItemType.Aluminium:
                    throw new NotImplementedException();
                case ItemType.AluminiumBar:
                    throw new NotImplementedException();
                case ItemType.Silver:
                    throw new NotImplementedException();
                case ItemType.SilverBar:
                    throw new NotImplementedException();
                case ItemType.Gold:
                    throw new NotImplementedException();
                case ItemType.GoldBar:
                    throw new NotImplementedException();
                case ItemType.Titanium:
                    throw new NotImplementedException();
                case ItemType.TitaniumBar:
                    throw new NotImplementedException();
                case ItemType.Platinum:
                    throw new NotImplementedException();
                case ItemType.SteelPlate:
                    throw new NotImplementedException();
                case ItemType.DiamondCutter:
                    throw new NotImplementedException();
                case ItemType.Motherboard:
                    throw new NotImplementedException();
                case ItemType.CopperNail:
                    throw new NotImplementedException();
                case ItemType.OpticFiber:
                    throw new NotImplementedException();
                case ItemType.AmberInsulation:
                    throw new NotImplementedException();
                case ItemType.DryIce:
                    throw new NotImplementedException();
                case ItemType.SolarPanel:
                    throw new NotImplementedException();
                case ItemType.GreenLaser:
                    throw new NotImplementedException();
                case ItemType.Wire:
                    throw new NotImplementedException();
                case ItemType.InsulatedWire:
                    throw new NotImplementedException();
                case ItemType.AmaberCharger:
                    throw new NotImplementedException();
                case ItemType.ElecticalEngine:
                    throw new NotImplementedException();
                case ItemType.AluminumBottle:
                    throw new NotImplementedException();
                case ItemType.Bomb:
                    throw new NotImplementedException();
                case ItemType.Gear:
                    throw new NotImplementedException();
                case ItemType.Battery:
                    throw new NotImplementedException();
                case ItemType.Lamp:
                    throw new NotImplementedException();
                case ItemType.Magnet:
                    throw new NotImplementedException();
                case ItemType.Compressor:
                    throw new NotImplementedException();
                case ItemType.Accumulator:
                    throw new NotImplementedException();
                case ItemType.SolidPropellant:
                    throw new NotImplementedException();
                case ItemType.Circuits:
                    throw new NotImplementedException();
                case ItemType.Uranium:
                    throw new NotImplementedException();
                case ItemType.TitaniumOre:
                    throw new NotImplementedException();
                case ItemType.Amber:
                    throw new NotImplementedException();
                case ItemType.PolishedAmber:
                    throw new NotImplementedException();
                case ItemType.Emerald:
                    throw new NotImplementedException();
                case ItemType.PolishedEmerald:
                    throw new NotImplementedException();
                case ItemType.Topaz:
                    throw new NotImplementedException();
                case ItemType.PolishedTopaz:
                    throw new NotImplementedException();
                case ItemType.Ruby:
                    throw new NotImplementedException();
                case ItemType.PolishedRuby:
                    throw new NotImplementedException();
                case ItemType.Sapphire:
                    throw new NotImplementedException();
                case ItemType.PolishedSappire:
                    throw new NotImplementedException();
                case ItemType.Amethyst:
                    throw new NotImplementedException();
                case ItemType.PolishedAmethyst:
                    throw new NotImplementedException();
                case ItemType.Diamond:
                    throw new NotImplementedException();
                case ItemType.PolishedDiamond:
                    throw new NotImplementedException();
                case ItemType.Alexandrite:
                    throw new NotImplementedException();
                case ItemType.PolishedAlexandrite:
                    throw new NotImplementedException();
                case ItemType.Obsidian:
                    throw new NotImplementedException();
                case ItemType.PolishedObsidian:
                    throw new NotImplementedException();
                case ItemType.EmeraldRing:
                    throw new NotImplementedException();
                case ItemType.AmberBracelet:
                    throw new NotImplementedException();
                case ItemType.MayaCalendar:
                    throw new NotImplementedException();
                case ItemType.Haircomb:
                    throw new NotImplementedException();
                case ItemType.ObsidianKnife:
                    throw new NotImplementedException();
                case ItemType.TreeSeed:
                    throw new NotImplementedException();
                case ItemType.Tree:
                    throw new NotImplementedException();
                case ItemType.LianaSeed:
                    throw new NotImplementedException();
                case ItemType.Liana:
                    throw new NotImplementedException();
                case ItemType.Rubber:
                    throw new NotImplementedException();
                case ItemType.GrapeSeed:
                    throw new NotImplementedException();
                case ItemType.Grape:
                    throw new NotImplementedException();
                case ItemType.Ethanol:
                    throw new NotImplementedException();
                case ItemType.Water:
                    throw new NotImplementedException();
                case ItemType.Oil:
                    throw new NotImplementedException();
                case ItemType.Sulfur:
                    throw new NotImplementedException();
                case ItemType.Sodium:
                    throw new NotImplementedException();
                case ItemType.Nitrogen:
                    throw new NotImplementedException();
                case ItemType.Helium3:
                    throw new NotImplementedException();
                case ItemType.Silicon:
                    throw new NotImplementedException();
                case ItemType.Glass:
                    throw new NotImplementedException();
                case ItemType.LabFlask:
                    throw new NotImplementedException();
                case ItemType.CleanWater:
                    throw new NotImplementedException();
                case ItemType.Hydrogen:
                    throw new NotImplementedException();
                case ItemType.Oxygen:
                    throw new NotImplementedException();
                case ItemType.GunPowder:
                    throw new NotImplementedException();
                case ItemType.SulfuricAcid:
                    throw new NotImplementedException();
                case ItemType.PlasticPlate:
                    throw new NotImplementedException();
                case ItemType.MagnetiteOre:
                    throw new NotImplementedException();
                case ItemType.DiethylEther:
                    throw new NotImplementedException();
                case ItemType.UraniumRod:
                    throw new NotImplementedException();
                case ItemType.PlasicPlate:
                    throw new NotImplementedException();
                case ItemType.TonixBomb:
                    throw new NotImplementedException();
                case ItemType.EnhancedHelium3:
                    throw new NotImplementedException();
                case ItemType.LiquidNitrogen:
                    throw new NotImplementedException();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}