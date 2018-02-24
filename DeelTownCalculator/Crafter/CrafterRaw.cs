using System.Collections.Generic;

namespace DeelTownCalculator.Crafter
{
    public class CrafterRaw
    {
        /// <summary>
        ///     direct from mines or buying or collection
        /// </summary>
        /// <param name="type"></param>
        /// <param name="amout"></param>
        /// <returns></returns>
        public static List<Material> CreateRawResource(MaterialType type, int amout = 1)
        {
            // Define item
            var item = new Material(type, 0);
            return item.Clones(amout);
        }


        /// <summary>
        ///     Simple Single Crafting Item
        /// </summary>
        /// <param name="inputMaterial"></param>
        /// <param name="intputAmmount"></param>
        /// <param name="inputTime"></param>
        /// <param name="outputType"></param>
        /// <param name="outputAmount"></param>
        /// <returns></returns>
        public static List<Material> BaseResource(MaterialType inputMaterial, int intputAmmount, int inputTime,
            MaterialType outputType, int outputAmount)
        {
            // Define item
            var item = new Material(outputType, inputTime);
            // add required Items
            item.RequiredItemOld.AddRange(CreateRawResource(inputMaterial, intputAmmount));
            return CheckSingleItemRequest(outputType, item, outputAmount);
        }

        /// <summary>
        ///     Komplex Item
        /// </summary>
        /// <param name="type"></param>
        /// <param name="craftingTime"></param>
        /// <param name="amount"></param>
        /// <param name="requiredItem1"></param>
        /// <param name="requiredItem2"></param>
        /// <param name="requiredItem3"></param>
        /// <returns></returns>
        public static List<Material> Resource(MaterialType type, int craftingTime, int amount, List<Material> requiredItem1,
            List<Material> requiredItem2 = null, List<Material> requiredItem3 = null)
        {
            // Define item
            var item = new Material(type, craftingTime);

            // add required Items
            if (requiredItem1 != null)
                item.RequiredItemOld.AddRange(requiredItem1);
            if (requiredItem2 != null)
                item.RequiredItemOld.AddRange(requiredItem2);
            if (requiredItem3 != null)
                item.RequiredItemOld.AddRange(requiredItem3);


            return CheckSingleItemRequest(type, item, amount);
        }

        /// <summary>
        ///     Checking the wishes output, depends on packet amount per one crafting process
        /// </summary>
        /// <param name="type"></param>
        /// <param name="item"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static List<Material> CheckSingleItemRequest(MaterialType type, Material item, int amount = 1)
        {
            var craftingAmout = Processor.MultiOutputList.ContainsKey(type) ? Processor.MultiOutputList[type] : 1;
            // Packet is more than 1 out
            if (craftingAmout != 1)
                item.ReduceCost(craftingAmout);

            // calculate the needed amount
            return item.Clones(amount);
        }
    }
}