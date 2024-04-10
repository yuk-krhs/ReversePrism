using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C40F0 ModelEnumType double3 double3 double3 Int32
    // 028 C1                                       0001866C40F0 ModelEnumType double3 double3 double3 Int32
    // 000 zero                                     double3x2 IL2CPP_TYPE_VALUETYPE
    public partial class double3x2 : DataModel
    {
        public double3                                  C0                                      { get; set; }
        public double3                                  C1                                      { get; set; }

        public static double3x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double3x2() { Pointer= p0 };

            value.C0                                        = (double3)GetInt32(new IntPtr(p + 0x010)); // 024667EC9930 0x10 C0                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )
            value.C1                                        = (double3)GetInt32(new IntPtr(p + 0x028)); // 024667EC9950 0x28 C1                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )

            return value;
        }
    }
}
