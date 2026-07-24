using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Character.Enemies
{
    public class Enemy : Character
    {
        public Enemy(int id, string name, Stats stats) : base(id, name, stats)
        {

        }
    }
}
