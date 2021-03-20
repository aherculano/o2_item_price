using Core.Model.Items.Item;
using Core.Model.Items.ItemType;

namespace Core.Model.Items.Consumable
{
    public class Consumable : Item.Item
    {
        public bool IsDropable {get; set;}
    
        public double averagePrice { get; set; }

        public Consumable(ItemName name, ItemTypeName typeName, bool isDropable, double averagePrice) : base(name,typeName)
        {
            IsDropable = isDropable;
            this.averagePrice = averagePrice;
        }
    }
}