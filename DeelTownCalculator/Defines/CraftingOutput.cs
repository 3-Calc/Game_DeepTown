using System.Collections.Generic;

namespace DeelTownCalculator.Defines
{
    public class CraftingOutput
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
    }
}