using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum EventCategory
    {
        Default,
        Pointer,
        PointerMove,
        EnterLeave,
        EnterLeaveWindow,
        Keyboard,
        Geometry,
        Style,
        ChangeValue,
        Bind,
        Focus,
        ChangePanel,
        StyleTransition,
        Navigation,
        Command,
        Tooltip,
        IMGUI,
        Reserved,
    }
}
