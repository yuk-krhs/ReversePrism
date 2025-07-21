using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NON_EXISTING_TOUCH                       int IL2CPP_TYPE_I4
    // 020 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 PointerId                                ModelPrimitiveType int int int Int32
    // 02C InitialTouchPos                          ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class WindowDragHandler : DataModel
    {
        public RectTransform?                           RectTransform                           { get; set; }
        public int                                      PointerId                               { get; set; }
        public Vector2                                  InitialTouchPos                         { get; set; }

        public static WindowDragHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindowDragHandler() { Pointer= p0 };

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PointerId                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 PointerId                   ( ModelPrimitiveType int int int Int32 )
            value.InitialTouchPos                           = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0x2C InitialTouchPos             ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
