﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolskaBot
{
    public class BotSettings
    {
        public List<string> CollectableBoxes { get; set; } = new List<string>();
        public bool CollectorEnabled { get; set; }
        public bool CollectBonusBoxes { get; set; }
        public bool CollectEventBoxes { get; set; }

        // General settings
        public int HPLimit { get; set; } = 70;
        public int RepairAt { get; set; } = 1;

        public void Reload()
        {
            if (CollectBonusBoxes)
                CollectableBoxes.Add("BONUS_BOX");
            if (CollectEventBoxes)
            {
                CollectableBoxes.Add("EVENT_BOX");
                CollectableBoxes.Add("GIFT_BOXES");
            }
        }
    }
}
