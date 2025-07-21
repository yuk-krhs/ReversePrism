using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_XCurve                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 M_YCurve                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 028 M_ZCurve                                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class CinemachineFixedSignal : DataModel
    {
        public AnimationCurve?                          M_XCurve                                { get; set; }
        public AnimationCurve?                          M_YCurve                                { get; set; }
        public AnimationCurve?                          M_ZCurve                                { get; set; }

        public static CinemachineFixedSignal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineFixedSignal() { Pointer= p0 };

            value.M_XCurve                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x18 M_XCurve                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_YCurve                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x020), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x20 M_YCurve                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_ZCurve                                  = GetObject<AnimationCurve>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x28 M_ZCurve                    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
