using KRPG.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Items.Consumeables
{
    public abstract class Consumeable : Item
    {
        public Consumeable(int id, string name) : base(id, name)
        {

        }

        public abstract bool CanConsume(Character target);
        public abstract void Use(Character target);
    }
}
