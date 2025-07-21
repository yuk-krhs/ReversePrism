using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 018 I                                        ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 U                                        ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 E                                        ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 030 O                                        ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class LipCurveData : DataModel
    {
        public AnimationCurve?                          A                                       { get; set; }
        public AnimationCurve?                          I                                       { get; set; }
        public AnimationCurve?                          U                                       { get; set; }
        public AnimationCurve?                          E                                       { get; set; }
        public AnimationCurve?                          O                                       { get; set; }

        public static LipCurveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LipCurveData() { Pointer= p0 };

            value.A                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x10 A                           ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.I                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x18 I                           ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.U                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x20 U                           ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.E                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x28 E                           ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.O                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x30 O                           ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
