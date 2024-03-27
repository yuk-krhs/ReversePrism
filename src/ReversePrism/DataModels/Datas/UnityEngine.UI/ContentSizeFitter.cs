using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_HorizontalFit                          00018651DD30 ModelEnumType FitMode FitMode FitMode Int32
    // 024 M_VerticalFit                            00018651DD30 ModelEnumType FitMode FitMode FitMode Int32
    // 028 M_Rect                                   000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 M_Tracker                                000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    public partial class ContentSizeFitter
    {
        public FitMode                                  M_HorizontalFit                         { get; set; }
        public FitMode                                  M_VerticalFit                           { get; set; }
        public RectTransform?                           M_Rect                                  { get; set; }
        public DrivenRectTransformTracker               M_Tracker                               { get; set; }

        public static ContentSizeFitter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContentSizeFitter();

            value.M_HorizontalFit                           = (FitMode)GetInt32(new IntPtr(p + 0x020)); // 0270D09D7CB0 0x20 M_HorizontalFit             ( 00018651DD30 ModelEnumType FitMode FitMode FitMode Int32 )
            value.M_VerticalFit                             = (FitMode)GetInt32(new IntPtr(p + 0x024)); // 0270D09D7CD0 0x24 M_VerticalFit               ( 00018651DD30 ModelEnumType FitMode FitMode FitMode Int32 )
            value.M_Rect                                    = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D09D7CF0 0x28 M_Rect                      ( 000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_Tracker                                 = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x030)); // 0270D09D7D10 0x30 M_Tracker                   ( 000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )

            return value;
        }
    }
}
