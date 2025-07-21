using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 M_LastMousePosition                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 070 M_MousePosition                          ModelEnumType Vector2 Vector2 Vector2 Int32
    // 078 M_InputPointerEvent                      ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 080 M_ForceModuleActive                      ModelPrimitiveType bool bool bool Bool
    public partial class TouchInputModule : DataModel
    {
        public Vector2                                  M_LastMousePosition                     { get; set; }
        public Vector2                                  M_MousePosition                         { get; set; }
        public PointerEventData?                        M_InputPointerEvent                     { get; set; }
        public bool                                     M_ForceModuleActive                     { get; set; }

        public static TouchInputModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchInputModule() { Pointer= p0 };

            value.M_LastMousePosition                       = (Vector2)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_LastMousePosition         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_MousePosition                           = (Vector2)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_MousePosition             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_InputPointerEvent                       = GetObject<PointerEventData>(new IntPtr(p + 0x078), ReversePrism.DataModels.PointerEventData.FromPointer); // 0x78 M_InputPointerEvent         ( ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.M_ForceModuleActive                       = GetBool(new IntPtr(p + 0x080)); // 0x80 M_ForceModuleActive         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
