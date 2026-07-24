using KRPG.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Components.Effects
{
    public interface IItemEffect
    {
        void Apply(Character target);
    }
}
