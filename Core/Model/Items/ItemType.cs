namespace Core.Model.Items
{
    public class ItemType
    {
        
        public int Id {get; set;}

        public string TypeName {get; set;}

        protected ItemType(){
            //ORM/ODM?!
        }

        public ItemType(int id, string typeName){
            Id = id;
            typeName = TypeName;
        }

    }
}