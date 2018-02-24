using System;

namespace DeelTownCalculator
{

    public class CrafterIdentifier
    {
        public static CrafterType GetType(MaterialType type)
        {
            if (Processor.Crafter.ContainsKey(type))
                return CrafterType.OreMines;

            if (Processor.OilPipe.ContainsKey(type))
                return CrafterType.OilPipe;

            if (Processor.WaterCollector.ContainsKey(type))
                return CrafterType.WaterCollector;

            if (Processor.SeedMarket.ContainsKey(type))
                return CrafterType.SeedMarket;

            if (Processor.JewelCrafter.ContainsKey(type))
                return CrafterType.JewelCrafter;

            if (Processor.SmeltingCrafter.ContainsKey(type))
                return CrafterType.SmeltingCrafter;

            if (Processor.ChemistryCrafter.ContainsKey(type))
                return CrafterType.ChemistryCrafter;

            if (Processor.Crafter.ContainsKey(type))
                return CrafterType.Crafter;



            throw new NotImplementedException(); 

        }
    }
}