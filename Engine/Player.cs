using System.Collections.Generic;
namespace Engine
{
    public class Player : LivingCreature
    {
        public int CurrentMP { get; set; }
        public int MaxMP { get; set; }
        public int Money { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public string Location { get; set; }

        public Player(int CurrentHP, int MaxHP, int money, int experiencePoints, int level) : base(CurrentHP, MaxHP)
        {
            Money = money;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}