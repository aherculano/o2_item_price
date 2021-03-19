using System;
using System.Collections.Generic;

namespace Core.Model.Items.Leveling
{
    public class Upgrade
    {

        public int Id { get; set; }

        //Maps a Consumable Id to a Quantity
        public Dictionary<int, int> ItemQuantityMap { get; set; }

        public int DestinationLevel { get; set; }

        protected Upgrade() { 
            //ORM/ODM
        }

        public Upgrade(int id, Dictionary<int, int> itemQuantityMap, int destinationLevel)
        {
            Id = id;
            ItemQuantityMap = itemQuantityMap;
            DestinationLevel = destinationLevel;
        }
    }
}
