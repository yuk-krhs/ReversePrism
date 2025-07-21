using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Target                                 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 M_PointerDownPosition                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 028 M_LastPointerDownTime                    ModelPrimitiveType long long long Int64
    // 030 M_ClickCount                             ModelPrimitiveType int int int Int32
    public partial class ButtonClickStatus : DataModel
    {
        public VisualElement?                           M_Target                                { get; set; }
        public Vector3                                  M_PointerDownPosition                   { get; set; }
        public long                                     M_LastPointerDownTime                   { get; set; }
        public int                                      M_ClickCount                            { get; set; }

        public static ButtonClickStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonClickStatus() { Pointer= p0 };

            value.M_Target                                  = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 M_Target                    ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_PointerDownPosition                     = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_PointerDownPosition       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_LastPointerDownTime                     = GetInt64(new IntPtr(p + 0x028)); // 0x28 M_LastPointerDownTime       ( ModelPrimitiveType long long long Int64 )
            value.M_ClickCount                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_ClickCount                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
