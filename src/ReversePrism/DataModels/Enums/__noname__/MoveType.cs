using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum MoveType
    {
        OpenEye,
        CloseEye,
        Blink,
        WinkL,
        WinkR,
        OpenEyeSmile,
        CloseEyeSmile,
        BlinkSmile,
        WinkLSmile,
        WinkRSmile,
        EyelidEnd,
        ChangeTarget,
        LeftIKOn,
        LeftIKOff,
        LeftIKAttract,
        LeftIKEnd,
        RightIKOn,
        RightIKOff,
        RightIKAttract,
        RightIKEnd,
        EyebrowNormal,
        EyebrowSad,
        EyebrowSerious,
        EyebrowUnique,
        EyebrowUp,
        EyebrowDown,
        EyebrowEnd,
        EyebrowAddNone,
        EyebrowAddUp,
        EyebrowAddDown,
        EyebrowAddEnd,
        MouthNormal,
        MouthOverwriteLip,
        MouthLipSerious,
        MouthEnd,
        EyeLimit,
    }
}
