using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts
{
    public class RewardsorPunishment
    {
        public string item { get; protected set; }
        public int amount { get; protected set; }

        public RewardsorPunishment(string item, int amount)
        {
            this.item = item;
            this.amount = amount;
        }
    }
}
