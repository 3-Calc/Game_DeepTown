using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeelTownCalculator.Defines;

namespace DeelTownCalculator.Model
{
    public class CraftingTime
    {
        Dictionary<CrafterType, double> Dic = new Dictionary<CrafterType, double>();
        private double MaxTime = 0;

        public double AddTime(MaterialType type, double time)
        {
            var cType = Converter.GetCrafterType(type);
            if (!Dic.ContainsKey(cType))
                Dic.Add(cType, 0);
            Dic[cType] += time;
            return Dic[cType];
        }

        public string Print()
        {
            var sb = new StringBuilder();
            foreach (var d in Dic)
            {
                sb.AppendLine(d.Key + ": " + d.Value);
                if (d.Value > MaxTime)
                    MaxTime = d.Value;
            }

            sb.Append("Max requiredTime: " + MaxTime);
            return sb.ToString();
        }

        public double GetRequiredTime(MaterialType type)
        {
            var cType = Converter.GetCrafterType(type);
            if (!Dic.ContainsKey(cType))
                return 0;
            return Dic[cType];
        }

        public void AddTime(CraftingTime craftingTime)
        {
            foreach (var d in craftingTime.Dic)
            {
                if (!Dic.ContainsKey(d.Key))
                    Dic.Add(d.Key, 0);
                Dic[d.Key] += d.Value;
            }
        }

        public double Max()
        {
            foreach (var d in Dic)
            {
                if (d.Value > MaxTime)
                    MaxTime = d.Value;
            }

            return MaxTime;
        }
    }
}
