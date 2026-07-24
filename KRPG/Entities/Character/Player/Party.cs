using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Entities.Character.Player
{
    public class Party
    {
        const int PARTY_LIMIT = 4;
        public bool IsFull => Players.Count >= PARTY_LIMIT;
        public List<Player> Players { get; } = new List<Player>();

        public Party()
        {

        }


    }
}
