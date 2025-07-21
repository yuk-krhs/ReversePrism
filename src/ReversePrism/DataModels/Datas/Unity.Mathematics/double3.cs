using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 X                                        ModelPrimitiveType double double double Double
    // 018 Y                                        ModelPrimitiveType double double double Double
    // 020 Z                                        ModelPrimitiveType double double double Double
    // 000 zero                                     double3 IL2CPP_TYPE_VALUETYPE
    public partial class double3 : DataModel
    {
        public double                                   X                                       { get; set; }
        public double                                   Y                                       { get; set; }
        public double                                   Z                                       { get; set; }

        public static double3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double3() { Pointer= p0 };

            value.X                                         = GetDouble(new IntPtr(p + 0x010)); // 0x10 X                           ( ModelPrimitiveType double double double Double )
            value.Y                                         = GetDouble(new IntPtr(p + 0x018)); // 0x18 Y                           ( ModelPrimitiveType double double double Double )
            value.Z                                         = GetDouble(new IntPtr(p + 0x020)); // 0x20 Z                           ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
