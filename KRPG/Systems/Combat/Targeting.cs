using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRPG.Systems.Combat
{
    public enum TargetSelection
    {
        Single,
        Multiple,
        All
    }

    public enum TargetGroup
    {
        Self,
        Enemy,
        Party,
        All
    }

    public sealed class Targeting
    {
        public TargetGroup TargetGroup { get; }
        public TargetSelection TargetSelection { get; }
        public int TargetCount { get; }

        public Targeting(TargetGroup targetGroup, TargetSelection targetSelection, int count = 2)
        {
            TargetGroup = targetGroup;
            TargetSelection = targetSelection;
            TargetCount = count;
        }
    }
}
