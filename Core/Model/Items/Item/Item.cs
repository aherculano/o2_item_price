using Core.Model.Items.ItemType;

namespace Core.Model.Items.Item
{
    public abstract class Item
    {

        public ItemName Name { get; set; }

        public ItemTypeName TypeName { get; set; }

        protected Item(ItemName name, ItemTypeName typeName)
        {
            Name = name;
            TypeName = typeName;
        }
    }
}