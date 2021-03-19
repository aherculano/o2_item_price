namespace Core.Model.Items
{
    public abstract class Item
    {
        
        public int Id {get;set;}

        public int TypeId {get;set;}

        protected Item()
        {
            //ORM/ODM
        }

        protected Item(int id, int typeId)
        {
            Id = id;
            TypeId = typeId;
        }
    }
}