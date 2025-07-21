using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Body                                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 Duration                                 ModelPrimitiveType float float float Single
    // 034 InPos                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 03C OutPos                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class SimpleSlideAnimation : DataModel
    {
        public RectTransform?                           Body                                    { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    Duration                                { get; set; }
        public Vector2                                  InPos                                   { get; set; }
        public Vector2                                  OutPos                                  { get; set; }

        public static SimpleSlideAnimation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleSlideAnimation() { Pointer= p0 };

            value.Body                                      = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 Body                        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x030)); // 0x30 Duration                    ( ModelPrimitiveType float float float Single )
            value.InPos                                     = (Vector2)GetInt32(new IntPtr(p + 0x034)); // 0x34 InPos                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OutPos                                    = (Vector2)GetInt32(new IntPtr(p + 0x03C)); // 0x3C OutPos                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
