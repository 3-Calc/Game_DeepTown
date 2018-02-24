using System;
using System.Collections.Generic;

namespace DeelTownCalculator
{
    internal class Program
    {
        private static void Main()
        {
            // Todo list of current state and this program show you, what you max effort could be

            Console.WriteLine("Running");
            var items = new List<Material>();

            items.Add(CrafterGreenHouse.Tree()[0]);
            items.Add(CrafterGreenHouse.Grape()[0]);
            items.Add(CrafterGreenHouse.Liana()[0]);

            items.Add(CrafterJewel.PolishedAmber()[0]);
            items.Add(CrafterJewel.PolishedEmerald()[0]);

            items.Add(CrafterJewel.EmeraldRing()[0]);
            items.Add(CrafterJewel.AmberBracelet()[0]);


            items.Add(CrafterSmelting.CopperBar()[0]);
            items.Add(CrafterSmelting.IronBar()[0]);
            items.Add(CrafterSmelting.Glass()[0]);
            items.Add(CrafterSmelting.AluminiumBar()[0]);

            items.Add(CrafterSmelting.SilverBar()[0]);
            items.Add(CrafterSmelting.GoldBar()[0]);


            foreach (var material in items) Console.WriteLine(material.Print());
            Console.ReadKey();
        }
    }
}