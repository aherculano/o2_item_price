namespace Core.Model.Items.Consumable
{
    public class Consumable : Item
    {
        public bool IsDropable {get; set;}
    
        public double averagePrice { get; set; }

        protected Consumable() { 
            //ORM/ODM
        }

        public Consumable(int Id, int TypeId, bool isDropable, double averagePrice) : base(Id, TypeId)
        {
            IsDropable = isDropable;
            this.averagePrice = averagePrice;
        }
    }
}