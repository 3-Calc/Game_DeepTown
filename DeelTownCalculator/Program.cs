using System;
using System.Collections.Generic;
using DeelTownCalculator.Defines;

namespace DeelTownCalculator
{
    internal class Program
    {
        private static void Main()
        {
            // Todo list of current state and this program show you, what you max effort could be
            // todo special handling for oxygen and hydrogen // check helium 3 material
            Console.WriteLine("Running");
            var items = new List<Material>
            {
                //new Material(MaterialType.Tree),
                // new Material(MaterialType.ElecticalEngine),
                //new Material(MaterialType.Grape),
                //new Material(MaterialType.Liana),
                //new Material(MaterialType.PolishedAmber),
                //new Material(MaterialType.PolishedEmerald),
                //new Material(MaterialType.EmeraldRing),
                //new Material(MaterialType.AmberBracelet),
                //new Material(MaterialType.CopperBar),
                //new Material(MaterialType.IronBar),
                //new Material(MaterialType.Glass),
                //new Material(MaterialType.Aluminium),
                //new Material(MaterialType.SilverBar),
                //new Material(MaterialType.GoldBar)
            };
            foreach (var material in items) Console.WriteLine(material.Print());

            items.Clear();
            foreach (MaterialType type in Enum.GetValues(typeof(MaterialType)))
                items.Add(new Material(type));


            foreach (var material in items) Console.WriteLine(material.Print());
            Console.ReadKey();
        }
    }
}