using Core.Model.Items.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Items.Leveling
{
    public class LevelingPath
    {
        public ItemName ItemId { get; set; }
        public List<int> UpgradeListId { get; set; }

        protected LevelingPath() { 
            //ORM/ODM
        }

        public LevelingPath(ItemName itemId, List<int> upgradeListId)
        {
            ItemId = itemId;
            UpgradeListId = upgradeListId;
        }
    }
}
