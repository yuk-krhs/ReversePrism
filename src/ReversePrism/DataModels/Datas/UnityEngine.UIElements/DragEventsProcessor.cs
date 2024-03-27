using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_IsRegistered                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 M_DragState                              0001865B6240 ModelEnumType DragState DragState DragState Int32
    // 018 M_Start                                  0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_Target                                 0001866B3770 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class DragEventsProcessor
    {
        public bool                                     M_IsRegistered                          { get; set; }
        public DragState                                M_DragState                             { get; set; }
        public Vector3                                  M_Start                                 { get; set; }
        public VisualElement?                           M_Target                                { get; set; }

        public static DragEventsProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DragEventsProcessor();

            value.M_IsRegistered                            = GetBool(new IntPtr(p + 0x010)); // 0270067549B0 0x10 M_IsRegistered              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DragState                               = (DragState)GetInt32(new IntPtr(p + 0x014)); // 0270067549D0 0x14 M_DragState                 ( 0001865B6240 ModelEnumType DragState DragState DragState Int32 )
            value.M_Start                                   = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270067549F0 0x18 M_Start                     ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Target                                  = GetObject<VisualElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.VisualElement.FromPointer); // 027006754A10 0x28 M_Target                    ( 0001866B3770 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
