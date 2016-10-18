using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroRPG.Shared
{
    class Player
    {
        public Stats PlayerStats { get; set; }
        public int TotalExperience { get; set; }

        public Player(Stats playerStats)
        {
            this.PlayerStats = playerStats;
            this.TotalExperience = 0;
        }
    }
}
