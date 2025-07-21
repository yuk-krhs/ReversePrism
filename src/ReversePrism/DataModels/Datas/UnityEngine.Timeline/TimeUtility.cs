using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kTimeEpsilon                             double IL2CPP_TYPE_R8
    // 008 kFrameRateEpsilon                        double IL2CPP_TYPE_R8
    // 010 K_MaxTimelineDurationInSeconds           ModelPrimitiveType double double double Double
    // 018 KFrameRateRounding                       ModelPrimitiveType double double double Double
    public partial class TimeUtility : DataModel
    {
        public double                                   K_MaxTimelineDurationInSeconds          { get; set; }
        public double                                   KFrameRateRounding                      { get; set; }

        public static TimeUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeUtility() { Pointer= p0 };

            value.K_MaxTimelineDurationInSeconds            = GetDouble(new IntPtr(p + 0x010)); // 0x10 K_MaxTimelineDurationInSeconds ( ModelPrimitiveType double double double Double )
            value.KFrameRateRounding                        = GetDouble(new IntPtr(p + 0x018)); // 0x18 KFrameRateRounding          ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
