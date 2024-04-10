using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 M_Name                                   000186671910 ModelPrimitiveType string string string String
    public partial class AdaptivePerformanceScalerProfile : DataModel
    {
        public string                                   M_Name                                  { get; set; }

        public static AdaptivePerformanceScalerProfile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceScalerProfile() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x090)); // 0245A32D6C50 0x90 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
