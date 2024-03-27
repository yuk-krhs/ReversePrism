using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum Collide
    {
        Head,
        Shoulder,
        ArmL,
        ArmR,
        ChestL,
        ChestR,
        Spine,
        ThighL,
        ThighR,
        Neck,
        ForeArmL,
        ForeArmR,
        ForeArmLForChest,
        ForeArmRForChest,
        Max,
    }
}
