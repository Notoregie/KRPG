using KRPG.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Interfaces
{
    public interface IDamageCalculator
    {
        int Calculate(Stats attacker, Stats defender);
    }
}
