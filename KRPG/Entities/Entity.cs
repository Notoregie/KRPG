using KRPG.Systems.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Entities
{
    public abstract class Entity
    {
        public int Id { get; init; }
        public string Name { get; private set; }

        public Entity(int id, string name)
        {
            Id = id;
            Name = name;
            IDTools.RegisterID(this);
        }
    }
}
