using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_PointerMoveHandler                     EventFunction`1<IPointerMoveHandler> IL2CPP_TYPE_GENERICINST
    // 008 s_PointerEnterHandler                    EventFunction`1<IPointerEnterHandler> IL2CPP_TYPE_GENERICINST
    // 010 s_PointerExitHandler                     EventFunction`1<IPointerExitHandler> IL2CPP_TYPE_GENERICINST
    // 018 s_PointerDownHandler                     EventFunction`1<IPointerDownHandler> IL2CPP_TYPE_GENERICINST
    // 020 s_PointerUpHandler                       EventFunction`1<IPointerUpHandler> IL2CPP_TYPE_GENERICINST
    // 028 s_PointerClickHandler                    EventFunction`1<IPointerClickHandler> IL2CPP_TYPE_GENERICINST
    // 030 s_InitializePotentialDragHandler         EventFunction`1<IInitializePotentialDragHandler> IL2CPP_TYPE_GENERICINST
    // 038 s_BeginDragHandler                       EventFunction`1<IBeginDragHandler> IL2CPP_TYPE_GENERICINST
    // 040 s_DragHandler                            EventFunction`1<IDragHandler> IL2CPP_TYPE_GENERICINST
    // 048 s_EndDragHandler                         EventFunction`1<IEndDragHandler> IL2CPP_TYPE_GENERICINST
    // 050 s_DropHandler                            EventFunction`1<IDropHandler> IL2CPP_TYPE_GENERICINST
    // 058 s_ScrollHandler                          EventFunction`1<IScrollHandler> IL2CPP_TYPE_GENERICINST
    // 060 s_UpdateSelectedHandler                  EventFunction`1<IUpdateSelectedHandler> IL2CPP_TYPE_GENERICINST
    // 068 s_SelectHandler                          EventFunction`1<ISelectHandler> IL2CPP_TYPE_GENERICINST
    // 070 s_DeselectHandler                        EventFunction`1<IDeselectHandler> IL2CPP_TYPE_GENERICINST
    // 078 s_MoveHandler                            EventFunction`1<IMoveHandler> IL2CPP_TYPE_GENERICINST
    // 080 s_SubmitHandler                          EventFunction`1<ISubmitHandler> IL2CPP_TYPE_GENERICINST
    // 088 s_CancelHandler                          EventFunction`1<ICancelHandler> IL2CPP_TYPE_GENERICINST
    // 090 S_InternalTransformList                  000185D161C8 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer
    public partial class ExecuteEvents
    {
        public List<Transform>?                         S_InternalTransformList                 { get; set; }

        public static ExecuteEvents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecuteEvents();

            value.S_InternalTransformList                   = GetObjectList<Transform>(new IntPtr(p + 0x090), ReversePrism.DataModels.Transform.FromPointer); // 027004A48D58 0x90 S_InternalTransformList     ( 000185D161C8 ModelClassListType List`1<Transform> List`1<Transform> List<Transform> Pointer )

            return value;
        }
    }
}
