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
    // 000 identity                                 double3x3 IL2CPP_TYPE_VALUETYPE
    // 048 Zero                                     0001865E9E20 ModelEnumType double3x3 double3x3 double3x3 Int32
    public partial class double3x3
    {
        public double3                                  C0                                      { get; set; }
        public double3                                  C1                                      { get; set; }
        public double3                                  C2                                      { get; set; }
        public double3x3                                Zero                                    { get; set; }

        public static double3x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double3x3();

            value.C0                                        = (double3)GetInt32(new IntPtr(p + 0x010)); // 027001564680 0x10 C0                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )
            value.C1                                        = (double3)GetInt32(new IntPtr(p + 0x028)); // 0270015646A0 0x28 C1                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )
            value.C2                                        = (double3)GetInt32(new IntPtr(p + 0x040)); // 0270015646C0 0x40 C2                          ( 0001866C40F0 ModelEnumType double3 double3 double3 Int32 )
            value.Zero                                      = (double3x3)GetInt32(new IntPtr(p + 0x048)); // 027001564700 0x48 Zero                        ( 0001865E9E20 ModelEnumType double3x3 double3x3 double3x3 Int32 )

            return value;
        }
    }
}
