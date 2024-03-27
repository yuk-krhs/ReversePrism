using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum CameraType
    {
        Drone,
        CenterMiddle,
        CenterUp,
        CenterDown,
        LeftMiddle,
        LeftUp,
        LeftDown,
        RightMiddle,
        RightUp,
        RightDown,
        BackMiddle,
        BackUp,
        BackDown,
        HalfLeftMiddle,
        HalfLeftUp,
        HalfLeftDown,
        HalfRightMiddle,
        HalfRightUp,
        HalfRightDown,
    }
}
