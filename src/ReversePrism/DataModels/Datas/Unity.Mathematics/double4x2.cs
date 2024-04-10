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
    // 000 zero                                     double4x2 IL2CPP_TYPE_VALUETYPE
    public partial class double4x2 : DataModel
    {
        public double4                                  C0                                      { get; set; }
        public double4                                  C1                                      { get; set; }

        public static double4x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double4x2() { Pointer= p0 };

            value.C0                                        = (double4)GetInt32(new IntPtr(p + 0x010)); // 024667ED2E60 0x10 C0                          ( 0001866C4F90 ModelEnumType double4 double4 double4 Int32 )
            value.C1                                        = (double4)GetInt32(new IntPtr(p + 0x030)); // 024667ED2E80 0x30 C1                          ( 0001866C4F90 ModelEnumType double4 double4 double4 Int32 )

            return value;
        }
    }
}
