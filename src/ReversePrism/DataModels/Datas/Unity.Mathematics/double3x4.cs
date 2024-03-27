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
    // 040 C2                                       0001866C40F0 ModelEnumType double3 double3 double3 Int32
    // 058 C3                                       0001866C40F0 ModelEnumType double3 double3 double3 Int32
    // 000 zero                                     double3x4 IL2CPP_TYPE_VALUETYPE
    public partial class double3x4
    {
        public double3                                  C0                                      { get; set; }
        public double3                                  C1                                      { get; set; }
        public double3                                  C2                                      { get; set; }
        public double3                                  C3                                      { get; set; }

        public static double3x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double3x4();

            value.C0                                        = (double3)GetInt32(new IntPtr(p + 0x010)); // 0270D7E78058 0x10 C0                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )
            value.C1                                        = (double3)GetInt32(new IntPtr(p + 0x028)); // 0270D7E78078 0x28 C1                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )
            value.C2                                        = (double3)GetInt32(new IntPtr(p + 0x040)); // 0270D7E78098 0x40 C2                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )
            value.C3                                        = (double3)GetInt32(new IntPtr(p + 0x058)); // 0270D7E780B8 0x58 C3                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )

            return value;
        }
    }
}
