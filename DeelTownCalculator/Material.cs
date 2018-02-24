using System;
using System.Collections.Generic;
using System.Text;

namespace DeelTownCalculator
{
    
   


    /// <summary>
    ///     all time are in seconds
    /// </summary>
    public class Material : IComparable
    {
        public double PieceAmount = 1;


        public Material(MaterialType type, double craftingTime)
        {
            RequiredItemOld = new List<Material>();
            MaterialType = type;
            CraftingTime = craftingTime;
        }

        public double CraftingTime { get; }

        private MaterialType MaterialType { get; }
        public List<Material> RequiredItemOld { get; set; }

        /// <summary>
        ///     Key: MaterialType - Int: item amount
        /// </summary>
        public Dictionary<MaterialType, int> RequiredItem { get; set; }


        public int CompareTo(object obj)
        {
            return obj == null ? MaterialType.CompareTo(null) : MaterialType.CompareTo(((Material)obj).MaterialType);
        }

        public double GetSellingPrice()
        {
            return Market.SellingPrices[MaterialType] / PieceAmount;
        }

        public double GetCraftingTime()
        {
            return CraftingTime / PieceAmount;
        }

        /// <summary>
        ///     TODO to define different timer
        /// </summary>
        /// <returns></returns>
        public double GetTotalCraftingTime()
        {
            var sum = GetCraftingTime();
            foreach (var item in RequiredItemOld) sum += item.GetTotalCraftingTime();

            return sum;
        }

        public string Print()
        {
            var sb = new StringBuilder();
            var preSellCost = GetPreSellCost();
            var sellingPrice = GetSellingPrice();

            sb.AppendLine(MaterialType.ToString());
            sb.AppendLine("Price: " + sellingPrice);
            sb.AppendLine("Mix Max crafting time in second: " + GetTotalCraftingTime());

            sb.AppendLine("Simple PreSellCost: " + preSellCost);

            if (preSellCost > sellingPrice)
            {
                sb.AppendLine("BAD CRAFTING ITEM");
            }
            else
            {
                sb.AppendLine("Simple crafting time in second " + CraftingTime);
                sb.AppendLine("Max simple profit per hour: " + (sellingPrice - preSellCost) / CraftingTime * 3600);
            }

            return sb.ToString();
        }

        private double GetPreSellCost()
        {
            var sum = 0.0;
            foreach (var item in RequiredItemOld) sum += item.GetSellingPrice();

            return sum;
        }

        public List<Material> Clones(int total)
        {
            var result = new List<Material>();

            for (var i = 0; i < total; i++) result.Add(this);

            return result;
        }

        public void ReduceCost(double craftingAmout)
        {
            PieceAmount = 1.0 / craftingAmout;
            foreach (var item in RequiredItemOld) item.PieceAmount = PieceAmount;
        }
    }
}