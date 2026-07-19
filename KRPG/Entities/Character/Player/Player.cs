using KRPG.Components;
using KRPG.Entities.Items.Equipment;
using KRPG.Interfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities.Character.Player
{
    public class Player : Character
    {
        public override int Id => 0000;
        public Player(string name, Stats stats) : base(name, stats)
        {

        }
    }
}
