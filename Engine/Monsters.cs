﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Monsters : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardMoney { get; set; }

        public Monsters(int id, string name, int maximumDamage, int rewardExperiencePoints, int rewardMoney, int currentHitPoints, int maximumHitPoints) 
            : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardMoney = rewardMoney;
        }
    }
}
