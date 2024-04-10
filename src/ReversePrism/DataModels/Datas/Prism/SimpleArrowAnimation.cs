using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LeftArrow                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 RightArrow                               000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 PunchStrength                            0001866656B0 ModelPrimitiveType float float float Single
    // 034 PunchDuration                            0001866656B0 ModelPrimitiveType float float float Single
    public partial class SimpleArrowAnimation : DataModel
    {
        public RectTransform?                           LeftArrow                               { get; set; }
        public RectTransform?                           RightArrow                              { get; set; }
        public float                                    PunchStrength                           { get; set; }
        public float                                    PunchDuration                           { get; set; }

        public static SimpleArrowAnimation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleArrowAnimation() { Pointer= p0 };

            value.LeftArrow                                 = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 024664CE5A68 0x20 LeftArrow                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RightArrow                                = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 024664CE5A88 0x28 RightArrow                  ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PunchStrength                             = GetSingle(new IntPtr(p + 0x030)); // 024664CE5AA8 0x30 PunchStrength               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PunchDuration                             = GetSingle(new IntPtr(p + 0x034)); // 024664CE5AC8 0x34 PunchDuration               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
