using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_AspectMode                             0001866BC140 ModelEnumType AspectMode AspectMode AspectMode Int32
    // 024 M_AspectRatio                            0001866656B0 ModelPrimitiveType float float float Single
    // 028 M_Rect                                   000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 M_DelayedSetDirty                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 M_DoesParentExist                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 M_Tracker                                000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    public partial class AspectRatioFitter
    {
        public AspectMode                               M_AspectMode                            { get; set; }
        public float                                    M_AspectRatio                           { get; set; }
        public RectTransform?                           M_Rect                                  { get; set; }
        public bool                                     M_DelayedSetDirty                       { get; set; }
        public bool                                     M_DoesParentExist                       { get; set; }
        public DrivenRectTransformTracker               M_Tracker                               { get; set; }

        public static AspectRatioFitter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AspectRatioFitter();

            value.M_AspectMode                              = (AspectMode)GetInt32(new IntPtr(p + 0x020)); // 027004375A70 0x20 M_AspectMode                ( 0001866BC140 ModelEnumType AspectMode AspectMode AspectMode Int32 )
            value.M_AspectRatio                             = GetSingle(new IntPtr(p + 0x024)); // 027004375A90 0x24 M_AspectRatio               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Rect                                    = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 027004375AB0 0x28 M_Rect                      ( 000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_DelayedSetDirty                         = GetBool(new IntPtr(p + 0x030)); // 027004375AD0 0x30 M_DelayedSetDirty           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DoesParentExist                         = GetBool(new IntPtr(p + 0x031)); // 027004375AF0 0x31 M_DoesParentExist           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Tracker                                 = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x032)); // 027004375B10 0x32 M_Tracker                   ( 000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )

            return value;
        }
    }
}
