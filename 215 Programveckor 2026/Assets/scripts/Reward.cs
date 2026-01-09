using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts
{
    public class Rewards
    {
        public string item { get; protected set; }
        public int amonnt { get; protected set; }

        public Rewards (string item, int amount)
        {
            this.item = item;
            this.amonnt = amount;
        }
    }
}
