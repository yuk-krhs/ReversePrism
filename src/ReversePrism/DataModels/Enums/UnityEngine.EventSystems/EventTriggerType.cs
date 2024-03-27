using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum EventTriggerType
    {
        PointerEnter,
        PointerExit,
        PointerDown,
        PointerUp,
        PointerClick,
        Drag,
        Drop,
        Scroll,
        UpdateSelected,
        Select,
        Deselect,
        Move,
        InitializePotentialDrag,
        BeginDrag,
        EndDrag,
        Submit,
        Cancel,
    }
}
