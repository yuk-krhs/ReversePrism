using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 A                                        000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 018 I                                        000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 U                                        000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 E                                        000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 030 O                                        000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class LipCurveData
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
            var value   = new LipCurveData();

            value.A                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x010), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4DFD050 0x10 A                           ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.I                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4DFD070 0x18 I                           ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.U                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4DFD090 0x20 U                           ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.E                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4DFD0B0 0x28 E                           ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.O                                         = GetObject<AnimationCurve>(new IntPtr(p + 0x030), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0270D4DFD0D0 0x30 O                           ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
