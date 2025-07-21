using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Panel                                  ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer
    // 028 M_PointerEvent                           ModelClassType PointerEvent PointerEvent PointerEvent Pointer
    // 030 M_LastClickTime                          ModelPrimitiveType float float float Single
    // 034 M_Selecting                              ModelPrimitiveType bool bool bool Bool
    // 038 M_Event                                  ModelClassType Event Event Event Pointer
    // 000 s_Modifiers                              EventModifiers IL2CPP_TYPE_VALUETYPE
    public partial class PanelEventHandler : DataModel
    {
        public BaseRuntimePanel?                        M_Panel                                 { get; set; }
        public PointerEvent?                            M_PointerEvent                          { get; set; }
        public float                                    M_LastClickTime                         { get; set; }
        public bool                                     M_Selecting                             { get; set; }
        public Event?                                   M_Event                                 { get; set; }

        public static PanelEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PanelEventHandler() { Pointer= p0 };

            value.M_Panel                                   = GetObject<BaseRuntimePanel>(new IntPtr(p + 0x020), ReversePrism.DataModels.BaseRuntimePanel.FromPointer); // 0x20 M_Panel                     ( ModelClassType BaseRuntimePanel BaseRuntimePanel BaseRuntimePanel Pointer )
            value.M_PointerEvent                            = GetObject<PointerEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.PointerEvent.FromPointer); // 0x28 M_PointerEvent              ( ModelClassType PointerEvent PointerEvent PointerEvent Pointer )
            value.M_LastClickTime                           = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_LastClickTime             ( ModelPrimitiveType float float float Single )
            value.M_Selecting                               = GetBool(new IntPtr(p + 0x034)); // 0x34 M_Selecting                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_Event                                   = GetObject<Event>(new IntPtr(p + 0x038), ReversePrism.DataModels.Event.FromPointer); // 0x38 M_Event                     ( ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
