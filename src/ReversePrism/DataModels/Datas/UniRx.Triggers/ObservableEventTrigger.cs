using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onDeselect                               Subject`1<BaseEventData> IL2CPP_TYPE_GENERICINST
    // 058 onMove                                   Subject`1<AxisEventData> IL2CPP_TYPE_GENERICINST
    // 060 onPointerDown                            Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 068 onPointerEnter                           Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 070 onPointerExit                            Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 078 onPointerUp                              Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 080 onSelect                                 Subject`1<BaseEventData> IL2CPP_TYPE_GENERICINST
    // 088 onPointerClick                           Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 090 onSubmit                                 Subject`1<BaseEventData> IL2CPP_TYPE_GENERICINST
    // 098 onDrag                                   Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 0A0 onBeginDrag                              Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 0A8 onEndDrag                                Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 0B0 onDrop                                   Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 0B8 onUpdateSelected                         Subject`1<BaseEventData> IL2CPP_TYPE_GENERICINST
    // 0C0 onInitializePotentialDrag                Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    // 0C8 onCancel                                 Subject`1<BaseEventData> IL2CPP_TYPE_GENERICINST
    // 0D0 onScroll                                 Subject`1<PointerEventData> IL2CPP_TYPE_GENERICINST
    public partial class ObservableEventTrigger
    {

        public static ObservableEventTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableEventTrigger();


            return value;
        }
    }
}
