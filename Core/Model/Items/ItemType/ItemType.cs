namespace Core.Model.Items.ItemType
{
    public class ItemType
    {
        public ItemTypeName Name {get; set;}

        public ItemType(ItemTypeName name){
            Name = name;
        }

        public static ItemType BuildItemType(string name) {
            ItemTypeName itemTypeName = new ItemTypeName(name);

            return new ItemType(itemTypeName);
        }

    }
}