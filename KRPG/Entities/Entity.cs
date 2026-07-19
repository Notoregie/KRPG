using KRPG.Systems.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities
{
    public abstract class Entity
    {
        public abstract int Id { get; }
        public abstract string Type { get; }
        public string Name { get; private set; }

        public Entity(string name)
        {
            Name = name;
            IDTools.RegisterID(this);
        }
    }
}
