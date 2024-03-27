using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Body                                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 Duration                                 0001866656B0 ModelPrimitiveType float float float Single
    // 034 InPos                                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 03C OutPos                                   0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class SimpleSlideAnimation
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
            var value   = new SimpleSlideAnimation();

            value.Body                                      = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D4C82198 0x20 Body                        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D4C821B8 0x28 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x030)); // 0270D4C821D8 0x30 Duration                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InPos                                     = (Vector2)GetInt32(new IntPtr(p + 0x034)); // 0270D4C821F8 0x34 InPos                       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.OutPos                                    = (Vector2)GetInt32(new IntPtr(p + 0x03C)); // 0270D4C82218 0x3C OutPos                      ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
