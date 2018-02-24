using System;
using System.Collections.Generic;
using DeelTownCalculator.Crafter;

namespace DeelTownCalculator
{
    internal class Program
    {
        private static void Main()
        {
            // Todo list of current state and this program show you, what you max effort could be

            Console.WriteLine("Running");
            var items = new List<Material>
            {
                CrafterGreenHouse.Tree()[0],
                CrafterGreenHouse.Grape()[0],
                CrafterGreenHouse.Liana()[0],
                CrafterJewel.PolishedAmber()[0],
                CrafterJewel.PolishedEmerald()[0],
                CrafterJewel.EmeraldRing()[0],
                CrafterJewel.AmberBracelet()[0],
                CrafterSmelting.CopperBar()[0],
                CrafterSmelting.IronBar()[0],
                CrafterSmelting.Glass()[0],
                CrafterSmelting.AluminiumBar()[0],
                CrafterSmelting.SilverBar()[0],
                CrafterSmelting.GoldBar()[0]
            };

            foreach (var material in items) Console.WriteLine(material.Print());
            Console.ReadKey();
        }
    }
}