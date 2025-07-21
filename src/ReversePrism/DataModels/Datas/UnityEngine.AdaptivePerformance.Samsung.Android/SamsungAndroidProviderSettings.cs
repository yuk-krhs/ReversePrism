using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_SamsungProviderLogging                 ModelPrimitiveType bool bool bool Bool
    // 041 M_HighSpeedVRR                           ModelPrimitiveType bool bool bool Bool
    // 042 M_AutomaticVRR                           ModelPrimitiveType bool bool bool Bool
    // 000 s_RuntimeInstance                        SamsungAndroidProviderSettings IL2CPP_TYPE_CLASS
    public partial class SamsungAndroidProviderSettings : DataModel
    {
        public bool                                     M_SamsungProviderLogging                { get; set; }
        public bool                                     M_HighSpeedVRR                          { get; set; }
        public bool                                     M_AutomaticVRR                          { get; set; }

        public static SamsungAndroidProviderSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SamsungAndroidProviderSettings() { Pointer= p0 };

            value.M_SamsungProviderLogging                  = GetBool(new IntPtr(p + 0x040)); // 0x40 M_SamsungProviderLogging    ( ModelPrimitiveType bool bool bool Bool )
            value.M_HighSpeedVRR                            = GetBool(new IntPtr(p + 0x041)); // 0x41 M_HighSpeedVRR              ( ModelPrimitiveType bool bool bool Bool )
            value.M_AutomaticVRR                            = GetBool(new IntPtr(p + 0x042)); // 0x42 M_AutomaticVRR              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
