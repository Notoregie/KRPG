using KRPG.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KRPG.Systems.Other
{
    public static class IDTools
    {

        private static readonly Dictionary<int, Entity> _registeredIDs = new Dictionary<int, Entity>();

        public static void RegisterID(Entity entity)
        {
            if (_registeredIDs.TryGetValue(entity.Id, out Entity? existing))
            {
                throw new InvalidOperationException(
                    $"Cannot register entity '{entity.Name}' ({entity.GetType().Name}) with ID {entity.Id}. " +
                    $"The ID is already assigned to '{existing!.Name}' ({existing.GetType().Name}).");
            }

            _registeredIDs.Add(entity.Id, entity);
        }

        public static Entity? FindEntityFromID(int id)
        {
            return _registeredIDs.GetValueOrDefault(id);
        }
    }
}
