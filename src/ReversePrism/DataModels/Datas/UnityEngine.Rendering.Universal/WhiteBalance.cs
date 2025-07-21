using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Temperature                              ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    // 040 Tint                                     ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer
    public partial class WhiteBalance : DataModel
    {
        public ClampedFloatParameter?                   Temperature                             { get; set; }
        public ClampedFloatParameter?                   Tint                                    { get; set; }

        public static WhiteBalance? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhiteBalance() { Pointer= p0 };

            value.Temperature                               = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x38 Temperature                 ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )
            value.Tint                                      = GetObject<ClampedFloatParameter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ClampedFloatParameter.FromPointer); // 0x40 Tint                        ( ModelClassType ClampedFloatParameter ClampedFloatParameter ClampedFloatParameter Pointer )

            return value;
        }
    }
}
