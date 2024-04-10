using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        0001865C2E50 ModelPrimitiveType double double double Double
    // 018 Y                                        0001865C2E50 ModelPrimitiveType double double double Double
    // 020 Z                                        0001865C2E50 ModelPrimitiveType double double double Double
    // 028 W                                        0001865C2E50 ModelPrimitiveType double double double Double
    // 000 zero                                     double4 IL2CPP_TYPE_VALUETYPE
    public partial class double4 : DataModel
    {
        public double                                   X                                       { get; set; }
        public double                                   Y                                       { get; set; }
        public double                                   Z                                       { get; set; }
        public double                                   W                                       { get; set; }

        public static double4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double4() { Pointer= p0 };

            value.X                                         = GetDouble(new IntPtr(p + 0x010)); // 0245A15755B0 0x10 X                           ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Y                                         = GetDouble(new IntPtr(p + 0x018)); // 0245A15755D0 0x18 Y                           ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Z                                         = GetDouble(new IntPtr(p + 0x020)); // 0245A15755F0 0x20 Z                           ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.W                                         = GetDouble(new IntPtr(p + 0x028)); // 0245A1575610 0x28 W                           ( 0001865C2E50 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
