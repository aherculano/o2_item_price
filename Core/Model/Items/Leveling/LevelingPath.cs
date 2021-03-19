using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.Items.Leveling
{
    public class LevelingPath
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public List<int> UpgradeListId { get; set; }

        protected LevelingPath() { 
            //ORM/ODM
        }

        public LevelingPath(int id, int itemId, List<int> upgradeListId)
        {
            Id = id;
            ItemId = itemId;
            UpgradeListId = upgradeListId;
        }
    }
}
