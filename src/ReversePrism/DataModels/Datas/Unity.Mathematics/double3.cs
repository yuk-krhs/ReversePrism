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
    // 000 zero                                     double3 IL2CPP_TYPE_VALUETYPE
    public partial class double3
    {
        public double                                   X                                       { get; set; }
        public double                                   Y                                       { get; set; }
        public double                                   Z                                       { get; set; }

        public static double3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double3();

            value.X                                         = GetDouble(new IntPtr(p + 0x010)); // 027001564720 0x10 X                           ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Y                                         = GetDouble(new IntPtr(p + 0x018)); // 027001564740 0x18 Y                           ( 0001865C2E50 ModelPrimitiveType double double double Double )
            value.Z                                         = GetDouble(new IntPtr(p + 0x020)); // 027001564760 0x20 Z                           ( 0001865C2E50 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
