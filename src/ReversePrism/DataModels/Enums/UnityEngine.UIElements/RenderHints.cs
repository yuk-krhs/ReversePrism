using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RenderHints
    {
        None,
        GroupTransform,
        BoneTransform,
        ClipWithScissors,
        MaskContainer,
        DynamicColor,
        DirtyOffset,
        DirtyGroupTransform,
        DirtyBoneTransform,
        DirtyClipWithScissors,
        DirtyMaskContainer,
        DirtyDynamicColor,
        DirtyAll,
    }
}
