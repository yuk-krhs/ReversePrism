using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_RaycastResultCache                     ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer
    // 028 M_SendPointerHoverToParent               ModelPrimitiveType bool bool bool Bool
    // 030 M_AxisEventData                          ModelClassType AxisEventData AxisEventData AxisEventData Pointer
    // 038 M_EventSystem                            ModelClassType EventSystem EventSystem EventSystem Pointer
    // 040 M_BaseEventData                          ModelClassType BaseEventData BaseEventData BaseEventData Pointer
    // 048 M_InputOverride                          ModelClassType BaseInput BaseInput BaseInput Pointer
    // 050 M_DefaultInput                           ModelClassType BaseInput BaseInput BaseInput Pointer
    public partial class BaseInputModule : DataModel
    {
        public List<RaycastResult>?                     M_RaycastResultCache                    { get; set; }
        public bool                                     M_SendPointerHoverToParent              { get; set; }
        public AxisEventData?                           M_AxisEventData                         { get; set; }
        public EventSystem?                             M_EventSystem                           { get; set; }
        public BaseEventData?                           M_BaseEventData                         { get; set; }
        public BaseInput?                               M_InputOverride                         { get; set; }
        public BaseInput?                               M_DefaultInput                          { get; set; }

        public static BaseInputModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseInputModule() { Pointer= p0 };

            value.M_RaycastResultCache                      = GetEnumList<RaycastResult>(new IntPtr(p + 0x020)); // 0x20 M_RaycastResultCache        ( ModelEnumListType List`1<RaycastResult> List`1<RaycastResult> List<RaycastResult> Pointer )
            value.M_SendPointerHoverToParent                = GetBool(new IntPtr(p + 0x028)); // 0x28 M_SendPointerHoverToParent  ( ModelPrimitiveType bool bool bool Bool )
            value.M_AxisEventData                           = GetObject<AxisEventData>(new IntPtr(p + 0x030), ReversePrism.DataModels.AxisEventData.FromPointer); // 0x30 M_AxisEventData             ( ModelClassType AxisEventData AxisEventData AxisEventData Pointer )
            value.M_EventSystem                             = GetObject<EventSystem>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventSystem.FromPointer); // 0x38 M_EventSystem               ( ModelClassType EventSystem EventSystem EventSystem Pointer )
            value.M_BaseEventData                           = GetObject<BaseEventData>(new IntPtr(p + 0x040), ReversePrism.DataModels.BaseEventData.FromPointer); // 0x40 M_BaseEventData             ( ModelClassType BaseEventData BaseEventData BaseEventData Pointer )
            value.M_InputOverride                           = GetObject<BaseInput>(new IntPtr(p + 0x048), ReversePrism.DataModels.BaseInput.FromPointer); // 0x48 M_InputOverride             ( ModelClassType BaseInput BaseInput BaseInput Pointer )
            value.M_DefaultInput                            = GetObject<BaseInput>(new IntPtr(p + 0x050), ReversePrism.DataModels.BaseInput.FromPointer); // 0x50 M_DefaultInput              ( ModelClassType BaseInput BaseInput BaseInput Pointer )

            return value;
        }
    }
}
