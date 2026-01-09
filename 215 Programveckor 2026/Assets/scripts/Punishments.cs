using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts
{
    public class Punishments
    {
        public string item { get; protected set; }
        public int amonnt { get; protected set; }

        public Punishments(string item, int amount)
        {
            this.item = item;
            this.amonnt = amount;
        }
    }
}
