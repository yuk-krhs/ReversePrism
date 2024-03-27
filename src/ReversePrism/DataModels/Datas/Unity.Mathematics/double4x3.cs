using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C4F90 ModelEnumType double4 double4 double4 Int32
    // 030 C1                                       0001866C4F90 ModelEnumType double4 double4 double4 Int32
    // 050 C2                                       0001866C4F90 ModelEnumType double4 double4 double4 Int32
    // 000 zero                                     double4x3 IL2CPP_TYPE_VALUETYPE
    public partial class double4x3
    {
        public double4                                  C0                                      { get; set; }
        public double4                                  C1                                      { get; set; }
        public double4                                  C2                                      { get; set; }

        public static double4x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double4x3();

            value.C0                                        = (double4)GetInt32(new IntPtr(p + 0x010)); // 0270D7E7FA80 0x10 C0                          ( 0001866C4F90 ModelEnumType double4 double4 double4 Int32 )
            value.C1                                        = (double4)GetInt32(new IntPtr(p + 0x030)); // 0270D7E7FAA0 0x30 C1                          ( 0001866C4F90 ModelEnumType double4 double4 double4 Int32 )
            value.C2                                        = (double4)GetInt32(new IntPtr(p + 0x050)); // 0270D7E7FAC0 0x50 C2                          ( 0001866C4F90 ModelEnumType double4 double4 double4 Int32 )

            return value;
        }
    }
}
