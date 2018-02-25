using System;
using System.ComponentModel;
using System.Text;
using DeelTownCalculator.Defines;
using DeelTownCalculator.Model;

namespace DeelTownCalculator
{
    /// <inheritdoc />
    /// <summary>
    ///    Material object for exact 1 Item
    /// </summary>
    public class Material : IComparable
    {
        //public int CurrentItemCapacity = 1;
        public double OneUnitFactor = 1;
        private static string Tabs = "";

        public Material(MaterialType type)
        {
            MaterialType = type;
            DecreaseCapacityToSingleItem(Converter.GetOutputAmount(type));
        }


        private MaterialType MaterialType { get; }

        public int CompareTo(object obj)
        {
            return obj == null ? MaterialType.CompareTo(null) : MaterialType.CompareTo(((Material)obj).MaterialType);
        }

        private double GetSellingPrice()
        {
            return SellingPrice.From[MaterialType] / OneUnitFactor;
        }

        public double GetSellingPricePerUnit()
        {
            return GetSellingPrice() / Converter.GetOutputAmount(MaterialType);
        }

        public CraftingTime GetRawCraftingTimePerUnit(double amount = 1)
        {
            var result = new CraftingTime();
            result.AddTime(MaterialType, Converter.GetCraftingTime(MaterialType) * OneUnitFactor * amount);
            return result;
        }

        /// <summary>
        ///     TODO to define different timer
        /// </summary>
        /// <returns></returns>
        public CraftingTime GetTotalCraftingTime(double amount = 1)
        {
            Tabs += "   ";
            var time = new CraftingTime();
            time.AddTime(GetRawCraftingTimePerUnit(amount));

            // total time for one output unit
            foreach (var item in Converter.GetRequiredItemPerCrafting(MaterialType))
            {
                SimpleDebugger.PrintLine(Tabs + "Create Material: " + item.Value + " of " + item.Key);
                var material = new Material(item.Key);
                // reduce time for one output unit and add total time
                time.AddTime(material.GetTotalCraftingTime(item.Value * OneUnitFactor));
         

            }
            Tabs = Tabs.Remove(0, 3);
            return time;

        }

        public string Print()
        {
            var sb = new StringBuilder();
            var preSellCost = GetPreSellCost();
            var sellingPrice = GetSellingPricePerUnit();

            sb.AppendLine("Item: " + MaterialType.ToString());
            //sb.AppendLine("Simple PreSellCost: " + preSellCost);
            //sb.AppendLine("Price: " + sellingPrice);
            //sb.AppendLine(GetTotalCraftingTime().Print());

            if (preSellCost > sellingPrice)
            {
                sb.AppendLine("BAD CRAFTING ITEM");
            }
            else
            {
                //sb.AppendLine("Simple crafting time in second: " + GetRawCraftingTimePerUnit().Max());
                //sb.AppendLine("Simple max amount per hour: " + (3600 / GetRawCraftingTimePerUnit().Max()));
                sb.AppendLine("Simple profit per hour: " + (sellingPrice - preSellCost) / GetRawCraftingTimePerUnit().Max() * 3600);
            }

            return sb.ToString();
        }

        private double GetPreSellCost()
        {
            var sum = 0.0;
            foreach (var item in Converter.GetRequiredItemPerCrafting(MaterialType))
                sum += new Material(item.Key).GetSellingPricePerUnit() * item.Value;

            return sum * OneUnitFactor;
        }

        //public void IncreaseCapacity(int itemAmount)
        //{
        //    OneUnitFactor = OneUnitFactor / CurrentItemCapacity * itemAmount;
        //    CurrentItemCapacity = itemAmount;
        //}

        public void DecreaseCapacityToSingleItem(double outputAmount)
        {
            OneUnitFactor = 1.0 / outputAmount;
        }
    }
}